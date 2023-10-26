using SQLite;

namespace TripApp.Data.Database
{
    public class ExpenseCategory
    {
        [PrimaryKey,System.ComponentModel.DataAnnotations.MaxLength(100)]
        public string Name { get; set; }

        public ExpenseCategory(string name)
        {
            Name = name;
        }

        public ExpenseCategory()
        {
            
        }
    }
}
