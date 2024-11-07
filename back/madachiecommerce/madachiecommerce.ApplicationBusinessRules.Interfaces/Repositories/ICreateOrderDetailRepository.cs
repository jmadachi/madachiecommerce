using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.EnterpriseBusinessRules.Entities;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
public interface ICreateOrderDetailRepository: IUnitOfWork
{
    ValueTask<OrderDetailDto> CreateOrderDetail(OrderDetailEntity orderDetail);
}
