using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFToBlazor.Data.Model
{
    public class BillRowItem
    {
        public long BillRowItemId { get; set; }
        public string BillId { get; set; }
        public int RowNo { get; set; }
        public Item Item { get; set; }
        public int Qty { get; set; }
        public double Total { get; set; }
        public string Comment { get; set; }

        public BillRowItem()
        {
            
        }
    }
}