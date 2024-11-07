using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface IListingOrderDetailsOutputPort
{
    ValueTask Handle(IEnumerable<OrderDetailDto> orderDetails);
}
