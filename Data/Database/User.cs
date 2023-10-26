using SQLite;

namespace TripApp.Data.Database
{
    public class User
    {
        [PrimaryKey,AutoIncrement ]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
