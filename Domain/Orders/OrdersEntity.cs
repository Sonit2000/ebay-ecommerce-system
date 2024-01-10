namespace Domain.Orders;
public class OrdersEntity : Common
{
    public Guid OrderId { get; set; }
    public Guid BuyId { get; set; }
    public Guid SellerId { get; set; }
    public required Timer OrderDate { get; set; }
    public long TotalPrice { get; set; }
    public required string PaymentMethod { get; set; }
    public required string ShippingAddress { get; set; }
    public required string ShippingStatus { get; set; }
}