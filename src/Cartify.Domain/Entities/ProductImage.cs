using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class ProductImage : BaseEntity
{
    [Required]
    [MaxLength(500)]
    public string Url { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? AltText { get; set; }

    public int SortOrder { get; set; } = 0;

    public bool IsPrimary { get; set; } = false;

    public Guid ProductId { get; set; }
    public Product? Product { get; set; }

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }
}
