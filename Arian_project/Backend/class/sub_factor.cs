
namespace Arian_project
{
    public class Sub_factor
    {
        public int id {  get; set; }
        public int factor_id { get; set; }
        public int item_id {  get; set; }
        public int buy_price { get; set; }
        public int cell_price { get; set; }
        public int profit {  get; set; }
    
        public Sub_factor(int id, int factor_id, int item_id, int buy_price, int cell_price, int profit)
        {
            this.id = id;
            this.factor_id = factor_id;
            this.item_id = item_id;
            this.buy_price = buy_price;
            this.cell_price = cell_price;
            this.profit = profit;
        }
    }
}
