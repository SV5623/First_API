using System;
using System.Collections.Generic;

namespace boba_API.Models;

public partial class WorkType
{
    public int WorkTypeId { get; set; }

    public string WorkTypeName { get; set; } = null!;

    public virtual ICollection<Mechanic> Mechanics { get; set; } = new List<Mechanic>();
}
