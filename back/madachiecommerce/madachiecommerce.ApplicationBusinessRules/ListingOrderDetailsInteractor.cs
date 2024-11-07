using madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

namespace madachiecommerce.ApplicationBusinessRules;
public class ListingOrderDetailsInteractor: IListingOrderDetailsInputPort
{
    readonly IListingOrderDetailsCommand Repository;
    readonly IListingOrderDetailsOutputPort OutputPort;

    public ListingOrderDetailsInteractor(IListingOrderDetailsCommand repository, IListingOrderDetailsOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle(int orderHeaderId)
    {
        var entities = await Repository.ListingOrderDetails(orderHeaderId);
        await OutputPort.Handle(entities);
    }
}
