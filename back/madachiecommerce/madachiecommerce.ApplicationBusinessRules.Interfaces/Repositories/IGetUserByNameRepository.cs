using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.EnterpriseBusinessRules.Entities;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IGetUserByNameRepository
{
    ValueTask<UserEntity> GetUserByName(string name);
}
