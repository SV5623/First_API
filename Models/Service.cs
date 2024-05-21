using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Service
{
    [Key]
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public string? ServiceDescription { get; set; }

    public decimal? ServicePrice { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
