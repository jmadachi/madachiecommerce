using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ICreateOrderHeaderInputPort
{
    ValueTask Handle(NewOrderHeaderDto orderHeader);
}
