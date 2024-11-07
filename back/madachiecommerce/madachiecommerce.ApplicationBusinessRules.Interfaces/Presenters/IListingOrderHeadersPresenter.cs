using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Presenters;
public interface IListingOrderHeadersPresenter: IListingOrderHeadersOutputPort
{
    IEnumerable<OrderHeaderDto> orderHeaders { get; }
}
