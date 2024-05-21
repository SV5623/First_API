using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Order
{
    [Key]
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public int? MechanicId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public string? Status { get; set; }

    public virtual Mechanic? Mechanic { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual User? User { get; set; }
}
