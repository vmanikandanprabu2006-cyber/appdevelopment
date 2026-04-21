using System.Text.Json;
using SmartExpenseTracker.Models;

namespace SmartExpenseTracker.Services;

public class FileService
{
    private string filePath = Path.Combine(FileSystem.AppDataDirectory, "expenses.json");

    public async Task SaveAsync(List<Expense> expenses)
    {
        var json = JsonSerializer.Serialize(expenses);
        await File.WriteAllTextAsync(filePath, json);
    }

    public async Task<List<Expense>> LoadAsync()
    {
        if (!File.Exists(filePath))
            return new List<Expense>();

        var json = await File.ReadAllTextAsync(filePath);
        return JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>();
    }
}