using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Presenters;

namespace madachiecommerce.InterfaceAdapters.Controllers;
public class CreateOrderDetailController: ICreateOrderDetailController
{
    readonly ICreateOrderDetailInputPort InputPort;
    readonly ICreateOrderDetailPresenter Presenter;

    public CreateOrderDetailController(ICreateOrderDetailInputPort inputPort, ICreateOrderDetailPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;  
    }

    public async ValueTask<int> CreateOrderDetail(NewOrderDetailDto orderDetail)
    {
        await InputPort.Handle(orderDetail);
        return Presenter.OrderDetailId;
    }
}
