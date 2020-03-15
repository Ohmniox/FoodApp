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

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderController"/> class.
        /// </summary>
        /// <param name="orderService">The order service.</param>
        /// <param name="logger">The logger.</param>
        public OrderController(IOrderService orderService, ILogger<OrderController> logger)
        {
            this.orderService = orderService;
            this.logger = logger;
        }

        /// <summary>
        /// Creates the order.
        /// </summary>
        /// <param name="orderRequestModel">The order request model.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody]OrderRequestModel orderRequestModel)
        {
            logger.LogInformation("CreateOrder request started");
            var (error, orderId) = await orderService.CreateOrder(orderRequestModel, this.RequestInfoModel.UserId);
            if (error != null)
            {
                logger.LogWarning($"Invalid request : {error}");
                return this.BadRequest(error);
            }
            logger.LogInformation("CreateOrder request completed successfully");
            return CreatedAtAction("GetOrder", new { id = orderId }, new { id = orderId });
        }

        /// <summary>
        /// Gets the orders for logged in user.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var order = await orderService.GetOrders(this.RequestInfoModel.UserId);
            return Ok(order);
        }

        /// <summary>
        /// Gets the order by id.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder([FromRoute(Name = "id")]Guid orderId)
        {
            logger.LogInformation("GetOrder request started");
            var order = await orderService.GetOrder(orderId, this.RequestInfoModel.UserId);
            if (order == null)
            {
                logger.LogWarning($"Order with id : {orderId} not found");
                return this.NotFound();
            }
            logger.LogInformation("GetOrder request completed successfully");
            return Ok(order);
        }

    }
}