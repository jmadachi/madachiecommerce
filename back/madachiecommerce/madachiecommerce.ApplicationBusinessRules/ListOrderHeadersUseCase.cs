using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.ApplicationBusinessRules;
public class ListOrderHeadersUseCase: IListOrderHeadersInputPort
{
    readonly IListOrderHeadersRepository Repository;
    readonly IListOrderHeadersOutputPort OutputPort;

    public ListOrderHeadersUseCase(IListOrderHeadersRepository repository, IListOrderHeadersOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var entities = await Repository.ListOrderHeaders();
        await OutputPort.Handle(entities);
    }

}
