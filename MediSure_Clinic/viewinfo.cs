namespace Medisure{
    // Info class stores basic bill and patient information
    // It acts as a base class for billing-related classes
    class Info{
   
     // Parameterized constructor to initialize all bill details
     public Info(string? billId, string name, bool hasInsurance,
                 double consultationFee , double labCharges, double medicineCharges){
            
            // Assign bill ID
            Id = billId;

            // Assign patient name
            Name = name;

            // Assign insurance status
            HasInsurance = hasInsurance;

            // Assign consultation charges
            ConsultationFee = consultationFee;

            // Assign lab charges
            LabCharges = labCharges;

            // Assign medicine charges
            MedicineCharges = medicineCharges;
    }

    // Stores unique bill identifier
    public string? Id{ get; set;}

    // Stores patient name
    public string Name{ get; set;}

    // Indicates whether patient has insurance or not
    public bool HasInsurance{ get; set;}

    // Stores consultation fee amount
    public double ConsultationFee{ get; set;}

    // Stores lab charges amount
    public double LabCharges{ get; set;}

    // Stores medicine charges amount
    public double MedicineCharges{ get; set;}

}

}
