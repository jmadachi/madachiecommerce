using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.EnterpriseBusinessRules.Entities;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
public interface ICreateOrderHeaderCommand: IUnitOfWork
{
    ValueTask<OrderHeaderDto> CreateOrderHeader(OrderHeaderEntity orderHeader);
}
