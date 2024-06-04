using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public class Client 
{
    [Key]
    public Guid? Id { get; set; } = null!;
    
    // foreign keys
    public Guid? UserId { get; set; } = null!;
    
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string phone_number { get; set; }

    public AspNetUser User { get; set; }
}