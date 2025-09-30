
using Arian_project.Backend;
using Arian_project.Backend.Database;
using Arian_project.Backend.styles;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class User_Control_Screen : Form
    {
        Users_database users_db = new Users_database();
        int id = 0;
        int last_id = 0;
        int counter = 1;
        public User_Control_Screen()
        {
            InitializeComponent();
            set_style();
            load_data();
        }

        public DataTable users_list_Set
        {
            set
            {
                users_list.Rows.Clear();
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Rows.Count - 1; i++)
                {
                    var d = value.Rows[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(users_list);
                    row.Cells[0].Value = counter;
                    row.Cells[1].Value = d[0];
                    row.Cells[2].Value = d[1];
                    row.Cells[3].Value = d[2];
                    row.Cells[4].Value = d[3];
                    counter ++;
                    rows.Add(row);
                }
                users_list.Rows.AddRange(rows.ToArray());
                users_list.ClearSelection();

            }
        }
        private void set_style() {
            new Style().Users_List_Style(users_list);
            users_list.AllowUserToAddRows = false;
            users_list.Refresh();
            new Form_Styles().Style(this);
        }
        private string get_access()
        {
            string access = "";
            access += cb_service.Checked? '1' : '0';
            access += cb_banks.Checked ? '1' : '0';
            access += cb_card_readers.Checked ? '1' : '0';
            access += cb_add_buy_factor.Checked ? '1' : '0';
            access += cb_edite_buy_factor.Checked ? '1' : '0';
            access += cb_add_cell_factor.Checked ? '1' : '0';
            access += cb_edite_cell_factor.Checked ? '1' : '0';
            access += cb_installment_pay.Checked ? '1' : '0';
            access += cb_installment_edite.Checked ? '1' : '0';
            access += cb_users.Checked ? '1' : '0';
            access += cb_stores.Checked ? '1' : '0';
            access += cb_debts.Checked ? '1' : '0';
            access += cb_print.Checked ? '1' : '0';
            return access;
        }

        private void rest_access()
        {
            cb_service.Checked = false; 
            cb_banks.Checked = false; 
            cb_card_readers.Checked = false; 
            cb_add_buy_factor.Checked = false; 
            cb_edite_buy_factor.Checked = false; 
            cb_add_cell_factor.Checked = false; 
            cb_edite_cell_factor.Checked = false; 
            cb_installment_pay.Checked = false; 
            cb_installment_edite.Checked = false; 
            cb_users.Checked = false; 
            cb_stores.Checked = false;
            cb_debts.Checked = false; 
            cb_print.Checked = false; 
        }
        private void set_access(string access)
        {
            if(access[0] == '1') { cb_service.Checked = true; } else { cb_service.Checked = false; }
            if(access[1] == '1') { cb_banks.Checked = true; } else { cb_banks.Checked = false; }
            if(access[2] == '1') { cb_card_readers.Checked = true; } else { cb_card_readers.Checked = false; }
            if(access[3] == '1') { cb_add_buy_factor.Checked = true; } else { cb_add_buy_factor.Checked = false; }
            if(access[4] == '1') { cb_edite_buy_factor.Checked = true; } else { cb_edite_buy_factor.Checked = false; }
            if(access[5] == '1') { cb_add_cell_factor.Checked = true; } else { cb_add_cell_factor.Checked = false; }
            if(access[6] == '1') { cb_edite_cell_factor.Checked = true; } else { cb_edite_cell_factor.Checked = false; }
            if(access[7] == '1') { cb_installment_pay.Checked = true; } else { cb_installment_pay.Checked = false; }
            if(access[8] == '1') { cb_installment_edite.Checked = true; } else { cb_installment_edite.Checked = false; }
            if(access[9] == '1') { cb_users.Checked = true; } else { cb_users.Checked = false; }
            if(access[10] == '1') { cb_stores.Checked = true; } else { cb_stores.Checked = false; }
            if(access[11] == '1') { cb_debts.Checked = true; } else { cb_debts.Checked = false; }
            if(access[12] == '1') { cb_print.Checked = true; } else { cb_print.Checked = false; }
        }
        private void load_data()
        {
            users_list_Set = users_db.get_users_datatable(); 
            this.id = users_db.get_last_admin_id()+1;
            this.last_id = this.id;
            save_bt.Text = "ذخیره";
            usernmae_tb.Text = "";
            pass_word_tb.Text = "";
            rest_access();
            counter = 1;

        }
        private Admin get_selected_user()
        {

            if (users_list.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection data = users_list.SelectedRows[0].Cells;
                Admin user = new Admin(
                    int.Parse(data[1].Value.ToString()),
                    data[2].Value.ToString(),
                    data[3].Value.ToString(),
                    data[4].Value.ToString()
                    );

                usernmae_tb.Text = user.username;
                pass_word_tb.Text = user.password;
                return user;
            }
            else
            {
                return Admin.Empty();
            }

        } 
        
        private void users_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Admin user = get_selected_user();
            if(user.id > 0)
            {
                this.id = user.id;
                save_bt.Text = "ویرایش";
                set_access(user.access);
            }
        }

        private void back_bt_Click(object sender, System.EventArgs e)
        {
            if(this.id != this.last_id)
            {
                load_data();
            }
            else
            {
                this.Close();
            }

        }

        private void usernmae_tb_TextChanged(object sender, System.EventArgs e)
        {
            if (usernmae_tb.Text != "")
            {
                back_bt.Text = "ریست";
                if (this.id != this.last_id) { 
                    save_bt.Text = "ویرایش";
                }
            }
            else
            {
                save_bt.Text = "ذخیره";
                back_bt.Text = "بازگشت";
            }
            this.Refresh();
            this.Refresh();
        }

        private void save_bt_Click(object sender, System.EventArgs e)
        {
            if (this.id == this.last_id) {
                Admin user = new Admin(
                    this.id,
                    usernmae_tb.Text,
                    pass_word_tb.Text,
                    get_access()
                    );
                bool result = users_db.insert_user_in_database(user);
                if (result) {
                    MessageBox.Show("کاربر با موفقیت ثبت شد", "افزودن کاربر");
                }
                else
                {
                    MessageBox.Show("هنگام ذخیره کاربر مشکلی بوحود امده است", "افزودن کاربر");
                }
            }
            else
            {
                Admin user = new Admin(
                    this.id,
                    usernmae_tb.Text,
                    pass_word_tb.Text,
                    get_access()
                    );
                bool result = users_db.edite_user_in_database(user);
                if (result) {
                    MessageBox.Show("کاربر با موفیت ویرایش شد", "ویرایش کاربر");
                }
                else { 
                    MessageBox.Show("هنگام ویرایش کاربر مشکلی بوحود امده است", "ویرایش کاربر");
                }
            }
        }

        private void delete_bt_Click(object sender, System.EventArgs e)
        {
            Admin user = get_selected_user();
            if(user.id > 0)
            {
                Button yesbt = new Button();
                Button nbt = new Button();
                yesbt.Text = "بله";
                nbt.Text = "خیر";
                Button[] buttons = { yesbt, nbt };
                using(PMessageBox screen = new PMessageBox("حذف کاربر","می خواهید این کاربر را حذف کنید",buttons)){
                    if(screen.result == yesbt)
                    {
                        bool result =users_db.delete_user_from_database(user.id);
                        if (result) {
                            MessageBox.Show("کاربر با موفقیت حذف شد", "حذف کاربر");
                        }
                        else
                        {
                            MessageBox.Show("هنگام حذف کاربر مشکلی بوحود امده است", "حذف کاربر");
                        }
                    }
                }
            }
        }
    }
}
