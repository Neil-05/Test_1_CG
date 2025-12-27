namespace Quickmart{
    public class Create : Info{

        // Default constructor
        public Create() : base(null, "", "", 0, 0, 0) { }

        // Parameterized constructor
        public Create(string? invoiceNo, string customerName, string itemName,
                      int quantity, double purchaseamount, double sellingamount)
            : base(invoiceNo, customerName, itemName, quantity, purchaseamount, sellingamount){}

        // Take input and return the same object
       public Create GetDetails()
       {
            Console.WriteLine("Enter Invoice No:");
            InvoiceNo = Console.ReadLine();//Taking Inputs

            if (string.IsNullOrWhiteSpace(InvoiceNo))//Added Constraints
            {
                Console.WriteLine("Invoice No cannot be empty.");
                return this;
            }

            Console.WriteLine("Enter Customer Name:");
            CustomerName = Console.ReadLine()!;

            Console.WriteLine("Enter Item Name:");
            ItemName = Console.ReadLine()!;

            Console.WriteLine("Enter Quantity:");
            Quantity = int.Parse(Console.ReadLine()!);

            if (Quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0.");
                return this;
            }

            Console.WriteLine("Enter Purchase Amount:");
            PurchaseAmount = double.Parse(Console.ReadLine()!);

            if (PurchaseAmount <= 0)
            {
                Console.WriteLine("Purchase Amount must be greater than 0.");
                return this;
            }

            Console.WriteLine("Enter Selling Amount:");
            SellingAmount = double.Parse(Console.ReadLine()!);

            if (SellingAmount < 0)
            {
                Console.WriteLine("Selling Amount cannot be negative.");
                return this;
            }

            return this;
}
        }
    }
