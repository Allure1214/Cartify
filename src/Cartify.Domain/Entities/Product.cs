using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class Product : BaseEntity
{
    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(1000)]
    public string? Description { get; set; }

    [MaxLength(500)]
    public string? ShortDescription { get; set; }

    [MaxLength(100)]
    public string? SKU { get; set; }

    public decimal Price { get; set; }

    public decimal? CompareAtPrice { get; set; }

    public decimal Cost { get; set; }

    public int StockQuantity { get; set; } = 0;

    public bool TrackInventory { get; set; } = true;

    public bool IsActive { get; set; } = true;

    public bool IsDigital { get; set; } = false;

    public decimal Weight { get; set; } = 0;

    [MaxLength(50)]
    public string? WeightUnit { get; set; } = "kg";

    [MaxLength(200)]
    public string? MetaTitle { get; set; }

    [MaxLength(500)]
    public string? MetaDescription { get; set; }

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }

    public Guid StoreId { get; set; }
    public Store? Store { get; set; }

    public Guid? CategoryId { get; set; }
    public Category? Category { get; set; }

    // Navigation properties
    public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
    public ICollection<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
