using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFToBlazor.Data.Model
{
    public class BillDataModel
    {
        public long Id { get; set; }

        public DateTime BillDate { get; set; }

        public string billData { get; set; }

        public double discount { get; set; }

        public double grandTotal { get; set; }

        public double subTotal { get; set; }

        // Add this property to link bill items to the bill
        public List<BillRowItem> BillItems { get; set; } = new List<BillRowItem>();

        public BillDataModel()
        {
            
        }
    }
}
