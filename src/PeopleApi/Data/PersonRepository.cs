using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace PeopleApi.Data
{
    public class PersonRepository : IPersonRepository
    {
        private  PersonDbContext _context;
        public PersonRepository(PersonDbContext context)
        {
            _context = context;
        }

        public async Task AddPersonAsync(Person person)
        {
            await _context.AddAsync(person);
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _context.Persons.ToListAsync();
        }

        public async Task<Person?> GetPersonAsync(int id)
        {
          return await _context.Persons.SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
