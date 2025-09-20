using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class Role : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? Description { get; set; }

    public bool IsSystemRole { get; set; } = false; // System roles cannot be deleted

    // Navigation properties
    public ICollection<User> Users { get; set; } = new List<User>();
    public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
}
