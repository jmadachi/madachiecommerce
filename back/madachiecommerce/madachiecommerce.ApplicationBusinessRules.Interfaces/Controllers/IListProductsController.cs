using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListProductsController
{
    ValueTask<IEnumerable<ProductDto>> ListProducts();
}
