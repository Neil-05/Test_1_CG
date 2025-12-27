namespace Quickmart{
     public class view : Info{
        public view(string? invoiceNo, string customerName, string itemName,
                    int quantity, double purchaseamount, double sellingamount)
            : base(invoiceNo, customerName, itemName, quantity, purchaseamount, sellingamount){}

        public void DisplayDetails(){
            Console.WriteLine($"Invoice No: {InvoiceNo}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Item Name: {ItemName}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Purchase Amount: {PurchaseAmount}");
            Console.WriteLine($"Selling Amount: {SellingAmount}");
        }
    }
}