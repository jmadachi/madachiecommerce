namespace madachiecommerce.ApplicationBusinessRules.Dtos
{
    public class NewOrderHeaderDto
    {
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public DateOnly Date { get; set; }
    }
}
