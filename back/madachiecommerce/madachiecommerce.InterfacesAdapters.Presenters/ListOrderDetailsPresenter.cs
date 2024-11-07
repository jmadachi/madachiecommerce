using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfacesAdapters.Presenters;
public class ListOrderDetailsPresenter: IListOrderDetailsPresenter
{
    public IEnumerable<OrderDetailDto> OrderDetails { get; private set; }

    public ValueTask Handle(IEnumerable<OrderDetailDto> orderDetails)
    {
        OrderDetails = orderDetails;    
        return ValueTask.CompletedTask;
    }
}
