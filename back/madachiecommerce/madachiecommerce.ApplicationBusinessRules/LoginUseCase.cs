using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

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

        if ((userEntity == null) || (userEntity.Password != password)) 
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
