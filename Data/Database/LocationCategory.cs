using SQLite;
using System.ComponentModel.DataAnnotations;

namespace TripApp.Data.Database
{
    public class LocationCategory
    {
        [PrimaryKey]
        public string Name { get; set; }

        public string Image { get; set; }

        public LocationCategory(string name, string image)
        {
            Name = name;
            Image = image;
        }

        public LocationCategory()
        {
            
        }
    }
}
