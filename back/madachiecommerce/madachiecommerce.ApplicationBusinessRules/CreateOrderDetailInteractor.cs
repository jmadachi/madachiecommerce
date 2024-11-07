using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
using madachiecommerce.EnterpriseBusinessRules.Entities;

namespace madachiecommerce.ApplicationBusinessRules;
public class CreateOrderDetailInteractor: ICreateOrderDetailInputPort
{
    readonly ICreateOrderDetailCommand Repository;
    readonly ICreateOrderDetailOutputPort OutputPort;

    public CreateOrderDetailInteractor(ICreateOrderDetailCommand repository, ICreateOrderDetailOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle(NewOrderDetailDto orderDetail)
    {
        var entity = new OrderDetailEntity
        {
            OrderHeaderId = orderDetail.OrderHeaderId,
            ProductId  = orderDetail.ProductId,
            Amount = orderDetail.Amount
        };
        await Repository.CreateOrderDetail(entity);
        await Repository.SaveChanges();
        await OutputPort.Handle(entity.Id);
    }
}
