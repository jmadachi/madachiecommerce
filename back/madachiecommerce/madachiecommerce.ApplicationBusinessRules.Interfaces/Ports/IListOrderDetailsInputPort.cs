namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IListOrderDetailsInputPort
{
    ValueTask Handle(int orderHeaderId);
}
