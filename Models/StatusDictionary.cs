using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class StatusDictionary
{
    [Key]
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
