using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
public interface IListOrderHeadersRepository
{
    ValueTask<IEnumerable<OrderHeaderDto>> ListingOrderHeaders();
}
