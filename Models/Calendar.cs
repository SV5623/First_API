using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Calendar
{
    [Key]
    public int Id { get; set; }

    public int? MechanicId { get; set; }

    public int? ClientId { get; set; }

    public DateOnly? BookingDate { get; set; }

    public TimeOnly? BookingTime { get; set; }

    public int? StatusId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Mechanic? Mechanic { get; set; }

    public virtual StatusDictionary? Status { get; set; }
}
