using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IGetUserByNameOutputPort
{
    ValueTask Handle(UserDto user);
}
