using Arian_project.backend;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Installment_Payment : Form
    {
        private Factor factor {  get; set; }
        private clients_database clients_db = new clients_database();
        private string today_string {  get; set; }
        iran_date date = new iran_date();
        public Installment_Payment(Factor factor)
        {
            InitializeComponent();
            this.factor = factor;
            
        }

        private void Installment_Payment_Load(object sender, System.EventArgs e)
        {
            set_date();
            load_data();
            set_style();
        }
        private void set_date()
        {
            int[] data = date.Today();
            this.today_string = data[0].ToString() +"/"+ data[1].ToString() + "/"+data[2].ToString();
        }
        private void set_style() { }

        private void load_data() {
            
            factor_id_lb.Text = this.factor.id.ToString();
            installment_id_lb.Text = "1";
            Client user = clients_db.Get_Client_by_id(this.factor.client_id);
            user_name_lb.Text = user.user_name;
            phone_number_lb.Text = user.phone_number;
            factor_full_price_lb.Text = this.factor.full_price.ToString();
            factor_left_over_price_lb.Text = (this.factor.full_price - this.factor.payed_price).ToString();
            factor_date_lb.Text = this.factor.factor_date;
            int[] next_months = date.next_months(1);
            installment_first_pay_date_lb.Text = next_months[0].ToString() + "/" + next_months[1].ToString() + "/" + next_months[2].ToString();
            installment_profit_lb.Text = "3";
            installment_price_lb.Text = "";
            isntallment_full_profit_lb.Text = "0";
            ful_price_lb.Text = this.factor.full_price.ToString();
            month_count_lb.Text = "1";

        }
    }
}
