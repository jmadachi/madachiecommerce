using madachiecommerce.ApplicationBusinessRules.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace madachiecommerce.InterfacesAdapters.Presenters;
public class CreateOrderHeaderPresenter : ICreateOrderHeaderPresenter
{
    public int OrderHeaderId { get; private set; }

    public ValueTask Handle(int orderHeaderId)
    {
        OrderHeaderId = orderHeaderId;
        return ValueTask.CompletedTask;
    }
}
