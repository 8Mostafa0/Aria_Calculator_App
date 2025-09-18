namespace Arian_project.Backend
{
    public class Debt
    {
        public int id { get; set; }
        public string name{ get; set; }
        public decimal price { get; set; }
        public string date { get; set; }
        public string description { get; set; }
        public int bank_id { get; set; }
        public string bank_name { get; set; }
        public Debt(int id,string name,decimal price,string date,string description,int bank_id,string bank_name) {
            this.id = id;
            this.name = name;
            this.price = price;
            this.date = date;
            this.description = description;
            this.bank_id = bank_id;
            this.bank_name = bank_name;
        }
    }
}
