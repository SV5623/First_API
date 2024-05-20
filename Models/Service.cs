using System;
using System.Collections.Generic;

namespace boba_API.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public string? ServiceDescription { get; set; }

    public decimal? ServicePrice { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
