using System;
using System.Collections.Generic;

namespace boba_API.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual User? User { get; set; }
}
