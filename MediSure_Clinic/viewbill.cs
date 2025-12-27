namespace Medisure{

// viewBill class is responsible ONLY for displaying bill details
// It does NOT inherit from CreateBill (good OOPS practice)
class viewBill{

    // This method takes a CreateBill object and displays its details
    public void DisplayBill(CreateBill bill){

        // Display bill ID
        Console.WriteLine($"Bill ID: {bill.Id}");

        // Display patient name
        Console.WriteLine($"Patient Name: {bill.Name}");

        // Display insurance status
        Console.WriteLine($"Has Insurance: {bill.HasInsurance}");

        // Display individual charges
        Console.WriteLine($"Consultation Fee: {bill.ConsultationFee}");
        Console.WriteLine($"Lab Charges: {bill.LabCharges}");
        Console.WriteLine($"Medicine Charges: {bill.MedicineCharges}");

        // Display total amount rounded to 2 decimal places
        Console.WriteLine($"Total Amount: {bill.CalculateTotal():F2}");
    }
}
}
