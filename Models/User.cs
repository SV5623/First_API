﻿using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public partial class User
{
    [Key]
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Mechanic> Mechanics { get; set; } = new List<Mechanic>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
