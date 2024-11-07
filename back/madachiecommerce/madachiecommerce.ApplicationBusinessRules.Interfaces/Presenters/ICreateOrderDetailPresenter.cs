using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Presenters;
public interface ICreateOrderDetailPresenter: ICreateOrderDetailOutputPort
{
    int OrderDetailId { get; }
}
