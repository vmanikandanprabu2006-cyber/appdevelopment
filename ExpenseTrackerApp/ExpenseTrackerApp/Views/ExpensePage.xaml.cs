using ExpenseTrackerApp.Models;
using ExpenseTrackerApp.ViewModels;

namespace ExpenseTrackerApp.Views;

public partial class ExpensePage : ContentPage
{
    private readonly ExpenseViewModel _vm;

    public ExpensePage(ExpenseViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
        _vm = vm;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _vm.LoadExpenses();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        var expense = (sender as Button)?.BindingContext as Expense;

        if (expense != null)
            await _vm.DeleteExpense(expense);
    }

    private async void OnAddExpenseClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//AddExpensePage");
        await Shell.Current.GoToAsync(nameof(AddExpensePage));
    }
}