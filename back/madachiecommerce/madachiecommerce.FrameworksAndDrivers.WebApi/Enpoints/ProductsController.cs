using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.InterfaceAdapters.Gateways;
using Microsoft.AspNetCore.Mvc;

namespace madachiecommerce.FrameworksAndDrivers.WebApi.Enpoints
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController: ControllerBase
    {
        private readonly madachiecommerceContext Context;
        private readonly IListProductsController Controller;
        public ProductsController(madachiecommerceContext context, IListProductsController productsController)
        {
            Context = context;
            Controller = productsController;    
        }

        [HttpGet]
        public async ValueTask<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var list = await Controller.ListProducts();    
            return Ok(list);    
        }
    }
}
