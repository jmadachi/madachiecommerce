using madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

namespace madachiecommerce.ApplicationBusinessRules;
public class ListingOrderHeadersInteractor: IListOrderHeadersInputPort
{
    readonly IListOrderHeadersRepository Repository;
    readonly IListOrderHeadersOutputPort OutputPort;

    public ListingOrderHeadersInteractor(IListOrderHeadersRepository repository, IListOrderHeadersOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var entities = await Repository.ListOrderHeaders();
        await OutputPort.Handle(entities);
    }

}
