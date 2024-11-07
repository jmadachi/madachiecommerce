using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.EnterpriseBusinessRules.Entities;

namespace madachiecommerce.ApplicationBusinessRules;
public class CreateOrderDetailInteractor: ICreateOrderDetailInputPort
{
    readonly ICreateOrderDetailRepository Repository;
    readonly ICreateOrderDetailOutputPort OutputPort;

    public CreateOrderDetailInteractor(ICreateOrderDetailRepository repository, ICreateOrderDetailOutputPort outputPort) {  
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
