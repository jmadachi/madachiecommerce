namespace madachiecommerce.ApplicationBusinessRules.Dtos
{
    public class OrderHeaderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public DateOnly Date { get; set; }
    }
}
