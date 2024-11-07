using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface ICreateOrderDetailInputPort
{
    ValueTask Handle(NewOrderDetailDto orderDetail);
}
