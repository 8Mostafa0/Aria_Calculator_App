
using System.Windows.Forms;
using Arian_project.backend;

namespace Arian_project.screens
{
    public partial class Clients_Detailes : Form
    {
        public Clients_Detailes()
        {
            InitializeComponent();
        }

        private void save_client_bt_Click(object sender, System.EventArgs e)
        {
            int id = new clients_database().clients_count()+1;
            string user_name = name_tb.Text;
            string phone_number = phone_number_tb.Text;
            string home_phone = home_phone_tb.Text;
            string company = company_tb.Text;
            string email = email_tb.Text;
            string client_type = client_type_tb.Text;
            string client_group = client_group_tb.Text;
            Client user = new Client(id,user_name,phone_number,home_phone,company,email,client_type,client_group);
            bool result = new clients_database().insert_client_to_database(user);
            if (result) {
                MessageBox.Show("کاربر با موفقیت ثبت شد", "افزودن کاربر");
                clear_data();
                    
            }
            else
            {
                MessageBox.Show("هنگام ثبت کاربر مشکلی بوجود امده است", "افزودن کاربر");

            }
        }
        private void clear_data ()
        {
            name_tb.Clear();
            phone_number_tb.Clear();
            home_phone_tb.Clear();
            company_tb.Clear();
            email_tb.Clear();
            client_type_tb.Clear();
        }
        private void edite_client_bt_Click(object sender, System.EventArgs e)
        {

        }

        private void delete_client_bt_Click(object sender, System.EventArgs e)
        {

        }
    }
}
