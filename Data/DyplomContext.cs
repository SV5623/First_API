using boba_API.Models;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Data;

public partial class DyplomContext : DbContext
{


    public DyplomContext(DbContextOptions<DyplomContext> options) : base(options)
    {
    }
    

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Mechanic> Mechanics { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<User> users { get; set; }
    public DbSet<WorkType> WorkTypes { get; set; }
    public DbSet<Calendar> Calendar { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Good> Goods { get; set; }
    public DbSet<Statistic> Statistics { get; set; }
}
