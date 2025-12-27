namespace Medisure{
    class Info{
   
     public  Info(string? billId, string name, bool hasInsurance, double consultationFee , double labCharges, double medicineCharges){
            Id=billId;
            Name=name;
            HasInsurance=hasInsurance;
            ConsultationFee=consultationFee;
            LabCharges=labCharges;
            MedicineCharges=medicineCharges;
    }
    public string? Id{ get; set;}
    public string Name{ get; set;}
    public bool HasInsurance{ get; set;}
    public double ConsultationFee{ get; set;}
    public double LabCharges{ get; set;}
    public double MedicineCharges{ get; set;}

}

}