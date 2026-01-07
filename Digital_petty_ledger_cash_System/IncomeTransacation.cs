namespace test
{
    // Represents an income transaction
    public class IncomeTransaction : Transaction
    {
        // Source of income (Main Cash, Bank Transfer, etc.)
        public string Source { get; }

        // Constructor to initialize income details
        public IncomeTransaction(int id, DateTime date, decimal amount, string description, string source)
            : base(id, date, amount, description)
        {
            Source = source;
        }

        // Returns a short summary of the income
        public override string GetSummary()
        {
            return $"[INCOME] {Date:d} | {Source} | ${Amount} | {Description}";
        }
    }
}
