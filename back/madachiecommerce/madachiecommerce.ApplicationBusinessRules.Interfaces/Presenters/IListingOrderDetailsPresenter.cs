using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Presenters;
public interface IListingOrderDetailsPresenter: IListingOrderDetailsOutputPort
{
    IEnumerable<OrderDetailDto> orderDetails { get; }
}
