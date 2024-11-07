using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfacesAdapters.Presenters;
public class ListProductsPresenter: IListProductsPresenter
{
    public IEnumerable<ProductDto> Products { get; private set; }

    public ValueTask Handle(IEnumerable<ProductDto> products)
    {
        Products = products;    
        return ValueTask.CompletedTask;
    }
}
