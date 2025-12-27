namespace Quickmart{
     public class calculate: Info{
        public calculate(string? invoiceNo, string customerName, string itemName,
                         int quantity, double purchaseamount, double sellingamount)
            : base(invoiceNo, customerName, itemName, quantity, purchaseamount, sellingamount){}

        public void CalculateProfitOrLoss()
{
    // Check if transaction data exists
    if (PurchaseAmount == 0 && SellingAmount == 0)
    {
        Console.WriteLine("No transaction available. Please create a new transaction first.");
        return;
    }

    double profitOrLossAmount;
    string status;

    // Determine PROFIT / LOSS / BREAK-EVEN
    if (SellingAmount > PurchaseAmount)
    {
        status = "PROFIT";
        profitOrLossAmount = SellingAmount - PurchaseAmount;
    }
    else if (SellingAmount < PurchaseAmount)
    {
        status = "LOSS";
        profitOrLossAmount = PurchaseAmount - SellingAmount;
    }
    else
    {
        status = "BREAK-EVEN";
        profitOrLossAmount = 0;
    }

    // Calculate profit margin percentage
    double profitMarginPercent = PurchaseAmount == 0
        ? 0
        : (profitOrLossAmount / PurchaseAmount) * 100;

    // Output (rounded to 2 decimals)
    Console.WriteLine("\n--- PROFIT / LOSS CALCULATION ---");
    Console.WriteLine($"Status              : {status}");
    Console.WriteLine($"Amount              : {Math.Round(profitOrLossAmount, 2)}");
    Console.WriteLine($"Total Profit/Loss Amount : {Math.Round(profitOrLossAmount * Quantity, 2)}");
    Console.WriteLine($"Profit Margin (%)   : {Math.Round(profitMarginPercent, 2)}%");
}

    }
}