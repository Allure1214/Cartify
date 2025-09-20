using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class Category : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    [MaxLength(200)]
    public string? ImageUrl { get; set; }

    public int SortOrder { get; set; } = 0;

    public bool IsActive { get; set; } = true;

    public Guid? ParentId { get; set; }
    public Category? Parent { get; set; }

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }

    public Guid StoreId { get; set; }
    public Store? Store { get; set; }

    // Navigation properties
    public ICollection<Category> Children { get; set; } = new List<Category>();
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
