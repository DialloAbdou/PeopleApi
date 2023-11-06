using PeopleApi.Data;

namespace PeopleApi.Services
{
    public interface IPersonService
    {
         Task<IEnumerable<Person>> GetAllPerson();
         Task<Person> GetPersonById(int id);
        Task AddPersonAsync(Person person);

    }
}
