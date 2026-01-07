namespace test
{
    // Generic ledger to store transactions
    public class Ledger<T> where T : Transaction
    {
        // Stores all transactions in memory
        private readonly List<T> entries = new();

        // Adds a transaction to the ledger
        public void AddEntry(T entry)
        {
            entries.Add(entry);
        }

        // Calculates total amount of all transactions
        public decimal CalculateTotal()
        {
            return entries.Sum(e => e.Amount);
        }

        // Returns all stored transactions
        public List<T> GetAll()
        {
            return entries;
        }
    }
}
