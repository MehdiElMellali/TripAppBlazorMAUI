using SQLite;
using System.ComponentModel.DataAnnotations;

namespace TripApp.Data.Database
{
    public class Trip
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        [Required, System.ComponentModel.DataAnnotations.MaxLength(30)]
        public string Title { get; set; }

        [Required, System.ComponentModel.DataAnnotations.MaxLength(50)]
        public string Location { get; set; }

        [Required, System.ComponentModel.DataAnnotations.MaxLength(30)]
        public string CategoryImage { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime AddOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public TripStatus Status { get; set; } = TripStatus.Planned;
    }
}
