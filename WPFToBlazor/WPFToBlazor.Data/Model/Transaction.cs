using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFToBlazor.Data.Model
{
    public class Transaction
    {
        [Key]
        public long Id { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public List<BillRowItem> Items { get; set; }
        public double Total { get; set; }

        public Transaction()
        {
            
        }
    }
}
