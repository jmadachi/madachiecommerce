using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IGetUserByNamePresenter: IGetUserByNameOutputPort
{
    UserDto User { get; }
}
