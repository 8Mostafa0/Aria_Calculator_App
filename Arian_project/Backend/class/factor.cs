
using System.Collections.Generic;

namespace Arian_project
{
    public class Factor
    {
        public int id {  get; set; }
        public int client_id { get; set; }
        public decimal full_price { get; set; }
        public decimal profit { get; set; }
        public string factor_date { get; set; }
        public string client_group {  get; set; }
        public List<Transaction> transactions { get; set; } = new List<Transaction>();
        public List<Store> items { get; set; } = new List<Store>();

        public string factor_status { get; set; }

        public Factor(int id,int client_id, decimal full_price, decimal profit,string factor_date,string client_group,string factor_status)
        {
            this.id = id;
            this.client_id = client_id;
            this.full_price = full_price;
            this.profit = profit;
            this.factor_date = factor_date;
            this.client_group = client_group;
            this.factor_status = factor_status;
        }
    }
}
