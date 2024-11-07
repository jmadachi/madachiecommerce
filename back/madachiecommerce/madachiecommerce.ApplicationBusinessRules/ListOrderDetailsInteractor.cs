using madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

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
        var entities = await Repository.ListingOrderDetails(orderHeaderId);
        await OutputPort.Handle(entities);
    }
}
