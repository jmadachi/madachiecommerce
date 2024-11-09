using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfacesAdapters.Presenters;
public class LoginPresenter: ILoginPresenter
{
    public UserDto User { get; private set; }

    public ValueTask Handle(UserDto user)
    {
        User = user;    
        return ValueTask.CompletedTask;
    }
}
