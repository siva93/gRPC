namespace User.Infrastructure.Context
{
    using User.Infrastructure.Entity;
    using Microsoft.EntityFrameworkCore;
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<User> Users {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasKey(a => a.Id);
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}