using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ILoginController
{
    ValueTask<UserDto> Login(string name, string password);
}
