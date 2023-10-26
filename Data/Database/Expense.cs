using SQLite;
using System.ComponentModel.DataAnnotations;

namespace TripApp.Data.Database
{
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public int TripId { get; set; }

        [Required, System.ComponentModel.DataAnnotations.MaxLength(100)]
        public string For { get; set; }

        [Range(0.1,double.MaxValue)]
        public double Amount { get; set; }

        [Required]
        public string Category { get; set; }
        public DateTime? SpentOn { get; set; }
    }
}
