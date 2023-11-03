using Microsoft.EntityFrameworkCore;

namespace PeopleApi.Data
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = default;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
