using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Permission
{
    [Key]
    public int Id { get; set; }

    public string PermissionName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
