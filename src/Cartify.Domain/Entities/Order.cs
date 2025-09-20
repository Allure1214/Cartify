using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class Order : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string OrderNumber { get; set; } = string.Empty;

    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    public decimal Subtotal { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal ShippingAmount { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal Total { get; set; }

    [MaxLength(3)]
    public string Currency { get; set; } = "USD";

    [MaxLength(50)]
    public string? PaymentMethod { get; set; }

    [MaxLength(100)]
    public string? PaymentTransactionId { get; set; }

    public DateTime? PaidAt { get; set; }

    public DateTime? ShippedAt { get; set; }

    public DateTime? DeliveredAt { get; set; }

    [MaxLength(100)]
    public string? TrackingNumber { get; set; }

    [MaxLength(500)]
    public string? Notes { get; set; }

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }

    public Guid StoreId { get; set; }
    public Store? Store { get; set; }

    public Guid? CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public Guid? UserId { get; set; }
    public User? User { get; set; }

    // Navigation properties
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public ICollection<OrderStatusHistory> StatusHistory { get; set; } = new List<OrderStatusHistory>();
}

public enum OrderStatus
{
    Pending,
    Processing,
    Paid,
    Shipped,
    Delivered,
    Cancelled,
    Refunded
}
