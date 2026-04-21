using SmartExpenseTracker.ViewModels;

namespace SmartExpenseTracker;

public partial class App : Application
{
    public static ExpenseViewModel VM { get; private set; }

    public App()
    {
        InitializeComponent();

        VM = new ExpenseViewModel();

        MainPage = new AppShell();
    }
}