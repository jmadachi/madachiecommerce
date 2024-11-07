using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.ApplicationBusinessRules;
public class ListOrderDetailsInteractor: IListOrderDetailsInputPort
{
    readonly IListOrderDetailsRepository Repository;
    readonly IListOrderDetailsOutputPort OutputPort;

    public ListOrderDetailsInteractor(IListOrderDetailsRepository repository, IListOrderDetailsOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle(int orderHeaderId)
    {
        var entities = await Repository.ListOrderDetails(orderHeaderId);
        await OutputPort.Handle(entities);
    }
}
