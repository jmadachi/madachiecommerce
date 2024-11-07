using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListProductsPresenter: IListProductsOutputPort
{
    IEnumerable<ProductDto> Products { get; }
}
