using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class User : BaseEntity
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

    [Required]
    [MaxLength(256)]
    public string PasswordHash { get; set; } = string.Empty;

    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    public bool IsEmailConfirmed { get; set; } = false;

    public bool IsActive { get; set; } = true;

    public DateTime? LastLoginAt { get; set; }

    public Guid? TenantId { get; set; }
    public Tenant? Tenant { get; set; }

    public Guid RoleId { get; set; }
    public Role? Role { get; set; }

    // Navigation properties
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Address> Addresses { get; set; } = new List<Address>();
}
