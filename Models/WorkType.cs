using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public class WorkType 
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }    
}