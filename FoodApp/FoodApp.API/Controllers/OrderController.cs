using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.API.Controllers.Shared;
using FoodApp.API.Filters;
using FoodApp.Core.Services.Contracts;
using FoodApp.Library.Enum;
using FoodApp.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [FoodApAuthorize((int)UserType.Consumer)]
    public class OrderController : FoodAppBaseController
    {
        private readonly IOrderService orderService;
        private readonly ILogger<OrderController> logger;

        public OrderController(IOrderService orderService, ILogger<OrderController> logger)
        {
            this.orderService = orderService;
            this.logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody]OrderRequestModel orderRequestModel)
        {
            var (error, orderId) = await orderService.CreateOrder(orderRequestModel, this.RequestInfoModel.UserId);
            if (error != null)
            {
                return this.BadRequest(error);
            }
            return CreatedAtAction("GetOrder", new { id = orderId }, new { id = orderId });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder([FromRoute(Name = "id")]Guid orderId)
        {
            var order = await orderService.GetOrder(orderId);
            if (order == null)
            {
                return this.NotFound();
            }
            return Ok(order);
        }

    }
}