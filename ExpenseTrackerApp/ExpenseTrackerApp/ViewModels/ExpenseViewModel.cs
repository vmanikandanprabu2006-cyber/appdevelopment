using ExpenseTrackerApp.Interfaces;
using System.Collections.ObjectModel;

namespace ExpenseTrackerApp.ViewModels;

public partial class ExpenseViewModel : BaseViewModel
{
    public readonly IExpenseService _service;

    public ObservableCollection<Expense> Expenses { get; set; } = new();

    public ExpenseViewModel(IExpenseService service)
    {
        _service = service;
    }

    public async Task LoadExpenses()
    {
        var list = await _service.GetExpenses();
        Expenses.Clear();

        foreach (var item in list)
            Expenses.Add(item);
    }

    public async Task DeleteExpense(Expense expense)
    {
        await _service.DeleteExpense(expense.Id);
        await LoadExpenses();
    }
}