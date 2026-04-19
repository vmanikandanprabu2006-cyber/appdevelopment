using System.Collections.ObjectModel;
using ExpenseTrackerApp.Models;
using ExpenseTrackerApp.Interfaces;

namespace ExpenseTrackerApp.ViewModels;

public partial class CategoryViewModel : BaseViewModel
{
    private readonly IExpenseService _service;

    public ObservableCollection<Category> Categories { get; set; } = new();

    public string NewCategoryName { get; set; }
    public string NewCategoryIcon { get; set; }

    public CategoryViewModel(IExpenseService service) => _service = service;

    public async Task LoadCategories()
    {
        var list = await _service.GetCategories();
        Categories.Clear();

        foreach (var item in list)
            Categories.Add(item);
    }

    public async Task AddCategory()
    {
        if (string.IsNullOrWhiteSpace(NewCategoryName))
            return;

        var category = new Category
        {
            Name = NewCategoryName,
            Icon = NewCategoryIcon
        };

        await _service.AddCategory(category);
        await LoadCategories();

        NewCategoryName = string.Empty;
        NewCategoryIcon = string.Empty;

        OnPropertyChanged(nameof(NewCategoryName));
        OnPropertyChanged(nameof(NewCategoryIcon));
    }

    public async Task DeleteCategory(Category category)
    {
        await _service.DeleteCategory(category.Id);
        await LoadCategories();
    }
}