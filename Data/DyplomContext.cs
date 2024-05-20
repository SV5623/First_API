using boba_API.Models;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Data;

public partial class DyplomContext : DbContext
{


    public DyplomContext(DbContextOptions<DyplomContext> options) : base(options)
    {
    }
    

    public virtual DbSet<User> users { get; set; }

}
