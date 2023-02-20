namespace NTier.Access.Repositories.Abstracts
{
    public interface IBaseRepository<T>
    {
        T GetById(int id);        
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
