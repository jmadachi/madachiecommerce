using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.ApplicationBusinessRules;
public class ListProductsUseCase: IListProductsInputPort
{
    readonly IListProductsRepository Repository;
    readonly IListProductsOutputPort OutputPort;

    public ListProductsUseCase(IListProductsRepository repository, IListProductsOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var entities = await Repository.ListProducts();
        await OutputPort.Handle(entities);
    }

}
