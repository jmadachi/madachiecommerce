namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface IGetUserByNameInputPort
{
    ValueTask Handle(string name);
}
