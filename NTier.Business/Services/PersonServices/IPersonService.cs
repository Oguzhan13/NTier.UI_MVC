namespace NTier.Business.Services.PersonServices
{
    public interface IPersonService
    {
        void Create(Person person);
        void Delete(int id);
        void Update(Person person);
        Person GetById(int id);
        List<Person> GetAllPersons();
    }
}