using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface ICreateOrderHeaderOutputPort
{
    ValueTask Handle(int orderHeaderId);
}
