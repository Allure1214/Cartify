using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class ProductVariantOption : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string OptionName { get; set; } = string.Empty; // e.g., "Color", "Size"

    [Required]
    [MaxLength(100)]
    public string OptionValue { get; set; } = string.Empty; // e.g., "Red", "Large"

    public Guid ProductVariantId { get; set; }
    public ProductVariant? ProductVariant { get; set; }

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }
}
