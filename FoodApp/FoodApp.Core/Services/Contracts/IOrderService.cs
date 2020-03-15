
using FoodApp.Entities;
using FoodApp.Models.Request;
using FoodApp.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Services.Contracts
{
    public interface IOrderService : IService
    {
        Task<(BadRequestResponseModel, Guid)> CreateOrder(OrderRequestModel orderRequestModel, Guid userId);
        Task<OrderResponseModel> GetOrder(Guid orderId);
    }
}
