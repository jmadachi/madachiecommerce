﻿using madachiecommerce.ApplicationBusinessRules.Interfaces;

namespace madachiecommerce.ApplicationBusinessRules;
public class ListProductsInteractor: IListProductsInputPort
{
    readonly IListProductsRepository Repository;
    readonly IListProductsOutputPort OutputPort;

    public ListProductsInteractor(IListProductsRepository repository, IListProductsOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        try
        {
            var entities = await Repository.ListProducts();
            await OutputPort.Handle(entities);
        }
        catch (Exception ex) {
            throw ex;
        }
    }

}