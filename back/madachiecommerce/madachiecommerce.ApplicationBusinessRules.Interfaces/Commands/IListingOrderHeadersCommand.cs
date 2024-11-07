﻿using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Commands;
public interface IListingOrderHeadersCommand
{
    ValueTask<IEnumerable<OrderHeaderDto>> ListingOrderHeaders();
}