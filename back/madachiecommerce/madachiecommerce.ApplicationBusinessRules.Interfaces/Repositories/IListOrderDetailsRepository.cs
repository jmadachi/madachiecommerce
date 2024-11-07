using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
public interface IListOrderDetailsRepository
{
    ValueTask<IEnumerable<OrderDetailDto>> ListingOrderDetails(int orderHeaderId);
}
