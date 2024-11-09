using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.EnterpriseBusinessRules.Entities;

namespace madachiecommerce.InterfaceAdapters.Gateways.Repositories
{
    public class GetUserByNameRepository: IGetUserByNameRepository
    {
        readonly madachiecommerceContext Context;

        public GetUserByNameRepository(madachiecommerceContext context)
        {
            Context = context;
        }

        public ValueTask<UserEntity> GetUserByName(string name)
        {
            var user = Context.Users.FirstOrDefault(u => u.Name == name);

            return ValueTask.FromResult(user);
        }

    }
}
