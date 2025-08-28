
namespace Arian_project
{
    public class Bank
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string bank_type { get; set; }
        public decimal balance { get; set; }

        public Bank(int id,string name,string bank_type, decimal balance)
        {
            this.id = id;
            this.name = name;
            this.bank_type = bank_type;
            this.balance = balance;
        }
    }
}
