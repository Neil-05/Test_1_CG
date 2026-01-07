namespace test
{
    // Base class for all transactions
    public abstract class Transaction : IReportable
    {
        // Common transaction properties
        public int Id { get; }
        public DateTime Date { get; }
        public decimal Amount { get; }
        public string Description { get; }

        // Constructor to initialize transaction data
        protected Transaction(int id, DateTime date, decimal amount, string description)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Description = description;
        }

        // Method to be implemented by derived classes
        public abstract string GetSummary();
    }
}
