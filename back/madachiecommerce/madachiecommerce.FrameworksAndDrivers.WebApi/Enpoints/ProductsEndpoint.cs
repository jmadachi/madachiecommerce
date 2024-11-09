using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace madachiecommerce.FrameworksAndDrivers.WebApi.Endpoints;

[ApiController]
[Route("api/products")]
public class ProductsEndpoint: ControllerBase
{
    private readonly IListProductsController ProductsController;
    public ProductsEndpoint(IListProductsController productsController)
    {
        ProductsController = productsController;    
    }

    [HttpGet]
    public async ValueTask<ActionResult<IEnumerable<ProductDto>>> GetProducts()
    {
        var list = await ProductsController.ListProducts();    
        return Ok(list);    
    }
}
