namespace BusinessLayer.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CreatedByUserId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public int? DiscountId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal PriceApplied { get; set; }
    }
}
