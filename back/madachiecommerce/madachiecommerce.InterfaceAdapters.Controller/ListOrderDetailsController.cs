using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Presenters;

namespace madachiecommerce.InterfaceAdapters.Controllers;
public class ListOrderDetailController: IListOrderDetailsController
{
    readonly IListOrderDetailsInputPort InputPort;
    readonly IListOrderDetailsPresenter Presenter;

    public ListOrderDetailController(IListOrderDetailsInputPort inputPort, IListOrderDetailsPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;  
    }

    public async ValueTask<IEnumerable<OrderDetailDto>> ListOrderDetails(int orderHeaderId)
    {
        await InputPort.Handle(orderHeaderId);
        return Presenter.orderDetails;
    }
}
