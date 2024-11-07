using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Controllers;
public class ListOrderHeaderController: IListOrderHeadersController
{
    readonly IListOrderHeadersInputPort InputPort;
    readonly IListOrderHeadersPresenter Presenter;

    public ListOrderHeaderController(IListOrderHeadersInputPort inputPort, IListOrderHeadersPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;  
    }

    public async ValueTask<IEnumerable<OrderHeaderDto>> ListOrderHeaders()
    {
        await InputPort.Handle();
        return Presenter.orderHeaders;
    }
}
