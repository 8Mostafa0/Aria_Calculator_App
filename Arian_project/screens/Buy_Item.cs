using Arian_project.Backend;
using Arian_project.Backend.styles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Buy_Item : Form
    {
        public Buy_Item()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Load_Screen();
        }
        private void Load_Screen()
        {
            Set_Style();
            Set_Factor_id();
            set_date();
        }
        private void set_date()
        {
            iran_date date = new iran_date();
            int[] today_date = date.Today();
            string string_date = today_date[0].ToString() + "/" + today_date[1].ToString() + "/" + today_date[2].ToString();
            Date_lb.Text = string_date;
        }
        private void Set_Factor_id()
        {
            factors_database db = new factors_database();
            Factor_id_lb.Text = (db.factors_counter() + 1).ToString();
        }
        private void textBox2_Click(object sender, System.EventArgs e)
        {
            using (Chouse_Client screen = new Chouse_Client()) { 
                screen.ShowDialog();
                try
                {
                    Client user = screen.ReturnClient;
                    if (user != null) { 
                        Client_Name_tb.Text = user.user_name;
                        Client_phone_tb.Text = user.phone_number;
                    }
                }catch(Exception _)
                {

                }
            }
        }

        private void Set_Style()
        {
            new Style().Store_Items_List(list_items);
        }
        private bool item_exist_in_list(int item_id) {
            if(list_items.Rows.Count > 1)
            {
                foreach (DataGridViewRow i in list_items.Rows) { 
                    if(i.Cells[0].Value != null)
                    {
                        if(int.Parse(i.Cells[0].Value.ToString()) == item_id)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void add_item_to_list(Store item)
        {
            if (!item_exist_in_list(item.id))
            {

                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(list_items);
                row.Cells[0].Value = item.id;
                row.Cells[1].Value = item.store_id;
                row.Cells[2].Value = item.item_name;
                row.Cells[3].Value = item.buy_price;
                row.Cells[4].Value = "0";
                row.Cells[5].Value = "0";
                row.Cells[6].Value = item.buy_date;
                row.Cells[7].Value = item.cell_date;
                row.Cells[8].Value = item.service_item;
                row.Cells[9].Value = "0";
                rows.Add(row);
                list_items.Rows.AddRange(rows.ToArray());
                list_items.ClearSelection();
            }
            else
            {
                MessageBox.Show("این ایتم در لیست موجود است", "ایتم انتخاب شده");
            }
        }
        private void list_items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                using (Chouse_Item screen = new Chouse_Item()) { 
                    screen.ShowDialog();
                    Store item = screen.selected_item;
                    if (item != null) { 
                        add_item_to_list(item);
                    }
                }
            }
        }

        private void list_items_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (list_items.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null&& list_items.Rows[e.RowIndex].Cells[4].Value != null&& list_items.Rows[e.RowIndex].Cells[5].Value != null)
            {
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    try
                    {
                        int price = int.Parse(list_items.Rows[e.RowIndex].Cells[4].Value.ToString());
                        int count = int.Parse(list_items.Rows[e.RowIndex].Cells[5].Value.ToString());

                        int full_price = price * count;
                        list_items.Rows[e.RowIndex].Cells[9].Value = full_price;
                    }
                    catch { }
                }
            }
        }
    }
}
