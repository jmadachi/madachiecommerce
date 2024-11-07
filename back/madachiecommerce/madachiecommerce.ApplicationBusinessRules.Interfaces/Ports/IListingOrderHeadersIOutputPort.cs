using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface IListingOrderHeadersOutputPort
{
    ValueTask Handle(IEnumerable<OrderHeaderDto> orderHeaders);
}
