using ExpenseTrackerApp.Interfaces;

public partial class HomeViewModel : BaseViewModel
{
    private readonly IExpenseService _service;

    private int totalExpenses;
    public int TotalExpenses
    {
        get => totalExpenses;
        set
        {
            totalExpenses = value;
            OnPropertyChanged(nameof(TotalExpenses));
        }
    }

    private double totalAmount;
    public double TotalAmount
    {
        get => totalAmount;
        set
        {
            totalAmount = value;
            OnPropertyChanged(nameof(TotalAmount));
        }
    }

    public HomeViewModel(IExpenseService service)
    {
        _service = service;
    }

    public async Task LoadData()
    {
        var expenses = await _service.GetExpenses();

        TotalExpenses = expenses.Count;
        TotalAmount = expenses.Sum(e => e.Amount);
    }
}