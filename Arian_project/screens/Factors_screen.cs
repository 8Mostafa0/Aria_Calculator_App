using Arian_project.Backend;
using Arian_project.Backend.styles;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Factors_screen : Form
    {

        public Factors_database factor_db = new Factors_database();
        public Factors_screen()
        {
            InitializeComponent();
            set_style();
            load_all_factors();
        }

        DataTable Set_factor_list
        {
            set
            {
                factor_list.Rows.Clear();
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Rows.Count - 1; i++)
                {
                    var d = value.Rows[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(factor_list);
                    row.Cells[0].Value = d[0];
                    row.Cells[1].Value = d[1];
                    row.Cells[2].Value = d[2];
                    row.Cells[3].Value = d[3];
                    row.Cells[4].Value = d[4];
                    row.Cells[5].Value = d[5];
                    row.Cells[6].Value = d[6];
                    row.Cells[7].Value = d[7];
                    row.Cells[8].Value = d[8];
                    row.Cells[9].Value = d[9];
                    rows.Add(row);
                }
                factor_list.Rows.AddRange(rows.ToArray());
                factor_list.ClearSelection();
            }
        }
        private void load_all_factors()
        {
            Set_factor_list = factor_db.Factors_list();
        }
        private void set_style()
        {
            new Style().Factor_list_style(factor_list);
            new Form_Styles().Style(this);
        }

        private void Get_factors_list_base_on_pay_status(string status)
        {
            string sql_query = $"SELECT * FROM factors WHERE factor_status='{status}' OR factor_status LIKE '%{status}%'";
            Set_factor_list = factor_db.Factors_list(sql_query);
        }
        private void glassButton2_Click(object sender, System.EventArgs e)
        {
            Get_factors_list_base_on_pay_status("پرداخت نشده");
        }

        private void glassButton3_Click(object sender, System.EventArgs e)
        {
            Get_factors_list_base_on_pay_status("پرداخت شده");
        }

        private void factor_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void glassButton4_Click(object sender, System.EventArgs e)
        {

            Get_factors_list_base_on_pay_status("اقساطی");
        }

        private void glassButton5_Click(object sender, System.EventArgs e)
        {
            
            Get_factors_list_base_on_pay_status("اقساطی اتمام نشده");
        }

        private void all_factors_bt_Click(object sender, System.EventArgs e)
        {
            string sql_query = "SELECT * FROM factors";
            Set_factor_list = factor_db.Factors_list(sql_query);
        }

        private void edite_facctor_bt_Click(object sender, System.EventArgs e)
        {
            if (factor_list.SelectedRows.Count > 0) {
                DataGridViewCellCollection row = factor_list.SelectedRows[0].Cells;

                int id = int.Parse(row[0].Value.ToString());
                int client_id = int.Parse(row[1].Value.ToString());
                string client_user_name = row[2].Value.ToString();
                string factor_type = row[3].Value.ToString();
                decimal full_price =decimal.Parse(row[4].Value.ToString());
                decimal profit = decimal.Parse(row[5].Value.ToString());
                decimal payed_price = decimal.Parse(row[6].Value.ToString());
                string factor_date = row[7].Value.ToString();
                string client_group = row[8].Value.ToString();
                string factor_status = row[9].Value.ToString();
                Factor factor =  new Factor(id,client_id,client_user_name,factor_type,full_price,profit,payed_price,factor_date,client_group,factor_status);
                using(Edite_Factors screen = new Edite_Factors(factor))
                {
                    screen.ShowDialog();
                    Set_factor_list = factor_db.Factors_list();
                }

            }
        }

        private void glassButton1_Click(object sender, System.EventArgs e)
        {
            Get_factors_list_base_on_pay_status("اقساطی اتمام شده");
        }
    }
}
