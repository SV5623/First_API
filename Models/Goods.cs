using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public class Goods 
{
    [Key]
    public Guid? Id { get; set; } = null!;
    
    public string name { get; set;}
    public string description { get; set;}
    public int price { get; set;}

}