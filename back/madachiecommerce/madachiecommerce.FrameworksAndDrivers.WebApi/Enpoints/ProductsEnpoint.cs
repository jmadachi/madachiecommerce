using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.InterfaceAdapters.Gateways;
using Microsoft.AspNetCore.Mvc;

namespace madachiecommerce.FrameworksAndDrivers.WebApi.Enpoints
{
    [ApiController]
    [Route("api/products")]
    public class ProductsEndpoint: ControllerBase
    {
        private readonly madachiecommerceContext Context;
        private readonly IListProductsController ProductsController;
        public ProductsEndpoint(madachiecommerceContext context, IListProductsController productsController)
        {
            Context = context;
            ProductsController = productsController;    
        }

        [HttpGet]
        public async ValueTask<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var list = await ProductsController.ListProducts();    
            return Ok(list);    
        }
    }
}
