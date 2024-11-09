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
    [HttpPost]
    public async ValueTask<ActionResult<UserDto>> Login(string name, string password)
    {
        var user = await LoginController.Login(name, password);
        if (user == null) return NotFound(); else return Ok(user);
    }

}
