namespace WPFToBlazor.ApiClient.Models
{
    public class TransactionApiModel
    {
        public long Id { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public List<BillRowItemApiModel> Items { get; set; }
        public double Total { get; set; }

        public TransactionApiModel()
        {
            
        }
    }
}