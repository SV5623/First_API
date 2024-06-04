using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public class Order 
{
    [Key]
    public Guid? Id { get; set; } = null! ;
    
    public Guid? ClientId { get; set; }
    public Guid? MechanicId { get; set; }
    public Guid? StatusId { get; set; }
    
    public DateTime OrderDate { get; set; }  
    
    public required Client Client { get; set; }
    public required Mechanik Mechanik { get; set; }
    public required Status Status { get; set; }
}