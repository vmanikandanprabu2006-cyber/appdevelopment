
using ExpenseTrackerApp.Models;
namespace ExpenseTrackerApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Icon { get; set; }
    }
}