using Microsoft.EntityFrameworkCore;
using PeopleApi.Data;

namespace PeopleApi.Services
{
    public class PersonService
    {
        private  readonly PersonDbContext _context;
        public PersonService(PersonDbContext context)
        { 
            _context = context;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _context.Persons.ToListAsync(); ;    
        }
    }
}
