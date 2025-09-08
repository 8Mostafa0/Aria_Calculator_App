
using Arian_project.Backend;

namespace Arian_project
{
    public class Store
    {
        public int id {  get; set; }
        public int store_id { get; set; }
        public string item_name { get; set; }
        public decimal buy_price { get; set; }
        public decimal cell_price {  get; set; }
        public int count { get; set; }
        public string buy_date {  get; set; }
        public string cell_date { get; set; }
        public string service_item {  get; set; }
        public Stores_database store_db = new Stores_database();

        public Store(int id, int store_id, string item_name, decimal buy_price, decimal cell_price, int count, string buy_date, string cell_date, string service_item)
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

        public static Store Get_Store_From_Sub_Factor(Sub_factor item) {
            Store st = new Stores_database().get_item_by_id(item.item_id);
            st.cell_price = item.cell_price;
            st.buy_price = item.buy_price;
            st.count = item.count;
            return st;
        }
    }
}
