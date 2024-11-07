using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
public interface ICreateOrderDetailCommand: IUnitOfWork
{
    ValueTask<OrderDetailDto> CreateOrderDetail(NewOrderDetailDto orderDetail);
}
