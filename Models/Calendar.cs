using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public class Calendar 
{
    [Key]
    public Guid? Id { get; set; } = null!;
    // FK
    public Guid? MechanikId { get; set; } = null!;
    public Guid? ClientId { get; set; } = null!;
    public Guid? StatusId { get; set; } = null!;

    public DateTime BookingDate { get; set; }
    
    public required Mechanik Mechanik { get; set;}
    public required Client Client { get; set;}
    public required Status Status { get; set;}
} 