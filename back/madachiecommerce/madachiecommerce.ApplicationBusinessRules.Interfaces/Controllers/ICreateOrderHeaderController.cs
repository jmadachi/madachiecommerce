using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ICreateOrderHeaderController
{
    ValueTask<int> CreateOrderHeader(NewOrderHeaderDto orderHeader);
}
