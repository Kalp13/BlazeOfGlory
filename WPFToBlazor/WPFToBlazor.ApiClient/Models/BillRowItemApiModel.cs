using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFToBlazor.ApiClient.Models
{
    public class BillRowItemApiModel
    {
        public long BillRowItemId { get; set; }
        public string BillId { get; set; }
        public int RowNo { get; set; }
        public ItemApiModel Item { get; set; }
        public int Qty { get; set; }
        public double Total { get; set; }
        public string Comment { get; set; }

        public BillRowItemApiModel()
        {

        }
    }
}
