using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Controllers;
public class LoginController: ILoginController
{
    readonly ILoginInputPort InputPort;
    readonly ILoginPresenter Presenter;

    public LoginController(ILoginInputPort inputPort, ILoginPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;  
    }

    public async ValueTask<UserDto> Login(string name, string password)
    {
        await InputPort.Handle(name, password);
        return Presenter.User;
    }
}
