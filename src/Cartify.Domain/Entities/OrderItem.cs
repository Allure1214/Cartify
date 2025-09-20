using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class OrderItem : BaseEntity
{
    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal TotalPrice { get; set; }

    [MaxLength(200)]
    public string? ProductName { get; set; } // Snapshot of product name at time of order

    [MaxLength(100)]
    public string? ProductSKU { get; set; } // Snapshot of product SKU at time of order

    [MaxLength(500)]
    public string? VariantDescription { get; set; } // e.g., "Red - Large"

    public Guid OrderId { get; set; }
    public Order? Order { get; set; }

    public Guid? ProductId { get; set; }
    public Product? Product { get; set; }

    public Guid? ProductVariantId { get; set; }
    public ProductVariant? ProductVariant { get; set; }

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }
}
