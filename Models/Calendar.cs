using System;
using System.Collections.Generic;

namespace boba_API.Models;

public partial class Calendar
{
    public int CalendarId { get; set; }

    public int? MechanicId { get; set; }

    public int? ClientId { get; set; }

    public DateOnly? BookingDate { get; set; }

    public TimeOnly? BookingTime { get; set; }

    public string? Status { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Mechanic? Mechanic { get; set; }
}
