using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class Admin
{
    [Key]
    public int AdminId { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
