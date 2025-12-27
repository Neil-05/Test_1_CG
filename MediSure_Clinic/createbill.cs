namespace Medisure{
    class CreateBill : Info{

    public CreateBill(string? billId, string name, bool hasInsurance, double consultationFee , double labCharges, double medicineCharges)
        : base(billId, name, hasInsurance, consultationFee, labCharges, medicineCharges){
    }

    public double CalculateTotal(){
        double total=ConsultationFee + LabCharges + MedicineCharges;
        if(HasInsurance){
            total=total * 0.9; 
        }
        return total;
    }

}
}