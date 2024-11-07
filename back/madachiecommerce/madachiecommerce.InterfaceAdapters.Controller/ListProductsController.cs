using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Controllers;
public class ListProductsController: IListProductsController
{
    readonly IListProductsInputPort InputPort;
    readonly IListProductsPresenter Presenter;

    public ListProductsController(IListProductsInputPort inputPort, IListProductsPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;  
    }

    public async ValueTask<IEnumerable<ProductDto>> ListProducts()
    {
        await InputPort.Handle();
        return Presenter.Products;
    }
}
