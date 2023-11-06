using Microsoft.EntityFrameworkCore;
using PeopleApi.Data;

namespace PeopleApi.Services
{
    public class PersonService : IPersonService
    {
        private  readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        { 
          _personRepository = personRepository;
        }

        public async Task AddPersonAsync(Person person)
        {
            await _personRepository.AddPersonAsync(person);
        }

        public async Task<IEnumerable<Person>> GetAllPerson()
        {
             return  await _personRepository.GetAllAsync();
        }

        public async Task<Person> GetPersonById(int id)
        {
            return await _personRepository.GetPersonAsync(id);
        }
    }
}
