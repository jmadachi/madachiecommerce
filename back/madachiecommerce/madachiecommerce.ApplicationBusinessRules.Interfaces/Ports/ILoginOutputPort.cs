using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ILoginOutputPort
{
    ValueTask Handle(UserDto user);
}
