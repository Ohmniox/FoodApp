using FoodApp.Entities;
using FoodApp.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Domain.Mapper
{
    public static class OrderMapper
    {
        public static Order Map(OrderRequestModel orderRequestModel, Guid userId)
        {
            return new Order()
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                RestaurantId = orderRequestModel.RestaurantId,
            };
        }

        public static OrderLine Map(OrderRequestModel.OrderLineRequestModel orderLineRequestModel, Guid orderId, decimal unitPrice)
        {
            return new OrderLine()
            {
                Id = Guid.NewGuid(),
                OrderId = orderId,
                FoodId = orderLineRequestModel.FoodId,
                Quantity = orderLineRequestModel.Quantity,
                UnitPrice = unitPrice
            };
        }

        public static OrderLineOption Map(OrderRequestModel.OrderLineRequestModel.OrderLineOptionRequestModel orderLineOptionRequestModel, Guid orderLineId, decimal unitPrice)
        {
            return new OrderLineOption()
            {
                Id = Guid.NewGuid(),
                OrderLineId = orderLineId,
                UnitPrice = unitPrice,
                FoodCustomizationOptionId = orderLineOptionRequestModel.FoodCustomizationOptionId
            };
        }
    }
}
