using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Role
{
    [Key]
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
