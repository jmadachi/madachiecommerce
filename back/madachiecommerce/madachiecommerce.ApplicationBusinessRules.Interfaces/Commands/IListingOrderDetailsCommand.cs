using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
public interface IListingOrderDetailsCommand
{
    ValueTask<IEnumerable<OrderDetailDto>> ListingOrderDetails();
}
