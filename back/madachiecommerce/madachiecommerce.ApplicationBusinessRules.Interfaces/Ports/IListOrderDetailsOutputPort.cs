using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface IListOrderDetailsOutputPort
{
    ValueTask Handle(IEnumerable<OrderDetailDto> orderDetails);
}
