using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface ICreateOrderHeaderInputPort
{
    ValueTask Handle(NewOrderHeaderDto orderHeader);
}
