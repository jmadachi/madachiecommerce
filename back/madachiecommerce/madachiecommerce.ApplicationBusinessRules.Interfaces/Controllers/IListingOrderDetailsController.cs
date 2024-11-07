using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListingOrderDetailsController
{
    ValueTask<IEnumerable<OrderDetailDto>> ListingOrderDetails(int orderHeaderId);
}
