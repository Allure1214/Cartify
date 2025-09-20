using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class SubscriptionPlan : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    public decimal Price { get; set; }

    [MaxLength(10)]
    public string Currency { get; set; } = "USD";

    [MaxLength(20)]
    public string BillingCycle { get; set; } = "monthly"; // monthly, yearly

    public int MaxProducts { get; set; } = 100;

    public int MaxUsers { get; set; } = 5;

    public long MaxStorageBytes { get; set; } = 1024 * 1024 * 1024; // 1GB

    public bool HasAdvancedAnalytics { get; set; } = false;

    public bool HasApiAccess { get; set; } = false;

    public bool HasCustomThemes { get; set; } = false;

    public bool HasPrioritySupport { get; set; } = false;

    public bool IsActive { get; set; } = true;

    // Navigation properties
    public ICollection<Tenant> Tenants { get; set; } = new List<Tenant>();
}
