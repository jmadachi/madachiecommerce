using madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

namespace madachiecommerce.ApplicationBusinessRules;
public class ListingOrderHeadersInteractor: IListingOrderHeadersInputPort
{
    readonly IListingOrderHeadersCommand Repository;
    readonly IListingOrderHeadersOutputPort OutputPort;

    public ListingOrderHeadersInteractor(IListingOrderHeadersCommand repository, IListingOrderHeadersOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var entities = await Repository.ListingOrderHeaders();
        await OutputPort.Handle(entities);
    }

}
