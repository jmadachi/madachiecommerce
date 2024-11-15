﻿using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.EnterpriseBusinessRules.Entities;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Gateways.Repositories
{
    public class CreateOrderDetailRepository: ICreateOrderDetailRepository
    {
        readonly madachiecommerceContext Context;

        public CreateOrderDetailRepository(madachiecommerceContext context)
        {
            Context = context;
        }   

        public async ValueTask<OrderDetailDto> CreateOrderDetail(OrderDetailEntity orderDetail)
        {
            await Context.AddAsync(orderDetail);
            var orderDetailDto = new OrderDetailDto
            {
                Id = orderDetail.Id,
                OrderHeaderId = orderDetail.OrderHeaderId,
                ProductId = orderDetail.ProductId,
                Amount = orderDetail.Amount,
            };
            return orderDetailDto;
        }


        async ValueTask IUnitOfWork.SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
