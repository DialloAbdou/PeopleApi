using Microsoft.EntityFrameworkCore;

namespace PeopleApi.Data
{
    public class PersonDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public PersonDbContext(DbContextOptions<PersonDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Nom = "Diallo", Prenom = "Abdou", DateNaissance = new DateTime(1980, 5, 6) });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 2, Nom = "Bah", Prenom = "Abdoulaye", DateNaissance = new DateTime(1982, 2, 12) });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Nom = "Sow", Prenom = "Zakariaou", DateNaissance = new DateTime(1985, 3, 6) });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Nom = "Mosca", Prenom = "David", DateNaissance = new DateTime(1975, 5, 6) });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Nom = "Gomez", Prenom = "Selena", DateNaissance = new DateTime(1995, 12, 16) });
        }

    }
}
