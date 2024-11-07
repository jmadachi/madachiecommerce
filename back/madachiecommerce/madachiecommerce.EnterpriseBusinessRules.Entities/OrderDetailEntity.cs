namespace madachiecommerce.EnterpriseBusinessRules.Entities;
public class OrderDetailEntity
{
    public int Id { get; set; }
    public int OrderHeaderId { get; set; }
    public int ProductId { get; set; } 
    public int Amount { get; set; }
}

