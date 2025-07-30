using Arian_project.backend;
using Arian_project.Backend.Database;
using Arian_project.Backend.styles;
using ghest.Backend.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Banks : Form
    {
        public Banks()
        {
            InitializeComponent();
            var backend = new Database_data();
            backend.check_directorys();
            load_data_to_list();
        }
        log logger = new log();
        banks_database bank_db = new banks_database();
        int select_id = 0;
        string logger_message_type = "مدیریت حساب";
        public DataTable Banks_List_Set
        {

            set
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Rows.Count - 1; i++)
                {
                    var d = value.Rows[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(banks_list);
                    row.Cells[0].Value = d[0];
                    row.Cells[1].Value = d[1];
                    row.Cells[2].Value = d[2];
                    row.Cells[3].Value = d[3];
                    rows.Add(row);
                }
                banks_list.Rows.AddRange(rows.ToArray());
                banks_list.ClearSelection();
            }
        }
        private void bank_type_cb_items()
        {
            List<string> data = bank_db.get_bank_types();
            bank_type_cb.DataSource = data;
        }
        private void load_data_to_list()
        {

            new Style().Banks_List_Style(banks_list);
            banks_list.Rows.Clear();
            DataTable banks = new banks_database().Banks_list();
            Banks_List_Set = banks;
            select_id = bank_db.banks_count() + 1;

        }
        private void clear_data()
        {
            name_tb.Text = "";
            balance_tb.Text = "";
            bank_type_cb_items();
            bank_type_cb.SelectedIndex = 0;
        }
        private void save_bt_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                try
                {
                    string message_type = "افزودن حساب";
                    int id = select_id;
                    string name = name_tb.Text;
                    string bank_type = bank_type_cb.Text;
                    int balance = Convert.ToInt32(balance_tb.Text);
                    Bank bank = new Bank(id, name, bank_type,balance);
                    bool res = bank_db.insert_bank_to_database(bank);
                    if (res)
                    {
                        MessageBox.Show("حساب با موفقیت افزوده شد", message_type);
                        load_data_to_list();
                        clear_data();
                    }
                    else
                    {
                        MessageBox.Show("هنگام افزودن حساب مشکلی پیش امده است", message_type);
                    }
                }catch(Exception ex){
                    logger.record_log("save bt in banks screen : "+ex, logger_message_type);
                }
            }
            
        }
        private bool validate_data()
        {
            string message_type = "مقدار ورودی ها";
            if (name_tb.Text == "")
            {
                MessageBox.Show("لطفا نام حساب را وارد کنید",message_type);
                return false;
            }
            if (balance_tb.Text == "")
            {
                MessageBox.Show("لطفا موجودی حساب را وارد کنید", message_type);
                return false;
            }
            if(bank_type_cb.Text == "")
            {
                MessageBox.Show("لطفا نوع حساب را وارد کنید", message_type);
                return false;
            }
            return true;
        }
        private void reset_bt_Click(object sender, EventArgs e)
        {
            load_data_to_list();
            clear_data();
        }
        private void SelectRowAndFillFields(int id)
        {
            if (id < 0)
                return;
            clear_data();
            var row = banks_list.Rows[id];
            select_id = Convert.ToInt32(row.Cells[0].Value);
            name_tb.Text = row.Cells[1].Value.ToString();
            balance_tb.Text = row.Cells[3].Value.ToString();
            bank_type_cb.Text = row.Cells[2].Value.ToString();
        }
        private void banks_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowAndFillFields(e.RowIndex);
        }

        private void edite_bt_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {

                string message_type = "ویرایش حساب";
                int id = select_id;
                string name = name_tb.Text;
                string bank_type = bank_type_cb.Text;
                int balance = Convert.ToInt32(balance_tb.Text);
                Bank bank = new Bank(id, name, bank_type, balance);
                bool res = bank_db.edite_bank_in_database(bank);
                if (res)
                {
                    MessageBox.Show("ویرایش حساب با موفقیت انجام شد", message_type);
                    load_data_to_list();
                    clear_data();
                }
                else
                {
                    MessageBox.Show("هنگام ویرایش حساب مشکلی بوجود امده است", message_type);

                }
            }
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                if(select_id > 0)
                {
                    string message_type = "حذف حساب";
                    bool res = bank_db.delete_bank_from_database(select_id);
                    if (res)
                    {

                        MessageBox.Show("حذف حساب با موفقیت انجام شد", message_type);
                        load_data_to_list();
                        clear_data();
                    }
                    else
                    {
                        MessageBox.Show("هنگام حذف حساب مشکلی بوجود امده است",message_type);
                    }
                }
            }
        }
    }
}
