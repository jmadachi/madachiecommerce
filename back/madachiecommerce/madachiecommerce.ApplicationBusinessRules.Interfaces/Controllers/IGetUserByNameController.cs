using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IGetUserByNameController
{
    ValueTask<UserDto> GetUserByName(string name);
}
