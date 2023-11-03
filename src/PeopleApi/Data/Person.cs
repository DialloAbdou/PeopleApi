namespace PeopleApi.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string Nom { get; set; }  = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public DateTime DateNaissance { get; set; }

    }
}
