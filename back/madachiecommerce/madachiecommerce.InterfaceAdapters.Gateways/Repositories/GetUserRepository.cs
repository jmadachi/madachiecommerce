using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.EnterpriseBusinessRules.Entities;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Gateways.Repositories
{
    public class GetUserByNameRepository: IGetUserByNameRepository
    {
        readonly madachiecommerceContext Context;

        public GetUserByNameRepository(madachiecommerceContext context)
        {
            Context = context;
        }

        public ValueTask<UserDto> GetUserByName(string name)
        {
            var user = Context.Users
                .Where(u => u.Name == name)
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Name = u.Name,
                }).FirstOrDefault();

            return ValueTask.FromResult(user);
        }

    }
}
