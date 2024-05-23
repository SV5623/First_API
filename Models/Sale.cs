using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Sale
{
    [Key]
    public int Id { get; set; }

    public int? GoodsId { get; set; }

    public int? UserId { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? SaleDate { get; set; }

    public virtual Good? Goods { get; set; }

    public virtual User? User { get; set; }
}
