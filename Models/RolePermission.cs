using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class RolePermission
{
    [Key]
    public int PermissionId { get; set; }
    public int RoleId { get; set; }
    public Role? Role { get; set; }
    public Permission? Permission { get; set; }
}
