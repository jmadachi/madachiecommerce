using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListOrderHeadersOutputPort
{
    ValueTask Handle(IEnumerable<OrderHeaderDto> orderHeaders);
}
