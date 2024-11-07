using madachiecommerce.ApplicationBusinessRules.Dtos;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListOrderDetailsPresenter: IListOrderDetailsOutputPort
{
    IEnumerable<OrderDetailDto> OrderDetails { get; }
}
