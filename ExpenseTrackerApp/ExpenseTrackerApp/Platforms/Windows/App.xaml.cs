namespace ExpenseTrackerApp;

public partial class App : Application
{
    [Obsolete]
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}