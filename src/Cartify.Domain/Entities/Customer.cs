using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class Customer : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [MaxLength(256)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime? LastOrderAt { get; set; }

    public decimal TotalSpent { get; set; } = 0;

    public int TotalOrders { get; set; } = 0;

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }

    // Navigation properties
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Address> Addresses { get; set; } = new List<Address>();
}
