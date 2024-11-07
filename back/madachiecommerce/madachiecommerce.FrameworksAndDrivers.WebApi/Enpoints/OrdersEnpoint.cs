using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.InterfaceAdapters.Gateways;
using Microsoft.AspNetCore.Mvc;

namespace madachiecommerce.FrameworksAndDrivers.WebApi.Enpoints
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersEndpoint: ControllerBase
    {
        private readonly madachiecommerceContext Context;
        private readonly IListOrderDetailsController OrderDetailsController;
        public OrdersEndpoint(madachiecommerceContext context, IListOrderDetailsController orderDetailsController)
        {
            Context = context;
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
