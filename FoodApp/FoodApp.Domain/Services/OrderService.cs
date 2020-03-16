using FoodApp.Core.Services.Contracts;
using FoodApp.Data;
using FoodApp.Domain.Mapper;
using FoodApp.Entities;
using FoodApp.Models.Request;
using FoodApp.Models.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly FoodAppDbContext foodAppDbContext;
        private readonly ILogger<OrderService> logger;

        public OrderService(FoodAppDbContext foodAppDbContext, ILogger<OrderService> logger)
        {
            this.foodAppDbContext = foodAppDbContext;
            this.logger = logger;
        }

        public async Task<(BadRequestResponseModel, Guid)> CreateOrder(OrderRequestModel orderRequestModel, Guid userId)
        {
            Guid orderId = Guid.Empty;
            var restuarant = await this.foodAppDbContext.Restaurants.AsNoTracking().FirstOrDefaultAsync(x => x.Id == orderRequestModel.RestaurantId);
            if (restuarant == null)
            {
                return (new BadRequestResponseModel() { ErrorMessage = "Invalid RestaurantId" }, orderId);
            }

            var restuarantFoodCategoryIds = await this.foodAppDbContext.RestaurantFoodCategoryMaps.AsNoTracking()
                                        .Include(x => x.FoodCategory)
                                        .Where(x => x.RestaurantId == orderRequestModel.RestaurantId)
                                        .Select(x => x.FoodCategory.Id)
                                        .ToListAsync();
            var restaurantFoods = await this.foodAppDbContext.Foods.AsNoTracking()
                                        .Where(x => restuarantFoodCategoryIds.Any(r => r == x.FoodCategoryId))
                                        .ToListAsync();
            var restaurantFoodIds = restaurantFoods.Select(x => x.Id).ToList();
            var orderRequestFoodIds = orderRequestModel.OrderLines.Select(x => x.FoodId).ToList();

            var foodCustomizationIds = await this.foodAppDbContext.FoodCategoryCustomizationMaps.AsNoTracking()
                                        .Where(x => restuarantFoodCategoryIds.Any(r => r == x.FoodCategoryId))
                                        .Select(x => x.FoodCustomizationId)
                                        .ToListAsync();
            var foodCustomizationOptions = await this.foodAppDbContext.FoodCustomizationOptions.AsNoTracking()
                                        .Where(x => foodCustomizationIds.Any(f => f == x.FoodCustomizationId))
                                        .ToListAsync();
            bool isFoodIdValid = !orderRequestFoodIds.Except(restaurantFoodIds).Any();
            if (!isFoodIdValid)
            {
                return (new BadRequestResponseModel() { ErrorMessage = "FoodId doesnt belong to selected restaurant" }, orderId);
            }

            using (var transaction = foodAppDbContext.Database.BeginTransaction())
            {
                try
                {
                    var order = OrderMapper.Map(orderRequestModel, userId);
                    orderId = order.Id;
                    var orderLines = new List<OrderLine>();
                    var orderLineOptions = new List<OrderLineOption>();
                    var totalAmount = 0.00m;
                    foreach (var orderLineRequest in orderRequestModel.OrderLines)
                    {
                        var food = restaurantFoods.FirstOrDefault(x => x.Id == orderLineRequest.FoodId);
                        var orderLine = OrderMapper.Map(orderLineRequest, order.Id, food.UnitPrice);
                        orderLines.Add(orderLine);
                        totalAmount += (orderLineRequest.Quantity * food.UnitPrice);
                        foreach (var orderLineOptionRequest in orderLineRequest.OrderLineOptions)
                        {
                            var foodCustomizationOption = foodCustomizationOptions.FirstOrDefault(x => x.Id == orderLineOptionRequest.FoodCustomizationOptionId);
                            orderLineOptions.Add(OrderMapper.Map(orderLineOptionRequest, orderLine.Id, foodCustomizationOption.UnitPrice));
                            totalAmount += foodCustomizationOption.UnitPrice;
                        }
                    }

                    order.TotalAmount = totalAmount;

                    await foodAppDbContext.AddAsync(order);
                    await foodAppDbContext.SaveChangesAsync();

                    await foodAppDbContext.AddRangeAsync(orderLines);
                    await foodAppDbContext.SaveChangesAsync();

                    await foodAppDbContext.AddRangeAsync(orderLineOptions);
                    await foodAppDbContext.SaveChangesAsync();

                    await transaction.CommitAsync();
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
            return (null, orderId);
        }

        public async Task<OrderDetailResponseModel> GetOrder(Guid orderId, Guid userId)
        {
            var order = await this.foodAppDbContext.Orders.AsNoTracking().Include(x => x.Restaurant)
                                    .FirstOrDefaultAsync(x => x.Id == orderId && x.UserId == userId);
            if (order == null)
            {
                return null;
            }

            var orderLines = await this.foodAppDbContext.OrderLines.AsNoTracking().Include(c => c.OrderLineOptions)
                                    .Where(x => x.OrderId == orderId).ToListAsync();

            var orderResponseModel = new OrderDetailResponseModel
            {
                OrderId = order.Id,
                RestaurantId = order.Restaurant.Id,
                RestaurantName = order.Restaurant.Name,
                TotalAmount = order.TotalAmount
            };

            var orderLineResponseModels = new List<OrderDetailResponseModel.OrderLineResponseModel>();

            if (orderLines != null)
            {

                var orderLineIds = orderLines.Select(x => x.Id).ToList();
                var orderLineOptions = await this.foodAppDbContext.OrderLineOptions.AsNoTracking()
                                        .Where(x => orderLineIds.Any(o => o == x.OrderLineId))
                                        .ToListAsync();

                var foodIds = orderLines.Select(x => x.FoodId).ToList();
                var foods = await this.foodAppDbContext.Foods.AsNoTracking()
                                    .Where(x => foodIds.Any(f => f == x.Id))
                                    .ToListAsync();

                var foodCustomizationOptionIds = orderLineOptions.Select(x => x.FoodCustomizationOptionId).ToList();
                var foodCustomizationOptions = await this.foodAppDbContext.FoodCustomizationOptions.AsNoTracking()
                                                    .Where(x => foodCustomizationOptionIds.Any(f => f == x.Id))
                                                    .ToListAsync();
                foreach (var orderLine in orderLines)
                {
                    var orderLineOptionResponseModels = new List<OrderDetailResponseModel.OrderLineResponseModel.OrderLineOptionResponseModel>();
                    foreach (var orderLineOption in orderLine.OrderLineOptions)
                    {
                        var foodCustomizationOption = foodCustomizationOptions.FirstOrDefault(x => x.Id == orderLineOption.FoodCustomizationOptionId);
                        var orderLineOptionResponseModel = new OrderDetailResponseModel.OrderLineResponseModel.OrderLineOptionResponseModel
                        {
                            FoodCustomizationOptionId = orderLineOption.FoodCustomizationOptionId,
                            FoodCustomizationOptionName = foodCustomizationOption.Name,
                            UnitPrice = orderLineOption.UnitPrice
                        };
                        orderLineOptionResponseModels.Add(orderLineOptionResponseModel);
                    }

                    var food = foods.FirstOrDefault(x => x.Id == orderLine.FoodId);
                    var orderLineResponseModel = new OrderDetailResponseModel.OrderLineResponseModel
                    {
                        FoodId = orderLine.FoodId,
                        FoodName = food.Name,
                        Quantity = orderLine.Quantity,
                        UnitPrice = orderLine.UnitPrice,
                        OrderLineOptions = orderLineOptionResponseModels
                    };
                    orderLineResponseModels.Add(orderLineResponseModel);
                }
                orderResponseModel.OrderLines = orderLineResponseModels;
            }

            return orderResponseModel;
        }

        public async Task<List<OrderResponseModel>> GetOrders(Guid userId)
        {
            var orders = await this.foodAppDbContext.Orders.AsNoTracking().Include(x => x.Restaurant)
                                    .Where(x => x.UserId == userId)
                                    .Select(x => new OrderResponseModel
                                    {
                                        OrderId = x.Id,
                                        RestaurantId = x.RestaurantId,
                                        RestaurantName = x.Restaurant.Name,
                                        TotalAmount = x.TotalAmount
                                    }).ToListAsync();
            return orders;
        }
    }
}
