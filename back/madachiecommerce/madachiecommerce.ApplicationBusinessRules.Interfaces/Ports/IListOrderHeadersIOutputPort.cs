using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface IListOrderHeadersOutputPort
{
    ValueTask Handle(IEnumerable<OrderHeaderDto> orderHeaders);
}
