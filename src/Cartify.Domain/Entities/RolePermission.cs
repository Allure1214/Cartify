using System.ComponentModel.DataAnnotations;

namespace Cartify.Domain.Entities;

public class RolePermission : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Permission { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? Description { get; set; }

    public Guid RoleId { get; set; }
    public Role? Role { get; set; }
}
