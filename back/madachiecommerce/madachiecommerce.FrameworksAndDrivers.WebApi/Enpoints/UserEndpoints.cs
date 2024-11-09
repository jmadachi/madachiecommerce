using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace madachiecommerce.FrameworksAndDrivers.WebApi.Endpoints;

[ApiController]
[Route("api/users")]
public class UserEndpoints : ControllerBase
{
    private readonly ILoginController LoginController;
    public UserEndpoints(ILoginController loginController) 
    { 
        LoginController = loginController;
    }
    [HttpPost("login")]
    public async ValueTask<ActionResult<UserDto>> Login(LoginDto login)
    {
        var user = await LoginController.Login(login.Name, login.Password);
        if (user == null) return Unauthorized(); else return Ok(user);
    }

}
