using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class WorkType
{
    [Key]
    public int Id { get; set; }

    public string WorkTypeName { get; set; } = null!;

    public virtual ICollection<Mechanic> Mechanics { get; set; } = new List<Mechanic>();
}
