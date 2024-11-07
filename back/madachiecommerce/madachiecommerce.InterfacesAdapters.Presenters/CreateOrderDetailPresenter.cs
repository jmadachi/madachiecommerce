using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfacesAdapters.Presenters;
public class CreateOrderDetailPresenter: ICreateOrderDetailPresenter
{
    public int OrderDetailId { get; private set; }
    public ValueTask Handle(int orderDetailId) 
    { 
        OrderDetailId = orderDetailId;
        return ValueTask.CompletedTask;
    }
}
