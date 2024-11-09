using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ILoginPresenter: ILoginOutputPort
{
    UserDto User { get; }
}
