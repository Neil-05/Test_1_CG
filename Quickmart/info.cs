namespace Quickmart{

    public class Info{
        public Info(string? invoiceNo, string customerName, string itemName,
                    int quantity, double purchaseamount, double sellingamount){
            InvoiceNo = invoiceNo;
            CustomerName = customerName;
            ItemName = itemName;
            Quantity = quantity;
            PurchaseAmount = purchaseamount;
            SellingAmount = sellingamount;
        }

        public string? InvoiceNo { get; set; }
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double PurchaseAmount { get; set; }
        public double SellingAmount { get; set; }
    }
}