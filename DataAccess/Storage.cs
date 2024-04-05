using Models;
using System.Data;

namespace DataAccess
{
    //Database with multiple storage sets that represent Tables/Collections per type
    public static class Storage
    {
        public static StorageSet<User> Users { get; set; }
        public static StorageSet<Car> Cars { get; set; }
    }
}
