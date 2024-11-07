using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListProductsOutputPort
{
    ValueTask Handle(IEnumerable<ProductDto> products);
}
