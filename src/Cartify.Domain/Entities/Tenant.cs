using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class Tenant : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Identifier { get; set; } = string.Empty; // Subdomain or path identifier

    [MaxLength(200)]
    public string? Description { get; set; }

    [MaxLength(100)]
    public string? LogoUrl { get; set; }

    [MaxLength(7)]
    public string PrimaryColor { get; set; } = "#007bff";

    [MaxLength(7)]
    public string SecondaryColor { get; set; } = "#6c757d";

    public bool IsActive { get; set; } = true;

    public DateTime? SubscriptionExpiresAt { get; set; }

    public Guid SubscriptionPlanId { get; set; }
    public SubscriptionPlan? SubscriptionPlan { get; set; }

    public Guid OwnerId { get; set; }
    public User? Owner { get; set; }

    // Navigation properties
    public ICollection<Store> Stores { get; set; } = new List<Store>();
    public ICollection<User> Users { get; set; } = new List<User>();
    public ICollection<Product> Products { get; set; } = new List<Product>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    public ICollection<Category> Categories { get; set; } = new List<Category>();
}
