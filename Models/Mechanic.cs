using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Mechanic
{
    [Key]
    public int MechanicId { get; set; }

    public int? UserId { get; set; }

    public string? Specialization { get; set; }

    public decimal? Rating { get; set; }

    public decimal? Hours { get; set; }

    public int? WorkTypeId { get; set; }

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual User? User { get; set; }

    public virtual WorkType? WorkType { get; set; }
}
