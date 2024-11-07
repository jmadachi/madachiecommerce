using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Controllers;
public class ListOrderDetailsController: IListOrderDetailsController
{
    readonly IListOrderDetailsInputPort InputPort;
    readonly IListOrderDetailsPresenter Presenter;

    public ListOrderDetailsController(IListOrderDetailsInputPort inputPort, IListOrderDetailsPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;  
    }

    public async ValueTask<IEnumerable<OrderDetailDto>> ListOrderDetails(int orderHeaderId)
    {
        await InputPort.Handle(orderHeaderId);
        return Presenter.OrderDetails;
    }
}
