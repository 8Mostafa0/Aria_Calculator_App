
namespace Arian_project
{
    public class Store
    {
        public int id {  get; set; }
        public int store_id { get; set; }
        public string item_name { get; set; }
        public int buy_price { get; set; }
        public int cell_price {  get; set; }
        public int count { get; set; }
        public string buy_date {  get; set; }
        public string cell_date { get; set; }
        public bool service_item {  get; set; }

        public Store(int id, int store_id, string item_name, int buy_price, int cell_price, int count, string buy_date, string cell_date, bool service_item)
        {
            this.id = id;
            this.store_id = store_id;
            this.item_name = item_name;
            this.buy_price = buy_price;
            this.cell_price = cell_price;
            this.count = count;
            this.buy_date = buy_date;
            this.cell_date = cell_date;
            this.service_item = service_item;
        }
    }
}
