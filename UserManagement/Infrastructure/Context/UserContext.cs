namespace User.Infrastructure.Context
{
    using User.Infrastructure.Entity;
    using Microsoft.EntityFrameworkCore;
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<UserProfile> UserProfiles {get;set;}
        public DbSet<UserIdentity> UserIndentities {get;set;}
        public DbSet<UserRole> UserRoles {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<UserIdentity>().HasKey(a => a.UserId);
            modelBuilder.Entity<UserIdentity>().ToTable("UserIdentity");

            modelBuilder.Entity<UserProfile>().HasKey(a => a.UserId);
            modelBuilder.Entity<UserProfile>().ToTable("UserProfile");

            modelBuilder.Entity<UserRole>().HasKey(a => a.UserId);
            modelBuilder.Entity<UserRole>().ToTable("UserRole");
        }
    }
}