using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Good
{
    [Key]
    public int Id { get; set; }

    public string GoodsName { get; set; } = null!;

    public string? GoodsDescription { get; set; }

    public decimal? GoodsPrice { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
