namespace madachiecommerce.ApplicationBusinessRules.Interfaces.Ports;
public interface IListingOrderDetailsInputPort
{
    ValueTask Handle(int orderHeaderId);
}
