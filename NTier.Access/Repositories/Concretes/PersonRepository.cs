namespace NTier.Access.Repositories.Concretes
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext _db) : base (_db)
        {

        }
    }
}
