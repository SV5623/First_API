using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public class Mechanik 
{
    [Key]
    public Guid? Id { get; set; } = null!;

//FK
    public Guid? UserId { get; set; } = null!;
    public Guid? TypeId { get; set; } = null!;

    public int hours { get; set; }
    public decimal Rating { get; set; }

    public AspNetUser User { get; set; }
    public WorkType Type { get; set; }
}