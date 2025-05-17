namespace WPFToBlazor.Client.Models
{
    public class BillModel
    {
        public int BillNo { get; set; }
        public DateTime Date { get; set; }
        public string CashierName { get; set; } = "";
        public List<BillItem> Items { get; set; } = new();
        public decimal DiscountPercent { get; set; }
        public decimal CashReceived { get; set; }
        public decimal GrandTotal => Items.Sum(i => i.Total);
        public decimal DiscountAmount => GrandTotal * (DiscountPercent / 100m);
        public decimal SubTotal => GrandTotal - DiscountAmount;
        public decimal Balance => CashReceived - SubTotal;
    }

    public class BillItem
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Total => Price * Qty;
    }
}
