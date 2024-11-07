using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.EnterpriseBusinessRules.Entities;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ICreateOrderDetailRepository: IUnitOfWork
{
    ValueTask<OrderDetailDto> CreateOrderDetail(OrderDetailEntity orderDetail);
}
