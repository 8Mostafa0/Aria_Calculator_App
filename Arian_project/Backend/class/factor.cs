
using System.Collections.Generic;

namespace Arian_project
{
    public class Factor
    {
        public int id {  get; set; }
        public int client_id { get; set; }
        public string client_name { get; set; }
        public string factor_type { get; set; }
        public decimal full_price { get; set; }
        public decimal profit { get; set; }
        public decimal payed_price { get; set; }
        public string factor_date { get; set; }
        public string client_group {  get; set; }
        public List<Transaction> transactions { get; set; } = new List<Transaction>();
        public List<Store> items { get; set; } = new List<Store>();

        public string factor_status { get; set; }

        public Factor(int id,int client_id,string client_name,string factor_type, decimal full_price, decimal profit,decimal payed_price, string factor_date,string client_group,string factor_status)
        {
            this.id = id;
            this.client_name = client_name;
            this.client_id = client_id;
            this.factor_type = factor_type;
            this.full_price = full_price;
            this.profit = profit;
            this.payed_price = payed_price;
            this.factor_date = factor_date;
            this.client_group = client_group;
            this.factor_status = factor_status;
        }
    }
}
