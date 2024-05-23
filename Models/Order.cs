using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Order
{
    [Key]
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? MechanicId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public int? StatusId { get; set; }

    public virtual Mechanic? Mechanic { get; set; }

    public virtual StatusDictionary? Status { get; set; }

    public virtual User? User { get; set; }
}
