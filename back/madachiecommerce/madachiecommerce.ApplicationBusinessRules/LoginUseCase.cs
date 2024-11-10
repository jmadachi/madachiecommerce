using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.ApplicationBusinessRules.Tools;

namespace madachiecommerce.ApplicationBusinessRules;
public class LoginUseCase: ILoginInputPort
{
    readonly IGetUserByNameRepository Repository;
    readonly ILoginOutputPort OutputPort;

    public LoginUseCase(IGetUserByNameRepository repository, ILoginOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle(string name, string password)
    {
        var userEntity = await Repository.GetUserByName(name);
        var encriptedPassword = Encripting.getSHA512(password);

        if ((userEntity == null) || (userEntity.Password != encriptedPassword)) 
            await OutputPort.Handle(null);
        else
        {
            var user = new UserDto
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
            };
            await OutputPort.Handle(user);
        }
    }
}
