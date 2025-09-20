using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class OrderStatusHistory : BaseEntity
{
    public OrderStatus Status { get; set; }

    [MaxLength(500)]
    public string? Notes { get; set; }

    public DateTime StatusDate { get; set; } = DateTime.UtcNow;

    public Guid OrderId { get; set; }
    public Order? Order { get; set; }

    public Guid? UserId { get; set; }
    public User? User { get; set; }

    public Guid TenantId { get; set; }
    public Tenant? Tenant { get; set; }
}
