namespace NTier.Business.Services.PersonServices
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public void Create(Person person)
        {
            if (person is not null) 
            {
                _personRepository.Create(person);
            }            
        }
        public void Delete(int id)
        {
            Person passivePerson = _personRepository.GetById(id);
            if (passivePerson is not null) 
            {
                passivePerson.DeletedDate = DateTime.Now;
                passivePerson.IsActive = false;
                _personRepository.Update(passivePerson);
            }            
        }
        public List<Person> GetAllPersons()
        {
            return _personRepository.GetAll();
        }
        public Person GetById(int id)
        {
            Person person = _personRepository.GetById(id);
            return person;
        }
        public void Update(Person person)
        {
            Person personUpdate = _personRepository.GetById(person.Id);
            if (personUpdate != null)
            {
                personUpdate.ModifiedDate = DateTime.Now;
                personUpdate.FirstName = person.FirstName;
                personUpdate.LastName = person.LastName;
                personUpdate.IsActive = person.IsActive;
                _personRepository.Update(personUpdate);
            }            
        }
    }
}
