using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.ApplicationBusinessRules;
public class LoginInteractor: ILoginInputPort
{
    readonly IGetUserByNameRepository Repository;
    readonly IGetUserByNameOutputPort OutputPort;

    public LoginInteractor(IGetUserByNameRepository repository, IGetUserByNameOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle(string name, string password)
    {
        var userEntity = await Repository.GetUserByName(name);
        var user = new UserDto
        {
            Id = userEntity.Id,
            Name  = userEntity.Name,
        };
        await OutputPort.Handle(user);
    }
}
