using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListOrderDetailsOutputPort
{
    ValueTask Handle(IEnumerable<OrderDetailDto> orderDetails);
}
