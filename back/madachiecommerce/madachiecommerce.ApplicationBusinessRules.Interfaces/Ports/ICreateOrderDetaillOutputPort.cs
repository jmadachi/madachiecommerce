namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ICreateOrderDetailOutputPort
{
    ValueTask Handle(int orderDetailId);
}
