using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Presenters;
public interface IListOrderDetailsPresenter: IListOrderDetailsOutputPort
{
    IEnumerable<OrderDetailDto> orderDetails { get; }
}
