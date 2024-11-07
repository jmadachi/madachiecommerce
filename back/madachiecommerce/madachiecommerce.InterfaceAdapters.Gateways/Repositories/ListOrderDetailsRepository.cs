using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.EnterpriseBusinessRules.Entities;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Gateways.Repositories
{
    public class ListOrderDetailsRepository: IListOrderDetailsRepository
    {
        readonly madachiecommerceContext Context;

        public ListOrderDetailsRepository(madachiecommerceContext context)
        {
            Context = context;
        }   

        public ValueTask<IEnumerable<OrderDetailDto>> ListOrderDetails(int orderHeaderId)
        {
            var list = Context.OrderDetails
                .Where(orderDetail => orderDetail.OrderHeaderId == orderHeaderId) // Filtra si es necesario
                .Select(orderDetail => new OrderDetailDto
                {
                    Id = orderDetail.Id,
                    OrderHeaderId = orderDetail.OrderHeaderId,
                    ProductId = orderDetail.ProductId,
                    Amount = orderDetail.Amount
                });

            return ValueTask.FromResult(list.AsEnumerable());
        }

    }
}
