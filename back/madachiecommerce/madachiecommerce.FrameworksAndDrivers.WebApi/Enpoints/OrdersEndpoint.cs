using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace madachiecommerce.FrameworksAndDrivers.WebApi.Enpoints
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersEndpoint: ControllerBase
    {
        private readonly IListOrderDetailsController OrderDetailsController;
        public OrdersEndpoint(IListOrderDetailsController orderDetailsController)
        {
            OrderDetailsController = orderDetailsController;    
        }

        [HttpGet("details")]
        public async ValueTask<ActionResult<IEnumerable<OrderDetailDto>>> GetOrderDetails(int orderHeaderId)
        {
            var list = await OrderDetailsController.ListOrderDetails(orderHeaderId);    
            return Ok(list);    
        }
    }
}
