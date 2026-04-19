namespace ExpenseTrackerApp
{
    internal class ExpensePage
    {
        private List<Expense> expenses = new();

        public double TotalAmount => expenses.Sum(e => (double)e.Amount);
    }
}