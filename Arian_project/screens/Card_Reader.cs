using Arian_project.Backend;
using Arian_project.Backend.Database;
using Arian_project.Backend.styles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Card_Readers : Form
    {
        public Card_Readers()
        {
            InitializeComponent();
            load_items_to_list();
        }
        card_reader_database card_reader_db = new card_reader_database();
        banks_database bank_db = new banks_database();
        int select_id = 0;
        private void load_items_to_list()
        {
            select_id = card_reader_db.get_last_card_reader_id() + 1;
            clear_data();
            Card_Reader_List_Set = card_reader_db.card_readers_list();
            set_bank_id_cb();

        }
        private DataTable Card_Reader_List_Set
        {
            set
            {

                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Rows.Count - 1; i++)
                {
                    var d = value.Rows[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(card_reader_list);
                    row.Cells[0].Value = d[0];
                    string bank_name = bank_db.get_bank_data_by_id(Convert.ToInt32(d[1])).name;
                    row.Cells[1].Value = bank_name;
                    row.Cells[2].Value = d[2];
                    rows.Add(row);
                }
                card_reader_list.Rows.AddRange(rows.ToArray());
                card_reader_list.ClearSelection();

            }
        }

        private void set_bank_id_cb()
        {
            List<string> data = bank_db.get_bank_name();
            bank_id_cb.DataSource = data;
        }

        private void clear_data()
        {
            name_tb.Text = "";
            bank_id_cb.Text = "";
            new Style().Card_Reader_List_Style(card_reader_list);
        }
        private void SelectRowAndFillFields(int id)
        {
            var row = card_reader_list.Rows[id];
            select_id = Convert.ToInt32(row.Cells[0].Value);
            name_tb.Text = row.Cells[2].Value.ToString();
            bank_id_cb.Text = row.Cells[1].Value.ToString();
        }
        private bool validate_data()
        {
            string message_type = "ورودی های کارتخوان";
            if(name_tb.Text == "")
            {
                MessageBox.Show("لطفا نام کارتخوان را انتخاب کنید",message_type);
                return false;
            }
            if(bank_id_cb.Text == "")
            {
                MessageBox.Show("لطفا بانک متصل را انتخاب کنید",message_type);
                return false;
            }
            return true;
        }
        private void save_bt_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                string message_type = "ذخیره کارتخوان";
                int id = card_reader_db.get_last_card_reader_id();
                string name = name_tb.Text;
                string bank_name = bank_id_cb.Text;
                int bank_id = Convert.ToInt32(bank_db.get_bank_data_by_name(bank_name).id);
                Card_Reader card_reader = new Card_Reader(id, name, bank_id);
                bool res = card_reader_db.insert_card_reader_to_database(card_reader);
                if (res)
                {
                    MessageBox.Show("ذخیره کارتخوان با موفقیت انجام شد",message_type);
                    clear_data();
                    load_items_to_list();
                    set_bank_id_cb();
                }
                else
                {
                    MessageBox.Show("هنگام ذخیره کارتخوان مشکلی بوجود امده است",message_type);
                }
            }
        }

        private void card_reader_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowAndFillFields(e.RowIndex);
        }

        private void edite_bt_Click(object sender, EventArgs e)
        {
            if (validate_data()) {
                string message_type = "ویرایش کارتخوان";
                int id = select_id;
                if(id > 0 || select_id == card_reader_db.get_last_card_reader_id())
                {
                    string name = name_tb.Text;
                    string bank_name = bank_id_cb.Text;
                    int bank_id = Convert.ToInt32(bank_db.get_bank_data_by_name(bank_name).id);
                    Card_Reader card_reader = new Card_Reader(id, name, bank_id);
                    bool res = card_reader_db.edite_card_reader_in_database(card_reader);
                    if (res) {
                        MessageBox.Show("ویرایش کارتخوان با موفقیت انجام شد", message_type);
                        clear_data();
                        load_items_to_list();
                        set_bank_id_cb();
                    }
                    else
                    {
                        MessageBox.Show("هنگام ویرایش کارتخوان مشکلی بوجود امده است", message_type);
                    }
                }
                
            }
        }

        private void reset_bt_Click(object sender, EventArgs e)
        {
            clear_data();
            load_items_to_list();
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            string message_type = "حذف کارتخوان";
            if(select_id > 0 || select_id == card_reader_db.get_last_card_reader_id())
            {
                bool result = card_reader_db.delete_card_reader_from_database(select_id);
                if (result)
                {
                    MessageBox.Show("حذف کارتخوان با موفقیت انجام شد",message_type);
                    clear_data();
                    load_items_to_list();
                }
                else
                {
                    MessageBox.Show("هنگام حذف کارتخوان مشکلی بوجود امده است",message_type);
                }
            }
            else
            {
                MessageBox.Show("لطفا ابتدا موردی برای حذف انتخاب کنید",message_type);
            }
        }
    }
}
