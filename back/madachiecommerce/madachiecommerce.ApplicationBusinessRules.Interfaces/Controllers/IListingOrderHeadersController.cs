using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListingOrderHeadersController
{
    ValueTask<IEnumerable<OrderHeaderDto>> ListingOrderHeaders();
}
