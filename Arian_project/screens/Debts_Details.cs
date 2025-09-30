using Arian_project.Backend;
using Arian_project.Backend.Database;
using Arian_project.Backend.styles;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Debts_Details : Form
    {
        int debt_id = 0;
        Banks_database bank_db = new Banks_database();
        Iran_date date = new Iran_date();
        Debt_database debt_db = new Debt_database();
        public Debt return_debt;
        bool edite_screen = false;
        public Debts_Details(int debt_id,Debt debt=null)
        {
            InitializeComponent();
            Set_Style();
            load_data();
            this.debt_id = debt_id;
            if (debt != null) { 
                Load_Debt(debt);
                cancel_bt.Text = "حذف";
                this.edite_screen = true;
            }
        }
        private void Load_Debt(Debt debt)
        {
            int debt_type = debt_types_cb.Items.IndexOf(debt.name);
            debt_types_cb.SelectedIndex = debt_type;
            price_bt.Text = debt.price.ToString();
            date_lb.Text = debt.date;
            desciption_tb.Text = debt.description;
            int bank_id = banks_cb.Items.IndexOf(debt.bank_name);
            banks_cb.SelectedIndex = bank_id;
        }
        private void Set_Style()
        {
            new Form_Styles().Style(this);
        }

        private void load_data()
        {
            set_debts_types();
            set_bank_names();
            set_date();
        }
        private void set_debts_types()
        {
            List<string> debts = new List<string>()
            {
                "اب",
                "برق",
                "گاز",
                "اینترنت",
                "مالیات",
                "اجاره"
            };
            debt_types_cb.DataSource = debts;
        }
        private void set_bank_names()
        {
            List<string> bank_names = bank_db.get_banks_name(); 
            banks_cb.DataSource = bank_names;
        }
        private void set_date()
        {
            int[] today = date.Today();
            date_lb.Text = today[0] + "/" + today[1] + "/" + today[2];
        }

        private int get_bank_id(string name)
        {
            return bank_db.get_bank_data_by_name(name).id;
        }
        private void revert_cost_from_bank() { 
            int bank_id = this.return_debt.bank_id;
            decimal prive = this.return_debt.price;
            string sql_query = $"";
            Bank bank = bank_db.get_bank_data_by_id(bank_id);
            bank.balance += prive;
            bank_db.edite_bank_in_database(bank);
        }

        private void take_cost_from_bank()
        {
            int bank_id = this.return_debt.bank_id;
            decimal prive = this.return_debt.price;
            string sql_query = $"";
            Bank bank = bank_db.get_bank_data_by_id(bank_id);
            bank.balance -= prive;
            bank_db.edite_bank_in_database(bank);
        }
        private bool validate_inputs()
        {
            if (
                debt_types_cb.Text == "" ||
                price_bt.Text == "" ||
                date_lb.Text  == ""||
                banks_cb.Text == ""
                ) {
                return false;
            }
            return true;
        }
        private void save_bt_Click(object sender, System.EventArgs e)
        {
            if (validate_inputs())
            {
                string name = banks_cb.Text;
                if (this.edite_screen)
                {
                    revert_cost_from_bank();
                }
                this.return_debt = new Debt(
                    this.debt_id,
                    debt_types_cb.Text,
                    decimal.Parse(price_bt.Text),
                    date_lb.GetText("yyyy/MM/dd"),
                    desciption_tb.Text,
                    get_bank_id(name),
                    banks_cb.Text
                    );
                this.DialogResult = DialogResult.OK;
                if (this.edite_screen)
                {
                    debt_db.update_debt_to_db(this.return_debt);
                }
                else
                {
                    debt_db.insert_debt_to_db(this.return_debt);
                }
                take_cost_from_bank();
                this.Close();
            }
            else
            {
                MessageBox.Show("لطفا تمامی موارد را وارد کنید", "ورودی ها");
            }

        }

        private void cancel_bt_Click(object sender, System.EventArgs e)
        {
            if (this.edite_screen)
            {
                Button yesbtn = new Button();
                Button nbtn = new Button();
                yesbtn.Text = "بله";
                nbtn.Text = "خیر";
                Button[] buttons = {yesbtn, nbtn};
                using (PMessageBox screen = new PMessageBox("", "", buttons)) { 
                    screen.ShowDialog();
                    if(screen.result == yesbtn)
                    {
                        debt_db.delete_debt_to_db(debt_id);
                        this.DialogResult = DialogResult.Cancel;
                        this.Close ();
                    }
                }
            }
        }
    }
}
