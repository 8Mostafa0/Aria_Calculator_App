namespace Arian_project
{
    public class Service
    {
        public int id {  get; set; }

        public int item_id { get; set; }

        public string service_name { get; set; }

        public int cell_price {  get; set; }

        public Service(int id, int item_id, string service_name, int cell_price)
        {
            this.id = id;
            this.item_id = item_id;
            this.service_name = service_name;
            this.cell_price = cell_price;
        }
    }
}
