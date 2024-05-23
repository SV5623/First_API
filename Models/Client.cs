using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Client
{
    [Key]
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual User? User { get; set; }
}
