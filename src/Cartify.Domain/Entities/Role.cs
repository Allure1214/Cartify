using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Cartify.Domain.Entities;

public class Role : IdentityRole<Guid>
{
    [MaxLength(200)]
    public string? Description { get; set; }

    public bool IsSystemRole { get; set; } = false; // System roles cannot be deleted

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
}
