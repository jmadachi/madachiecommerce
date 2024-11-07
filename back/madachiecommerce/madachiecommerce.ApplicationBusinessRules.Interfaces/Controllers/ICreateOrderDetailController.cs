using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ICreateOrderDetailController
{
    ValueTask<int> CreateOrderDetail(NewOrderDetailDto orderHeader);
}
