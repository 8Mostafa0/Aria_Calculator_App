namespace Arian_project
{
    public class Client
    {
        public int id {  get; set; }
        public string user_name { get; set; }
        public string phone_number { get; set; }
        public string home_number { get; set; }
        public string company { get; set; }
        public string email { get; set; }
        public string client_type { get; set; }
        public string client_group { get; set; }

        public Client(int id,string user_name,string phone_number,string home_number,string company,string email,string client_type,string client_group) {
            this.id = id;
            this.user_name = user_name;
            this.phone_number = phone_number;
            this.home_number = home_number;
            this.company = company;
            this.email = email;
            this.client_type = client_type;
            this.client_group = client_group;
        }
    }
}
