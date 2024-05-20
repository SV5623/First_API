using System;
using System.Collections.Generic;

namespace boba_API.Models;

public partial class Statistic
{
    public int StatId { get; set; }

    public int? UserId { get; set; }

    public string? ActionType { get; set; }

    public DateOnly? ActionDate { get; set; }

    public virtual User? User { get; set; }
}
