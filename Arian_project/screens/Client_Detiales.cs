using Arian_project.backend;
using Arian_project.Backend.styles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Clients_Detailes : Form
    {
        int selected_id = 0;
        public Clients_Detailes()
        {
            InitializeComponent();
            Clients_List.SelectionChanged += Clients_List_SelectionChanged;
            Clients_List.MultiSelect = false;
            Clients_List.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        int id = new Clients_database().clients_count() + 1;
        public DataTable CLients_List_Set
        {
            set
            {
                new Style().Clients_List_Style(Clients_List);
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Rows.Count - 1; i++)
                {
                    var d = value.Rows[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Clients_List);
                    row.Cells[0].Value = d[0];
                    row.Cells[1].Value = d[1];
                    row.Cells[2].Value = d[2];
                    row.Cells[3].Value = d[3];
                    row.Cells[4].Value = d[4];
                    row.Cells[5].Value = d[5];
                    row.Cells[6].Value = d[6];
                    row.Cells[7].Value = d[7];
                    rows.Add(row);
                }
                Clients_List.Rows.Clear();
                Clients_List.Rows.AddRange(rows.ToArray());
                Clients_List.ClearSelection();
                clear_data();
            }
        }
        private bool validate_inputs()
        {
            if (
            name_tb.Text == "" ||
            phone_number_tb.Text == "" ||
            home_phone_tb.Text == "" ||
            company_tb.Text == "" ||
            email_tb.Text == "" ||
            client_type_tb.Text == "" ||
            client_group_tb.Text == "")
            {
                return false;
            }
            return true;
        }
        private void save_client_bt_Click(object sender, System.EventArgs e)
        {
            if (validate_inputs()) { 
                string user_name = name_tb.Text;
                string phone_number = phone_number_tb.Text;
                string home_phone = home_phone_tb.Text;
                string company = company_tb.Text;
                string email = email_tb.Text;
                string client_type = client_type_tb.Text;
                string client_group = client_group_tb.Text;
                Client user = new Client(id, user_name, phone_number, home_phone, company, email, client_type, client_group);
                bool result = new Clients_database().insert_client_to_database(user);
                if (result)
                {
                    MessageBox.Show("کاربر با موفقیت ثبت شد", "افزودن کاربر");
                    clear_data();
                    Load_Clients_To_List();
                }
                else
                {
                    MessageBox.Show("هنگام ثبت کاربر مشکلی بوجود امده است", "افزودن کاربر");
                }
            }
            else
            {
                MessageBox.Show("لطفا تمام موراد را وارد کنید", "ورودی ها");
            }
        }
        private void clear_data()
        {
            name_tb.Clear();
            phone_number_tb.Clear();
            home_phone_tb.Clear();
            company_tb.Clear();
            email_tb.Clear();
            client_type_tb.SelectedIndex = 0;
            client_group_tb.Clear();
            selected_id = 0;
            Clients_List.ClearSelection();
        }
        private void edite_client_bt_Click(object sender, System.EventArgs e)
        {
            if (validate_inputs())
            {
                if (selected_id == 0)
                {
                    MessageBox.Show("یک کاربر را انتخاب کنید", "ویرایش کاربر");
                    return;
                }
                string user_name = name_tb.Text;
                string phone_number = phone_number_tb.Text;
                string home_phone = home_phone_tb.Text;
                string company = company_tb.Text;
                string email = email_tb.Text;
                string client_type = client_type_tb.Text;
                string client_group = client_group_tb.Text;
                Client user = new Client(selected_id, user_name, phone_number, home_phone, company, email, client_type, client_group);
                bool result = new Clients_database().edite_client_in_database(user);
                if (result)
                {
                    MessageBox.Show("کاربر با موفقیت ویرایش شد", "ویرایش کاربر");
                    clear_data();
                    Load_Clients_To_List();
                }
                else
                {
                    MessageBox.Show("هنگام ویرایش کاربر مشکلی بوجود امده است", "ویرایش کاربر");
                }
            }
        }
        private void delete_client_bt_Click(object sender, System.EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("یک کاربر را انتخاب کنید", "حذف کاربر");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا مطمئن هستید؟", "حذف کاربر", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                bool result = new Clients_database().delete_client_from_database(selected_id);
                if (result)
                {
                    MessageBox.Show("کاربر با موفقیت حذف شد", "حذف کاربر");
                    clear_data();
                    Load_Clients_To_List();
                }
                else
                {
                    MessageBox.Show("هنگام حذف کاربر مشکلی بوجود امده است", "حذف کاربر");
                }
            }
        }
        private void Load_Clients_To_List()
        {
            var users = new Clients_database().Clients_list();
            CLients_List_Set = users;
        }
        private void Clients_Detailes_Load(object sender, System.EventArgs e)
        {
            Load_Clients_To_List();
            client_type_tb.DataSource = new List<string> { "فروش", "خرید"};
        }
        private void Clients_List_SelectionChanged(object sender, EventArgs e)
        {
            if (Clients_List.SelectedRows.Count > 0)
            {
                var row = Clients_List.SelectedRows[0];
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "")
                {
                    selected_id = Convert.ToInt32(row.Cells[0].Value);
                    name_tb.Text = row.Cells[1].Value?.ToString();
                    phone_number_tb.Text = row.Cells[2].Value?.ToString();
                    home_phone_tb.Text = row.Cells[3].Value?.ToString();
                    company_tb.Text = row.Cells[4].Value?.ToString();
                    email_tb.Text = row.Cells[5].Value?.ToString();
                    client_type_tb.Text = row.Cells[6].Value?.ToString();
                    client_group_tb.Text = row.Cells[7].Value?.ToString();
                }
            }
        }
    } 
}

