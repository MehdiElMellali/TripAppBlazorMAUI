using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripApp.Data.Database;

namespace TripApp.Services
{
    public class SeedDataService
    {
        private readonly DatabaseContext _context;

        public SeedDataService(DatabaseContext context)
        {
           _context = context;
        }

        public async Task SeedDataAsync()
        {
            var foodCategory = await _context.FindAsync<ExpenseCategory>("Food");
            if (foodCategory is not null)
                return;

            var expenseCategories = new List<ExpenseCategory>()
            {
                new("Food"),new("Fuel"),new("Entertainment"),new("Shopping"),new("Others")
            };

            var locationCategories = new List<LocationCategory>()
            {
                new LocationCategory("Beach","/images/vacations.png"),
                new LocationCategory("City","/images/architecture-and-city.png"),
                new LocationCategory("Forest","/images/forest.png"),
                new LocationCategory("Island","/images/island.png"),
                new LocationCategory("Mountain","/images/mountain.png"),
                new LocationCategory("Praying","/images/praying.png"),
                new LocationCategory("Other","/images/destination.png"),
            };

            foreach (var location in locationCategories)
            {
                await _context.AddItemAsync<LocationCategory>(location);
            }

            foreach (var expenseCategory in expenseCategories)
            {
                await _context.AddItemAsync<ExpenseCategory>(expenseCategory);
            }
        }
    }
}
