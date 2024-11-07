using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Controllers;
public class ListOrderHeadersController: IListOrderHeadersController
{
    readonly IListOrderHeadersInputPort InputPort;
    readonly IListOrderHeadersPresenter Presenter;

    public ListOrderHeadersController(IListOrderHeadersInputPort inputPort, IListOrderHeadersPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;  
    }

    public async ValueTask<IEnumerable<OrderHeaderDto>> ListOrderHeaders()
    {
        await InputPort.Handle();
        return Presenter.OrderHeaders;
    }
}
