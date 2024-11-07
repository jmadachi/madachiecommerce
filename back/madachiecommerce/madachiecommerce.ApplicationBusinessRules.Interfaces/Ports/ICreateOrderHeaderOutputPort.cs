using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ICreateOrderHeaderOutputPort
{
    ValueTask Handle(int orderHeaderId);
}
