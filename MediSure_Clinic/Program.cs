namespace Medisure{
class Program{
    public static void Main(string[] args){
        CreateBill? lastBill = null;

        while(true){
        Console.WriteLine("Enter the number of terms:");
        Console.WriteLine("1: Create a new Bill");
        Console.WriteLine("2: View Last Bill ");
        Console.WriteLine("3: Clear Last Bill");
        Console.WriteLine("4: Exit");
        int n=int.Parse(Console.ReadLine());
    
      
        switch(n){
            case 1:
                    Console.WriteLine("Enter Bill ID:");
                    string? billId = Console.ReadLine();

                    Console.WriteLine("Enter Patient Name:");
                    string name = Console.ReadLine()!;

                    Console.WriteLine("Does the patient have insurance? (yes/no):");
                    string? insuranceInput = Console.ReadLine();
                    bool hasInsurance = insuranceInput?.ToLower() == "yes";

                    Console.WriteLine("Enter Consultation Fee:");
                    double consultationFee = double.Parse(Console.ReadLine()!);

                    Console.WriteLine("Enter Lab Charges:");
                    double labCharges = double.Parse(Console.ReadLine()!);

                    Console.WriteLine("Enter Medicine Charges:");
                    double medicineCharges = double.Parse(Console.ReadLine()!);

                   lastBill = new CreateBill(
                                            billId, name, hasInsurance,
                                consultationFee, labCharges, medicineCharges
                                            );             ;
                    double totalAmount = lastBill.CalculateTotal();
                    double result = Math.Round(totalAmount, 2);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n--- BILL AMOUNT CREATED SUCCESSFULLY ---");
                    Console.WriteLine($"Total Bill Amount: {result}\n");
                    
                    break;

               


            case 2:
                if (lastBill == null)
                    {
                        Console.WriteLine("\n\nNo previous bill found.");
                    }
                     else
                    {       
                        Console.WriteLine("\n--- PREVIOUS BILL ---");
                        Console.WriteLine($"Bill ID: {lastBill.Id}");
                        Console.WriteLine($"Patient Name: {lastBill.Name}");
                        Console.WriteLine($"Has Insurance: {lastBill.HasInsurance}");
                        Console.WriteLine($"Consultation Fee: {lastBill.ConsultationFee}");
                        Console.WriteLine($"Lab Charges: {lastBill.LabCharges}");
                        Console.WriteLine($"Medicine Charges: {lastBill.MedicineCharges}");
                        Console.WriteLine($"Total Amount: {lastBill.CalculateTotal():F2} \n");

                     }
    break;

               


            case 3:
                lastBill = null;
                Console.WriteLine("Last bill cleared successfully.");
                break;


            default:
                Console.WriteLine("Exited Successfully");
                break;
        }
        if(n==4){
            break;

        }
    }
}





}

}