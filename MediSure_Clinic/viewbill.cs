namespace Medisure{
    class viewBill : CreateBill{
    public viewBill(string? billId, string name, bool hasInsurance, double consultationFee , double labCharges, double medicineCharges)
        : base(billId, name, hasInsurance, consultationFee, labCharges, medicineCharges){
    }

    public void DisplayBill(){
        Console.WriteLine($"Bill ID: {Id}");
        Console.WriteLine($"Patient Name: {Name}");
        Console.WriteLine($"Has Insurance: {HasInsurance}");
        Console.WriteLine($"Consultation Fee: {ConsultationFee}");
        Console.WriteLine($"Lab Charges: {LabCharges}");
        Console.WriteLine($"Medicine Charges: {MedicineCharges}");
        Console.WriteLine($"Total Amount: {CalculateTotal()}");
    }
}
}