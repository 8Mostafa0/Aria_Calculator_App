namespace Arian_project.Backend
{
    public class Admin
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string access { get; set; }
        public Admin(int id, string username, string password,string access)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.access = access;
        }

        public static Admin Empty()
        {
            return new Admin(0, "", "", "0000000000000");
        }

        public bool Ac_Services_managment()
        {
            return this.access[0]=='1'?true:false;
        }
        public bool Ac_Banks_managment()
        {
            return this.access[1] == '1' ? true : false;

        }
        public bool Ac_Card_Readers_managment() { 
            return this.access[2]=='1'?true:false;
        }
        public bool Ac_add_buy_factor()
        {
            return this.access[3] == '1' ? true : false;
        }
        public bool Ac_edite_buy_factor()
        {
            return this.access[4] == '1' ? true : false;
        }
        public bool Ac_add_cell_factor()
        {
            return this.access[5] == '1' ? true : false;
        }
        public bool Ac_edite_cell_factor()
        {
            return this.access[6] == '1' ? true : false;
        }
        public bool Ac_pay_installment()
        {
            return this.access[7] == '1' ? true : false;
        }
        public bool Ac_edite_installment()
        {
            return this.access[8] == '1' ? true : false;
        }
        public bool Ac_client_managment()
        {
            return this.access[9] == '1' ? true : false;
        }
        public bool Ac_store_managment()
        {
            return this.access[10] == '1' ? true : false;
        }
        public bool Ac_debt_managment()
        {
            return this.access[11] == '1' ? true : false;
        }
        public bool Ac_prints()
        {
            return this.access[12] == '1' ? true : false;
        }
        public string Empty_Access()
        {
            return "0000000000000";
        }
    }
}
