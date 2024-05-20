using System;
using System.Collections.Generic;

namespace boba_API.Models;

public partial class Good
{
    public int GoodsId { get; set; }

    public string GoodsName { get; set; } = null!;

    public string? GoodsDescription { get; set; }

    public decimal? GoodsPrice { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
