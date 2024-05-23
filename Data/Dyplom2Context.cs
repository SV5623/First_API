using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public partial class Dyplom2Context : DbContext
{
    public Dyplom2Context()
    {
    }

    public Dyplom2Context(DbContextOptions<Dyplom2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<Mechanic> Mechanics { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<StatusDictionary> StatusDictionaries { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WorkType> WorkTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=Dyplom2;user=s623;password=plop....", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Calendar");

            entity.HasIndex(e => e.ClientId, "client_id");

            entity.HasIndex(e => e.MechanicId, "mechanic_id");

            entity.HasIndex(e => e.StatusId, "status_id");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.BookingDate).HasColumnName("booking_date");
            entity.Property(e => e.BookingTime)
                .HasColumnType("time")
                .HasColumnName("booking_time");
            entity.Property(e => e.ClientId)
                .HasColumnType("int(11)")
                .HasColumnName("client_id");
            entity.Property(e => e.MechanicId)
                .HasColumnType("int(11)")
                .HasColumnName("mechanic_id");
            entity.Property(e => e.StatusId)
                .HasColumnType("int(11)")
                .HasColumnName("status_id");

            entity.HasOne(d => d.Client).WithMany(p => p.Calendars)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("Calendar_ibfk_2");

            entity.HasOne(d => d.Mechanic).WithMany(p => p.Calendars)
                .HasForeignKey(d => d.MechanicId)
                .HasConstraintName("Calendar_ibfk_1");

            entity.HasOne(d => d.Status).WithMany(p => p.Calendars)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("Calendar_ibfk_3");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.UserId, "UserId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");
            entity.Property(e => e.UserId).HasColumnType("int(11)");

            entity.HasOne(d => d.User).WithMany(p => p.Clients)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("Clients_ibfk_1");
        });

        modelBuilder.Entity<Good>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.GoodsDescription)
                .HasMaxLength(500)
                .HasColumnName("goods_description");
            entity.Property(e => e.GoodsName)
                .HasMaxLength(255)
                .HasColumnName("goods_name");
            entity.Property(e => e.GoodsPrice)
                .HasPrecision(9, 2)
                .HasColumnName("goods_price");
        });

        modelBuilder.Entity<Mechanic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.UserId, "UserId");

            entity.HasIndex(e => e.WorkTypeId, "work_type_id");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Hours)
                .HasColumnType("int(11)")
                .HasColumnName("hours");
            entity.Property(e => e.Rating)
                .HasPrecision(3, 2)
                .HasColumnName("rating");
            entity.Property(e => e.Specialization)
                .HasMaxLength(255)
                .HasColumnName("specialization");
            entity.Property(e => e.UserId).HasColumnType("int(11)");
            entity.Property(e => e.WorkTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("work_type_id");

            entity.HasOne(d => d.User).WithMany(p => p.Mechanics)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("Mechanics_ibfk_1");

            entity.HasOne(d => d.WorkType).WithMany(p => p.Mechanics)
                .HasForeignKey(d => d.WorkTypeId)
                .HasConstraintName("Mechanics_ibfk_2");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.MechanicId, "mechanic_id");

            entity.HasIndex(e => e.StatusId, "status_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.MechanicId)
                .HasColumnType("int(11)")
                .HasColumnName("mechanic_id");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.StatusId)
                .HasColumnType("int(11)")
                .HasColumnName("status_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Mechanic).WithMany(p => p.Orders)
                .HasForeignKey(d => d.MechanicId)
                .HasConstraintName("Orders_ibfk_2");

            entity.HasOne(d => d.Status).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("Orders_ibfk_3");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("Orders_ibfk_1");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.PermissionName)
                .HasMaxLength(100)
                .HasColumnName("permission_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .HasColumnName("role_name");

            entity.HasMany(d => d.Permissions).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "RolePermission",
                    r => r.HasOne<Permission>().WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("RolePermissions_ibfk_2"),
                    l => l.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("RolePermissions_ibfk_1"),
                    j =>
                    {
                        j.HasKey("RoleId", "PermissionId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("RolePermissions");
                        j.HasIndex(new[] { "PermissionId" }, "PermissionId");
                        j.IndexerProperty<int>("RoleId").HasColumnType("int(11)");
                        j.IndexerProperty<int>("PermissionId").HasColumnType("int(11)");
                    });
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.GoodsId, "goods_id");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.GoodsId)
                .HasColumnType("int(11)")
                .HasColumnName("goods_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(11)")
                .HasColumnName("quantity");
            entity.Property(e => e.SaleDate).HasColumnName("sale_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Goods).WithMany(p => p.Sales)
                .HasForeignKey(d => d.GoodsId)
                .HasConstraintName("Sales_ibfk_1");

            entity.HasOne(d => d.User).WithMany(p => p.Sales)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("Sales_ibfk_2");
        });

        modelBuilder.Entity<StatusDictionary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Status_dictionary");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.StatusName)
                .HasMaxLength(255)
                .HasColumnName("status_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("UserRoles_ibfk_2"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("UserRoles_ibfk_1"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("UserRoles");
                        j.HasIndex(new[] { "RoleId" }, "RoleId");
                        j.IndexerProperty<int>("UserId").HasColumnType("int(11)");
                        j.IndexerProperty<int>("RoleId").HasColumnType("int(11)");
                    });
        });

        modelBuilder.Entity<WorkType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Work_types");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.WorkTypeName)
                .HasMaxLength(100)
                .HasColumnName("work_type_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
