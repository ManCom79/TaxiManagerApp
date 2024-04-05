using Models;

namespace DataAccess
{
    public interface IStorageSet<T> where T : BaseEntity
    {
        //CRUD - Creat, Read, Update, Delete
        void Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
    }
}
