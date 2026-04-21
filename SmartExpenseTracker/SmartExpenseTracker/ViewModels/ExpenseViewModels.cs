using System.Collections.ObjectModel;
using System.Windows.Input;
using SmartExpenseTracker.Models;

namespace SmartExpenseTracker.ViewModels;

public class ExpenseViewModel
{
    public ObservableCollection<Expense> Expenses { get; set; }

    public string Title { get; set; }
    public string Category { get; set; }
    public string AmountText { get; set; }

    public ICommand AddExpenseCommand { get; }

    public ExpenseViewModel()
    {
        Expenses = new ObservableCollection<Expense>();

        AddExpenseCommand = new Command(AddExpense);
    }

    private void AddExpense()
    {
        if (double.TryParse(AmountText, out double amount))
        {
            Expenses.Add(new Expense
            {
                Title = Title,
                Category = Category,
                Amount = amount,
                Date = DateTime.Now
            });

            // Clear inputs
            Title = string.Empty;
            Category = string.Empty;
            AmountText = string.Empty;
        }
    }
}