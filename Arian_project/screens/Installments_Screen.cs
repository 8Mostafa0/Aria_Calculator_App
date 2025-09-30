using Arian_project.Backend;
using Arian_project.Backend.Database;
using Arian_project.Backend.styles;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Installments_Screen : Form
    {
        Client_installment_database c_installment_db = new Client_installment_database();
        public Installments_Screen()
        {
            InitializeComponent();
            Set_Style();
            set_installment_list_type();
        }
        
        private void Set_Style() {
            new Form_Styles().Style(this);
            new Style().Installments_list_style(Installments_List);
        }

        DataTable Set_Installment_List
        {
            set
            {
                Installments_List.Rows.Clear();
                    List<DataGridViewRow> rows = new List<DataGridViewRow>();
                    for (int i = 0; i <= value.Rows.Count - 1; i++)
                    {
                        var d = value.Rows[i];
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Installments_List);
                        row.Cells[0].Value = d[0];
                        row.Cells[1].Value = d[1];
                        row.Cells[2].Value = d[2];
                        row.Cells[3].Value = d[3];
                        row.Cells[4].Value = d[4];
                        row.Cells[5].Value = d[5];
                        row.Cells[6].Value = d[6];
                        row.Cells[7].Value = d[7];
                        row.Cells[8].Value = d[8];
                        row.Cells[9].Value = bool.Parse(d[9].ToString())?"بله":"خیر";
                        row.Cells[10].Value = d[10];
                        row.Cells[11].Value = d[11];
                        row.Cells[12].Value = d[12];
                    rows.Add(row);
                    }
                Installments_List.Rows.AddRange(rows.ToArray());
                Installments_List.ClearSelection();
                }
        }
        private void Load_Data() {
            Set_Installment_List = c_installment_db.get_client_installment_datatable();
        }

        private void set_installment_list_type()
        {
            List<string> list = new List<string>()
            {
                "همه",
                "بدهکاران",
                "اتمام شده",
                "اتمام شده",
            };
            Installment_list_type_cb.DataSource = list;
            Installment_list_type_cb.SelectedIndex = 1;
        }
        private bool Verify_Client_And_Inputs()
        {
            bool result = false;
            return result;
        }
        private void Search_In_List_With_Name_or_Status(string status,string name = "") { }

        private void Installment_list_type_cb_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (Installment_list_type_cb.Text != "")
            {
                string status = Installment_list_type_cb.Text;
                string sql_query = "";
                if (status == "همه")
                {
                    sql_query = "SELECT * FROM client_installments";
                }
                else if(status == "بدهکاران")
                {
                    sql_query = $"SELECT * FROM client_installments WHERE status='بدهکار' and end_installment='خیر'";
                }else if(status == "اتمام شده") { 
                    sql_query = $"SELECT * FROM client_installments WHERE end_installment='بله'";
                }else if(status == "اتمام نشده")
                {
                    sql_query = $"SELECT * FROM client_installments WHERE end_installment='خیر'";
                }
                Set_Installment_List = c_installment_db.get_client_installment_datatable(sql_query);
            }
            else
            {
                MessageBox.Show("لطفا نوع لیست را از گزینه ها انتخاب کنید","نوع لیست");
            }
        }

        private void Name_tb_TextChanged(object sender, System.EventArgs e)
        {
            if(Name_tb.Text != "")
            {
                Search_refrech_bt.Text = "جستجو";
            }
            else
            {
                Search_refrech_bt.Text = "ریست";
            }
                Search_refrech_bt.Refresh();
        }

        private void Search_name(string name) {
            string sql_query = $"SELECT * FROM client_installments WHERE client_name LIKE '%{name}%' OR client_name='{name}'";
            Set_Installment_List = c_installment_db.get_client_installment_datatable(sql_query);
        }

        private void Search_refrech_bt_Click(object sender, System.EventArgs e)
        {
            if(Name_tb.Text != "")
            {
                Load_Data();
            }
            else
            {
                Search_name(Name_tb.Text);
            }
        }

        private Client_Installment Get_Selected_installment()
        {
            Client_Installment installment = Client_Installment.Create_empty();
            if (Installments_List.SelectedRows.Count > 0)
            {
                var row = Installments_List.SelectedRows[0].Cells;
                int id = int.Parse(row[0].Value.ToString());
                int client_id = int.Parse(row[1].Value.ToString());
                string client_name = row[2].Value.ToString();
                int factor_id = int.Parse(row[3].Value.ToString());
                decimal installment_price = decimal.Parse(row[4].Value.ToString());
                string first_installment = row[5].Value.ToString();
                decimal one_installment_price = decimal.Parse(row[6].Value.ToString());
                int installment_count = int.Parse(row[7].Value.ToString());
                int installment_payed_count = int.Parse(row[8].Value.ToString());
                bool end_installment = row[9].Value.ToString() == "بله" ?true:false;
                int next_reminder = int.Parse(row[10].Value.ToString());
                int sms_days = int.Parse(row[11].Value.ToString());
                string status = row[12].Value.ToString();
                installment = new Client_Installment(
                    id,
                    client_id,
                    client_name,
                    factor_id,
                    installment_price,
                    first_installment,
                    one_installment_price,
                    installment_count,
                    installment_payed_count,
                    end_installment,
                    next_reminder,
                    sms_days,
                    status
                    );

            }
            return installment;
        }
        private void Details_bt_Click(object sender, System.EventArgs e)
        {
            Client_Installment installment = Get_Selected_installment();
            if(installment.id != 0)
            {
                new Installment_Detailes(installment).ShowDialog();
                Load_Data();
            }
            else
            {
                MessageBox.Show("لطفا ابتدا موردی را از لیست انتخاب کنید", "جزئیات حساب");
            }
        }

        private void Reminder_bt_Click(object sender, System.EventArgs e)
        {
            if(Reminder_bt.Text != "")
            {
                Client_Installment installment = Get_Selected_installment();
                if(installment.id != 0){

                    int next_reminder = int.Parse(Reminder_bt.Text);
                    if (next_reminder > 0) { 
                        installment.next_reminder = next_reminder;
                        bool result = c_installment_db.update_client_installment_to_database(installment);
                        if (result) {
                            MessageBox.Show($"یاد اوری اقساط {installment.client_name} به {installment.next_reminder} روز بعد قرار داده شد", "یاداوری");
                        }
                        else
                        {
                            MessageBox.Show("", "یاداوری");
                        }
                    }
                }else
                {
                    MessageBox.Show("لطفا ابتدا موردی را از لیست انتخاب کنید", "یاداوری");
                }
            }
            else
            {
                MessageBox.Show("لطفا عددی را برای یاداوری بعدی وارد کنید", "یاداوری");
            }

        }

        private void Pay_bt_Click(object sender, System.EventArgs e)
        {
            Client_Installment installment = Get_Selected_installment();
            if(installment.id != 0)
            {
                
            }
        }

        private void Installments_Screen_Load(object sender, System.EventArgs e)
        {

            Load_Data();
        }
    }
}
