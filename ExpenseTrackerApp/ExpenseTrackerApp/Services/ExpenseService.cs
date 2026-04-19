using ExpenseTrackerApp.Models;
using ExpenseTrackerApp.Interfaces;

namespace ExpenseTrackerApp.Services;

public class ExpenseService : IExpenseService
{
    private List<Category> categories = new()
    {
        new Category { Id = 1, Name = "Food", Icon = "🍔" },
        new Category { Id = 2, Name = "Transport", Icon = "🚌" }
    };

    private List<Expense> expenses = new();

    public Task<List<Category>> GetCategories() => Task.FromResult(categories);

    public Task AddCategory(Category category)
    {
        category.Id = categories.Count + 1;
        categories.Add(category);
        return Task.CompletedTask;
    }

    public Task DeleteCategory(int id)
    {
        categories.RemoveAll(c => c.Id == id);
        return Task.CompletedTask;
    }

    public Task<List<Expense>> GetExpenses() => Task.FromResult(expenses);

    public Task AddExpense(Expense expense)
    {
        expense.Id = expenses.Count + 1;

        var cat = categories.FirstOrDefault(c => c.Id == expense.CategoryId);
        if (cat != null)
        {
            expense.CategoryName = cat.Name;
            expense.CategoryIcon = cat.Icon;
        }

        expenses.Add(expense);
        return Task.CompletedTask;
    }

    public Task DeleteExpense(int id)
    {
        expenses.RemoveAll(e => e.Id == id);
        return Task.CompletedTask;
    }
}