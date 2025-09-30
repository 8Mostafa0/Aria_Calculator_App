
using Arian_project.Backend;
using Arian_project.Backend.Database;
using Arian_project.Backend.styles;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Debts_screen : Form
    {
        Debt_database debts_db = new Debt_database();
        Iran_date date = new Iran_date();
        private string time = "";
        int counter = 1;
        int cost_count = 0;
        decimal costs = 0;
        decimal power_cost = 0;
        decimal water_cost = 0;
        decimal gas_cost = 0;
        decimal internet_cost = 0;
        decimal tax_cost = 0;
        decimal rent_cost = 0;
        public Debts_screen()
        {
            InitializeComponent();
            Set_Style();
            Set_Date();
            this.WindowState = FormWindowState.Maximized;
        }
        public void Set_Date()
        {
            int[] this_month = date.Today();
            this.time = this_month[0] + "/" + this_month[1] + "/" + this_month[2];
            set_time();
        }
        private void set_time() {
            set_costs_zero();
            date_lb.Text = this.time;
            this.time = date_lb.GetText("yyyy/MM/dd");
            load_debts_of_months(this.time);
        }
        private void load_debts_of_months(string date)
        {
            string[] data = date.Split('/');
            string sql_query = $"SELECT * FROM debts WHERE date LIKE '%{data[0] + '/' + data[1]+'/'}%'";
            load_debts_to_list = debts_db.get_debts_datatable(sql_query);
        }
        private void Set_Style()
        {
            new Form_Styles().Style(this);
            new Style().Debts_List_Style(debts_list);
        }

        private void set_costs_zero()
        {
            string val = "0";
            cost_count = 0;
            power_cost = 0;
            water_cost = 0;
            gas_cost = 0;
            internet_cost = 0;
            tax_cost = 0;
            rent_cost = 0;
            prices_lb.Text = val;
            count_lb.Text = val;
            power_lb.Text = val;
            water_lb.Text = val;
            gas_lb.Text=val;
            internet_lb.Text= val;
            rent_lb.Text = val;
        }

        private void set_labels() {
            water_lb.Text = water_cost.ToString();
            power_lb.Text = power_cost.ToString();
            gas_lb.Text = gas_cost.ToString();
            internet_lb.Text = internet_cost.ToString();
            rent_lb.Text = rent_cost.ToString();
            count_lb.Text = cost_count.ToString();
        }
        private void add_prices(string name,int price)
        {
            cost_count++;
            costs += price;
            switch (name)
            {
                case "اب":water_cost+=price; break;
                case "برق":power_cost+=price; break;
                case "گاز":gas_cost+=price; break;
                case "اینترنت":internet_cost+=price; break;
                case "مالیات":tax_cost+=price; break;
                case "اجاره":rent_cost+=price; break;
                default:break;
            }
            set_labels();
        }
        DataTable load_debts_to_list
        {
            set
            {
                debts_list.Rows.Clear();
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Rows.Count - 1; i++)
                {
                    var d = value.Rows[i];
                    add_prices(d[1].ToString(), int.Parse(d[2].ToString()));
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(debts_list);
                    row.Cells[0].Value = counter;
                    row.Cells[1].Value = d[0];
                    row.Cells[2].Value = d[1];
                    row.Cells[3].Value = d[2];
                    row.Cells[4].Value = d[3];
                    row.Cells[5].Value = d[4];
                    row.Cells[6].Value = d[5];
                    row.Cells[7].Value = d[6];
                    rows.Add(row);
                    counter++;
                }
                debts_list.Rows.AddRange(rows.ToArray());
                debts_list.ClearSelection();
            }
        }
        Debt add_debt_to_list
        {
            set
            {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(debts_list);
                    row.Cells[0].Value = counter;
                    row.Cells[1].Value = value.id;
                    row.Cells[2].Value = value.name;
                    row.Cells[3].Value = value.price;
                    row.Cells[4].Value = value.date;
                    row.Cells[5].Value = value.description;
                    row.Cells[6].Value = value.bank_id;
                    row.Cells[7].Value = value.bank_name;
                    debts_list.Rows.Add(row);
                    counter++;
            }
        }

        private void next_day_bt_Click(object sender, System.EventArgs e)
        {
            int[] next_month = date.next_months(1, this.time);
            this.time = next_month[0] + "/" + next_month[1] + "/" + next_month[2];
            set_time();
        }

        private void previce_day_bt_Click(object sender, System.EventArgs e)
        {
            int[] next_month = date.next_months(-1, this.time);
            this.time = next_month[0] + "/" + next_month[1] + "/" + next_month[2];
            set_time();
        }

        private void add_item_bt_Click(object sender, System.EventArgs e)
        {
            int id = debts_db.get_last_debt_id()+1;
            using (Debts_Details screen = new Debts_Details(id))
            {
                screen.ShowDialog();
                if (screen.DialogResult == DialogResult.OK)
                {
                    add_debt_to_list = screen.return_debt;
                }
            }
        }

        private Debt selected_debt(int index)
        {
            DataGridViewCellCollection row = debts_list.Rows[index].Cells;
            return new Debt(
                int.Parse(row[1].Value.ToString()),
                row[2].Value.ToString(),
                decimal.Parse(row[3].Value.ToString()),
                row[4].Value.ToString(),
                row[5].Value.ToString(),
                int.Parse(row[6].Value.ToString()),
                row[7].Value.ToString()
                );
        }
        private void edite_debt_at_index(int index,Debt debt) {
            debts_list.Rows[index].Cells[2].Value = debt.name;
            debts_list.Rows[index].Cells[3].Value = debt.price;
            debts_list.Rows[index].Cells[4].Value = debt.date;
            debts_list.Rows[index].Cells[5].Value = debt.description;
            debts_list.Rows[index].Cells[6].Value = debt.bank_id;
            debts_list.Rows[index].Cells[6].Value = debt.bank_name;
        }

        private void delete_debt_at_index(int index)
        {
            debts_list.Rows.RemoveAt(index);
        }
        private void debts_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = int.Parse(debts_list.Rows[index].Cells[0].Value.ToString());
            Debt debt = selected_debt(index);
            using(Debts_Details screen = new Debts_Details(id, debt))
            {
                screen.ShowDialog();
                if(screen.DialogResult == DialogResult.OK)
                {
                    edite_debt_at_index(index,screen.return_debt);
                }else if(screen.DialogResult == DialogResult.Abort)
                {
                    delete_debt_at_index(index);
                }
            }
            set_time();
        }

        private void save_bt_Click(object sender, System.EventArgs e)
        {

        }
    }
}
