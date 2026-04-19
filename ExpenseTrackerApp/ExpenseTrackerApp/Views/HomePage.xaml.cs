public partial class HomePage : ContentPage
{
    private readonly HomeViewModel _vm;

    public HomePage(HomeViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
        _vm = vm;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _vm.LoadData();
    }

    private async void GoToCategories(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CategoryPage");
    }

    private async void GoToExpenses(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ExpensePage");
    }
}