using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListOrderDetailsRepository
{
    ValueTask<IEnumerable<OrderDetailDto>> ListOrderDetails(int orderHeaderId);
}
