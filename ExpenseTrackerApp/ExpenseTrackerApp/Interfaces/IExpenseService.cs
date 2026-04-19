using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Interfaces;

public interface IExpenseService
{
    Task<List<Category>> GetCategories();
    Task AddCategory(Category category);
    Task DeleteCategory(int id);

    Task<List<Expense>> GetExpenses();
    Task AddExpense(Expense expense);
    Task DeleteExpense(int id);
}