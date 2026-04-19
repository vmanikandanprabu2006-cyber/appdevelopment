using ExpenseTrackerApp.ViewModels;

namespace ExpenseTrackerApp.Views;

public partial class AddExpensePage : ContentPage
{
    private readonly AddExpenseViewModel _vm;

    public  AddExpensePage(AddExpenseViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
        _vm = vm;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _vm.LoadCategories();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        await _vm.SaveExpense();
    }
}