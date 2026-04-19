using ExpenseTrackerApp.Models;
using ExpenseTrackerApp.ViewModels;

namespace ExpenseTrackerApp.Views;

public partial class CategoryPage : ContentPage
{
    private readonly CategoryViewModel _vm;

    public CategoryPage(CategoryViewModel vm)
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

    private async void OnAddClicked(object sender, EventArgs e)
    {
        await _vm.AddCategory();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var category = button?.BindingContext as Category;

        if (category != null)
            await _vm.DeleteCategory(category);
    }
}