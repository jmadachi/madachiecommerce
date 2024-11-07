namespace madachiecommerce.ApplicationBusinessRules.Dtos
{
    public class OrderDetailDto
    {
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
    }
}
