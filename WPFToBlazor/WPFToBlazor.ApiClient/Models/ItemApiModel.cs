using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFToBlazor.ApiClient.Models
{
    public class ItemApiModel
    {
        public long ItemId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public string Category { get; set; }

        public string Photo { get; set; }

        public ItemApiModel()
        {

        }
    }
}
