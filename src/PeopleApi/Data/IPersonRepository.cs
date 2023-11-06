namespace PeopleApi.Data
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAllAsync();

        Task<Person>GetPersonAsync(int id);

        Task AddPersonAsync(Person person);
    }
}
