using System;
using System.Collections.Generic;
using System.Text;

namespace SmartExpenseTracker.Models;

public class Expense
{
    public required string Title { get; set; }
    public double Amount { get; set; }
    public required string Category { get; set; }
    public DateTime Date { get; set; }
}