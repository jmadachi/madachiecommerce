namespace madachiecommerce.EnterpriseBusinessRules.Interfaces;
public interface IUnitOfWork
{
    ValueTask SaveChanges();
}
