using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Presenters;
public interface IListOrderHeadersPresenter: IListingOrderHeadersOutputPort
{
    IEnumerable<OrderHeaderDto> orderHeaders { get; }
}
