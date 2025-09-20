using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class Address : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [MaxLength(200)]
    public string AddressLine1 { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? AddressLine2 { get; set; }

    [Required]
    [MaxLength(100)]
    public string City { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string State { get; set; } = string.Empty;

    [Required]
    [MaxLength(20)]
    public string PostalCode { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Country { get; set; } = string.Empty;

    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    public bool IsDefault { get; set; } = false;

    public AddressType Type { get; set; } = AddressType.Shipping;

    public Guid? CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public Guid? UserId { get; set; }
    public User? User { get; set; }

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }
}

public enum AddressType
{
    Shipping,
    Billing
}
