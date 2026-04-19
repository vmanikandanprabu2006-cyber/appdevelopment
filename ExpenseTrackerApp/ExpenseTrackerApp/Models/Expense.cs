public class Expense
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; }
    public string Note { get; set; }

    public int CategoryId { get; set; }

    public string CategoryName { get; set; }
    public string CategoryIcon { get; set; }
}