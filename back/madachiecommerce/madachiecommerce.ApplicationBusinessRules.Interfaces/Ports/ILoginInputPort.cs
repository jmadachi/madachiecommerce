namespace madachiecommerce.ApplicationBusinessRules.Interfaces;
public interface ILoginInputPort
{
    ValueTask Handle(string name, string password);
}
