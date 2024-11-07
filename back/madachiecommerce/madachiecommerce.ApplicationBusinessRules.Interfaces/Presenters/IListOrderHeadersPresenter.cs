using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListOrderHeadersPresenter: IListOrderHeadersOutputPort
{
    IEnumerable<OrderHeaderDto> OrderHeaders { get; }
}
