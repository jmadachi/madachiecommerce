using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfacesAdapters.Presenters;
public class ListOrderHeadersPresenter: IListOrderHeadersPresenter
{
    public IEnumerable<OrderHeaderDto> OrderHeaders { get; private set; }

    public ValueTask Handle(IEnumerable<OrderHeaderDto> orderHeaders)
    {
        OrderHeaders = orderHeaders;    
        return ValueTask.CompletedTask;
    }
}
