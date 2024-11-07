using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListOrderHeadersController
{
    ValueTask<IEnumerable<OrderHeaderDto>> ListOrderHeaders();
}
