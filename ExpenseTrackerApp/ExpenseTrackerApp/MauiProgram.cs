using ExpenseTrackerApp.Interfaces;
using ExpenseTrackerApp.Services;
using Microsoft.Extensions.Logging;

namespace ExpenseTrackerApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            IServiceCollection serviceCollection = builder.Services.AddSingleton<IExpenseService, ExpenseService>();

            // ViewModels
            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<CategoryViewModel>();
            builder.Services.AddSingleton<ExpenseViewModel>();
            builder.Services.AddSingleton<AddExpenseViewModel>();
            builder.Services.AddSingleton<CategoryViewModel>();
            builder.Services.AddSingleton<CategoryPage>();
            builder.Services.AddSingleton<ExpenseViewModel>();
            builder.Services.AddSingleton<ExpensePage>();
            builder.Services.AddSingleton<AddExpenseViewModel>();
            builder.Services.AddSingleton<AddExpensePage>();
            builder.Services.AddSingleton<IExpenseService, ExpenseService>();

            // Views
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<CategoryPage>();
            builder.Services.AddSingleton<ExpensePage>();
            builder.Services.AddSingleton<AddExpensePage>();
            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<HomePage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
