namespace User.Infrastructure.Context
{
    using User.Infrastructure.Entity;
    using Microsoft.EntityFrameworkCore;
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<UserProfile> UserProfiles {get;set;}
        public DbSet<UserIdentity> UserIndentities {get;set;}
        public DbSet<UserRole> UserRoles {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<UserIdentity>().HasKey(a => a.UserId);
            modelBuilder.Entity<UserIdentity>().HasIndex(a=>a.UserName).IsUnique();
            modelBuilder.Entity<UserIdentity>().Property(a=>a.UserName).IsRequired().HasMaxLength(8);
            modelBuilder.Entity<UserIdentity>().Property(a=>a.Email).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<UserIdentity>().Property(a=>a.Password).IsRequired().HasMaxLength(16);
            modelBuilder.Entity<UserIdentity>().ToTable("UserIdentity");

            modelBuilder.Entity<UserProfile>().HasKey(a => a.UserId);
            modelBuilder.Entity<UserProfile>().Property(a=>a.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<UserProfile>().Property(a=>a.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<UserProfile>().Property(a=>a.LastName).HasMaxLength(10);
            modelBuilder.Entity<UserProfile>().ToTable("UserProfile");

            modelBuilder.Entity<UserRole>().HasKey(a => a.UserId);
            modelBuilder.Entity<UserRole>().Property(a=>a.Role).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<UserRole>().ToTable("UserRole");
        }
    }
}