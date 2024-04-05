using Models;

namespace DataAccess
{
    public class StorageSet<T> : IStorageSet<T> where T : BaseEntity
    {
        public List<T> Items { get; set; } = new List<T>();

        public void Add(T entity)
        {
            if(entity.Id != 0)
            {
                throw new Exception("For adding new item, the Id needs to be set to 0");
            }

            if(Items.Any())
            {
                int max = Items.Max(x => x.Id);
                entity.Id = max + 1;
            }
            else
            {
                entity.Id = 1;
            }

            Items.Add(entity);
        }

        public void Delete(T entity)
        {
            DeleteById(entity.Id);
        }

        public void DeleteById(int id)
        {
            T item = Items.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException($"Entity with Id = {id} does not exist");
            }

            Items.Remove(item);
        }

        public List<T> GetAll()
        {
            return Items;
        }

        public T GetById(int id)
        {
            T item = Items.FirstOrDefault(x => x.Id == id);

            if(item == null)
            {
                throw new KeyNotFoundException($"Entity with Id = {id} does not exist");
            }

            return item;
        }

        public void Update(T entity)
        {
            T item = Items.FirstOrDefault(x => x.Id == entity.Id);

            if (item == null)
            {
                throw new KeyNotFoundException($"Entity with Id = {entity.Id} does not exist");
            }

            int index = Items.IndexOf(item);
            Items[index] = entity;
        }
    }
}

