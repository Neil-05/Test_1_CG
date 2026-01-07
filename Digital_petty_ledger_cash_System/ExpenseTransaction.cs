namespace test
{
    // Represents an expense transaction
    public class ExpenseTransaction : Transaction
    {
        // Expense category (Office, Food, Travel, etc.)
        public string Category { get; }

        // Constructor to initialize expense details
        public ExpenseTransaction(int id, DateTime date, decimal amount, string description, string category)
            : base(id, date, amount, description)
        {
            Category = category;
        }

        // Returns a short summary of the expense
        public override string GetSummary()
        {
            return $"[EXPENSE] {Date:d} | {Category} | ${Amount} | {Description}";
        }
    }
}
