namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface IListOrderDetailsInputPort
{
    ValueTask Handle(int orderHeaderId);
}
