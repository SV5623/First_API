using System;
using System.Collections.Generic;

namespace boba_API.Models;

public partial class Sale
{
    public int SaleId { get; set; }

    public int? GoodsId { get; set; }

    public int? UserId { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? SaleDate { get; set; }

    public virtual Good? Goods { get; set; }

    public virtual User? User { get; set; }
}
