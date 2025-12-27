namespace Quickmart{

    public class Program{
        public static void Main(string[] args){
            Create? lasttransaction = null;

            while(true){
                Console.WriteLine("\nQuickmart Transaction System");
                Console.WriteLine("1. Create New Transaction");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss for Last Transaction");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine()!);

                if(choice == 1){
                    Create create = new Create();
                    lasttransaction = create.GetDetails();
                    Console.WriteLine("Transaction created successfully.");
                    if(lasttransaction != null){
                        calculate calc = new calculate(lasttransaction.InvoiceNo, lasttransaction.CustomerName,
                                                       lasttransaction.ItemName, lasttransaction.Quantity,
                                                       lasttransaction.PurchaseAmount, lasttransaction.SellingAmount);
                        calc.CalculateProfitOrLoss();
                    } else {
                        Console.WriteLine("No transaction available. Please create a new transaction first.");
                    }
                }


                else if(choice == 2){
                    if(lasttransaction != null){
                        view view = new view(lasttransaction.InvoiceNo, lasttransaction.CustomerName,
                                            lasttransaction.ItemName, lasttransaction.Quantity,
                                            lasttransaction.PurchaseAmount, lasttransaction.SellingAmount);
                        view.DisplayDetails();
                        if(lasttransaction != null){
                        calculate calc = new calculate(lasttransaction.InvoiceNo, lasttransaction.CustomerName,
                                                       lasttransaction.ItemName, lasttransaction.Quantity,
                                                       lasttransaction.PurchaseAmount, lasttransaction.SellingAmount);
                        calc.CalculateProfitOrLoss();
                    } else {
                        Console.WriteLine("No transaction available. Please create a new transaction first.");
                    }
                    } else {
                        Console.WriteLine("No transaction available. Please create a new transaction first.");
                    }
                }
                else if(choice == 3){
                    if(lasttransaction != null){
                        calculate calc = new calculate(lasttransaction.InvoiceNo, lasttransaction.CustomerName,
                                                       lasttransaction.ItemName, lasttransaction.Quantity,
                                                       lasttransaction.PurchaseAmount, lasttransaction.SellingAmount);
                        calc.CalculateProfitOrLoss();
                    } else {
                        Console.WriteLine("No transaction available. Please create a new transaction first.");
                    }
                }
                else if(choice == 4){
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }
                else{
                    Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}

}