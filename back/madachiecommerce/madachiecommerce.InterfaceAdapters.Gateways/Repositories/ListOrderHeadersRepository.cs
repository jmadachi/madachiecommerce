using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.EnterpriseBusinessRules.Entities;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Gateways.Repositories
{
    public class ListOrderHeadersRepository: IListOrderHeadersRepository
    {
        readonly madachiecommerceContext Context;

        public ListOrderHeadersRepository(madachiecommerceContext context)
        {
            Context = context;
        }   

        public ValueTask<IEnumerable<OrderHeaderDto>> ListOrderHeaders()
        {
            var list = Context.OrderHeaders
                .Select(orderHeader => new OrderHeaderDto
                {
                    Id = orderHeader.Id,
                    CustomerId = orderHeader.CustomerId,
                    OrderNumber = orderHeader.OrderNumber,
                    Date = orderHeader.Date
                });

            return ValueTask.FromResult(list.AsEnumerable());
        }

    }
}
