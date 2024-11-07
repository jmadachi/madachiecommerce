using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListOrderDetailsController
{
    ValueTask<IEnumerable<OrderDetailDto>> ListOrderDetails(int orderHeaderId);
}
