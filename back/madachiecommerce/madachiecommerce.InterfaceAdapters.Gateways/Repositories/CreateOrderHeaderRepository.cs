using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.EnterpriseBusinessRules.Entities;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Gateways.Repositories
{
    public class CreateOrderHeaderRepository: ICreateOrderHeaderRepository
    {
        readonly madachiecommerceContext Context;

        public CreateOrderHeaderRepository(madachiecommerceContext context)
        {
            Context = context;
        }   

        public async ValueTask<OrderHeaderDto> CreateOrderHeader(OrderHeaderEntity orderHeader)
        {
            await Context.AddAsync(orderHeader);
            var orderHeaderDto = new OrderHeaderDto
            {
                Id = orderHeader.Id,
                CustomerId = orderHeader.CustomerId,
                OrderNumber = orderHeader.OrderNumber,
                Date = orderHeader.Date,
            };
            return orderHeaderDto;
        }


        async ValueTask IUnitOfWork.SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
