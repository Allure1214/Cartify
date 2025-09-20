using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class ProductVariant : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty; // e.g., "Red", "Large", "Red - Large"

    [MaxLength(100)]
    public string? SKU { get; set; }

    public decimal Price { get; set; }

    public decimal? CompareAtPrice { get; set; }

    public int StockQuantity { get; set; } = 0;

    public bool TrackInventory { get; set; } = true;

    public bool IsActive { get; set; } = true;

    public decimal Weight { get; set; } = 0;

    [MaxLength(50)]
    public string? WeightUnit { get; set; } = "kg";

    public Guid ProductId { get; set; }
    public Product? Product { get; set; }

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }

    // Navigation properties
    public ICollection<ProductVariantOption> Options { get; set; } = new List<ProductVariantOption>();
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
