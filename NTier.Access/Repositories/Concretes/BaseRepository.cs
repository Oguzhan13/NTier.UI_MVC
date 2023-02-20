namespace NTier.Access.Repositories.Concretes
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseClass
    {
        private readonly AppDbContext _db;
        public BaseRepository(AppDbContext db)
        {
            _db = db;
        }
        public void Create(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
        }
        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().FirstOrDefault(x => x.Id == id);
        }
        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
            _db.SaveChanges();
        }
    }
}
