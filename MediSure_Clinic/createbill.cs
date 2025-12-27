namespace Medisure{
    // CreateBill class extends Info and adds billing logic
    // It is responsible for calculating the total bill amount
    class CreateBill : Info{

    // Constructor that initializes bill details using base class constructor
    public CreateBill(string? billId, string name, bool hasInsurance,
                      double consultationFee , double labCharges, double medicineCharges)
        : base(billId, name, hasInsurance, consultationFee, labCharges, medicineCharges){
    }

    // Method to calculate total bill amount
    public double CalculateTotal(){

        // Add all individual charges
        double total = ConsultationFee + LabCharges + MedicineCharges;

        // Apply 10% discount if patient has insurance
        if(HasInsurance){
            total = total * 0.9; 
        }

        // Return the final calculated amount
        return total;
    }

}
}
