using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public class Sales 
{
    [Key]
    public Guid? Id { get; set; } = null!;

    public Guid? GoodsId { get; set; } = null!;
    
    public int quiantity { get; set;}
    public DateTime sale_date { get; set;}

    public Goods Goods { get; set;}
}