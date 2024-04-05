namespace Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public BaseEntity(int id = 0)
        {
            Id = id;
        }
    }
}
