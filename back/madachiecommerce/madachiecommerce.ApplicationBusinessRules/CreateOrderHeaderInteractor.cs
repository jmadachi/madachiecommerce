﻿using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
using madachiecommerce.EnterpriseBusinessRules.Entities;

namespace madachiecommerce.ApplicationBusinessRules;
public class CreateOrderHeaderInteractor: ICreateOrderHeaderInputPort
{
    readonly ICreateOrderHeaderCommand Repository;
    readonly ICreateOrderHeaderOutputPort OutputPort;

    public CreateOrderHeaderInteractor(ICreateOrderHeaderCommand repository, ICreateOrderHeaderOutputPort outputPort) {  
        Repository = repository; 
        OutputPort = outputPort;
    }

    public async ValueTask Handle(NewOrderHeaderDto orderHeader)
    {
        var entity = new OrderHeaderEntity
        {
            CustomerId = orderHeader.CustomerId,
            OrderNumber  = orderHeader.OrderNumber,
            Date = orderHeader.Date
        };
        await Repository.CreateOrderHeader(entity);
        await Repository.SaveChanges();
        await OutputPort.Handle(entity.Id);
    }
}