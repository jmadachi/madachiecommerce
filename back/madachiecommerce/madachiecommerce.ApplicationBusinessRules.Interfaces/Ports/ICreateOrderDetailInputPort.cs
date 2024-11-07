using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ICreateOrderDetailInputPort
{
    ValueTask Handle(NewOrderDetailDto orderDetail);
}
