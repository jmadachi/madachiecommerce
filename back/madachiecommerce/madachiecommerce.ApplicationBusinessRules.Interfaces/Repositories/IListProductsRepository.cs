using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListProductsRepository
{
    ValueTask<IEnumerable<ProductDto>> ListProducts();
}
