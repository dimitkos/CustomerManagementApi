namespace Domain.Aggregates.Customer
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }

#warning move this in shared
    public enum OrderStatus
    {
        Pending,
        Cancelled,
        Delivered
    }
}
