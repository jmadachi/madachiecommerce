using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Controllers;
public class CreateOrderHeaderController: ICreateOrderHeaderController
{
    readonly ICreateOrderHeaderInputPort InputPort;
    readonly ICreateOrderHeaderPresenter Presenter;

    public CreateOrderHeaderController(ICreateOrderHeaderInputPort inputPort, ICreateOrderHeaderPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;  
    }

    public async ValueTask<int> CreateOrderHeader(NewOrderHeaderDto orderHeader)
    {
        await InputPort.Handle(orderHeader);
        return Presenter.OrderHeaderId;
    }
}
