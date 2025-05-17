namespace WPFToBlazor.Client.Models
{
    public class Item
    {
        public long ItemId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public string Category { get; set; }

        public string Photo { get; set; }

        public Item()
        {
            
        }
    }
}