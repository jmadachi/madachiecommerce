namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface ICreateOrderDetailOutputPort
{
    ValueTask Handle(int orderDetailId);
}
