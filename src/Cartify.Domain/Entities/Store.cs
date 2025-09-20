using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class Store : BaseEntity
{
    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    [MaxLength(200)]
    public string? LogoUrl { get; set; }

    [MaxLength(7)]
    public string PrimaryColor { get; set; } = "#007bff";

    [MaxLength(7)]
    public string SecondaryColor { get; set; } = "#6c757d";

    [MaxLength(200)]
    public string? Domain { get; set; } // Custom domain

    [MaxLength(200)]
    public string? Subdomain { get; set; } // Auto-generated subdomain

    public bool IsActive { get; set; } = true;

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }

    // Navigation properties
    public ICollection<Product> Products { get; set; } = new List<Product>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Category> Categories { get; set; } = new List<Category>();
}
