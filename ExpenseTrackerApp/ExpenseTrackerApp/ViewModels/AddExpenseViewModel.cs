using System.Collections.ObjectModel;
using ExpenseTrackerApp.Interfaces;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.ViewModels;

public partial class AddExpenseViewModel : BaseViewModel
{
    private readonly IExpenseService _service;

    public ObservableCollection<Category> Categories { get; set; } = new();

    private Category? selectedCategory;
    public Category? SelectedCategory
    {
        get => selectedCategory;
        set
        {
            selectedCategory = value;
            OnPropertyChanged(nameof(SelectedCategory));
        }
    }

    private string title = string.Empty;
    public string Title
    {
        get => title;
        set
        {
            title = value;
            OnPropertyChanged(nameof(Title));
        }
    }

    private string amount = string.Empty;
    public string Amount
    {
        get => amount;
        set
        {
            amount = value;
            OnPropertyChanged(nameof(Amount));
        }
    }

    public DateTime Date { get; set; } = DateTime.Now;

    private string note = string.Empty;
    public string Note
    {
        get => note;
        set
        {
            note = value;
            OnPropertyChanged(nameof(Note));
        }
    }

    public AddExpenseViewModel(IExpenseService service)
    {
        _service = service;
    }

    public async Task LoadCategories()
    {
        var list = await _service.GetCategories();
        Categories.Clear();

        foreach (var item in list)
            Categories.Add(item);
    }

    public async Task SaveExpense()
    {
        if (SelectedCategory == null || string.IsNullOrWhiteSpace(Title))
            return;

        if (!double.TryParse(Amount, out double parsedAmount))
            return;

        Expense expense = new Expense
        {
            Title = Title,
            Amount = parsedAmount,
            Date = Date,
            CategoryId = SelectedCategory.Id,
            Note = Note
        };

        await _service.AddExpense(expense);

        // Reset fields after save
        Title = string.Empty;
        Amount = string.Empty;
        Note = string.Empty;
        SelectedCategory = null;

        OnPropertyChanged(nameof(Title));
        OnPropertyChanged(nameof(Amount));
        OnPropertyChanged(nameof(Note));
        OnPropertyChanged(nameof(SelectedCategory));

        await Shell.Current.GoToAsync("..");
    }
}