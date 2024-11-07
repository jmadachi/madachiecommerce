using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListOrderHeadersRepository
{
    ValueTask<IEnumerable<OrderHeaderDto>> ListOrderHeaders();
}
