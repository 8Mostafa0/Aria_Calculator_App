
namespace Arian_project
{
    public class Sub_factor
    {
        public int id {  get; set; }
        public int factor_id { get; set; }
        public int item_id {  get; set; }
        public decimal buy_price { get; set; }
        public decimal cell_price { get; set; }
        public decimal profit {  get; set; }
        public int count { get; set; }
    
        public Sub_factor(int id, int factor_id, int item_id, decimal buy_price, decimal cell_price, decimal profit, int count)
        {
            this.id = id;
            this.factor_id = factor_id;
            this.item_id = item_id;
            this.buy_price = buy_price;
            this.cell_price = cell_price;
            this.profit = profit;
            this.count = count;
        }
    }
}
