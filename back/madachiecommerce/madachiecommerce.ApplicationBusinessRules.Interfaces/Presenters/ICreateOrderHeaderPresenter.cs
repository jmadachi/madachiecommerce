using madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;

namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Presenters;
public interface ICreateOrderHeaderPresenter: ICreateOrderHeaderOutputPort
{
    int OrderHeaderId { get; }
}
