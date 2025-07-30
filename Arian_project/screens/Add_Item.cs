using System;
using System.Windows.Forms;
using Arian_project.Backend;
using System.Collections.Generic;
using Arian_project.Backend.styles;
using ghest.Backend.Logs;

namespace Arian_project.screens
{
    public partial class Add_Item : Form
    {
        int selected_id = 0;
        log logger = new log();
        string logger_message_type = "Add_Item Screen";
        public Add_Item()
        {
            InitializeComponent();
            Add_Item_Load();
        }

        private void SelectRowAndFillFields(int id)
        {
            try
            {

                if (items_list.Rows.Count == 0 || id < 0)
                    return;
                var row = items_list.Rows[id];
                store_id_tb.Text = row.Cells[1]?.Value?.ToString() ?? "";
                item_name_tb.Text = row.Cells[2]?.Value?.ToString() ?? "";
                buy_price_tb.Text = row.Cells[3]?.Value?.ToString() ?? "";
                cell_price_tb.Text = row.Cells[4]?.Value?.ToString() ?? "";
                count_tb.Text = row.Cells[5]?.Value?.ToString() ?? "";
                buy_date_tb.Text = row.Cells[6]?.Value?.ToString() ?? "";
                cell_date_tb.Text = row.Cells[7]?.Value?.ToString() ?? "";
                service_item_cb.Checked = row.Cells[8]?.Value != null && (row.Cells[8].Value.ToString().ToLower() == "بله" || row.Cells[8].Value.ToString() == "1");
                if (row.Cells[0]?.Value != null)
                {
                    selected_id = Convert.ToInt32(row.Cells[0]?.Value);
                }
                else
                {
                    selected_id = 0;
                }
            }
            catch (Exception ex)
            {
                logger.record_log(ex.ToString(), logger_message_type);
            }
        }

        private void Add_Item_Load()
        {
            clear_data();
            new Style().Stores_List_Style(items_list);
            Load_Items_To_List();
        }
        private void save_item_bt_Click(object sender, EventArgs e)
        {
            int store_id = 0;
            int.TryParse(store_id_tb.Text, out store_id);
            string item_name = item_name_tb.Text;
            int buy_price = 0;
            int.TryParse(buy_price_tb.Text, out buy_price);
            int cell_price = 0;
            int.TryParse(cell_price_tb.Text, out cell_price);
            int count = 0;
            int.TryParse(count_tb.Text, out count);
            string buy_date = buy_date_tb.Text;
            string cell_date = cell_date_tb.Text;
            string service_item = service_item_cb.Checked?"بله":"خیر";
            Store store = new Store(0, store_id, item_name, buy_price, cell_price, count, buy_date, cell_date, service_item);
            bool result = new stores_database().insert_service_to_database(store);
            if (result)
            {
                MessageBox.Show("آیتم با موفقیت ثبت شد", "افزودن آیتم");
                clear_data();
                Load_Items_To_List();
            }
            else
            {
                MessageBox.Show("هنگام ثبت آیتم مشکلی بوجود امده است", "افزودن آیتم");
            }
        }
        private void clear_data()
        {
            store_id_tb.Clear();
            item_name_tb.Clear();
            buy_price_tb.Clear();
            cell_price_tb.Clear();
            count_tb.Clear();
            buy_date_tb.Clear();
            cell_date_tb.Clear();
            service_item_cb.Checked = false;
            selected_id = 0;
            items_list.ClearSelection();
        }
        private void Load_Items_To_List()
        {
            items_list.Rows.Clear();
            items_list.Columns.Clear();
            items_list.Columns.Add("id", "شناسه");
            items_list.Columns.Add("store_id", "کد فروشگاه");
            items_list.Columns.Add("item_name", "نام آیتم");
            items_list.Columns.Add("buy_price", "قیمت خرید");
            items_list.Columns.Add("cell_price", "قیمت فروش");
            items_list.Columns.Add("count", "تعداد");
            items_list.Columns.Add("buy_date", "تاریخ خرید");
            items_list.Columns.Add("cell_date", "تاریخ فروش");
            items_list.Columns.Add("service_item", "آیتم خدماتی");

            List<Store> items = new stores_database().stores_list();
            selected_id = 0;
            foreach (var item in items)
            {
                items_list.Rows.Add(item.id, item.store_id, item.item_name, item.buy_price, item.cell_price, item.count, item.buy_date, item.cell_date, item.service_item);
            }
            items_list.ClearSelection();
        }
        private void edit_item_bt_Click(object sender, EventArgs e)
        {
            if (selected_id == 0 || items_list.SelectedRows.Count == 0)
            {
                MessageBox.Show("یک آیتم را انتخاب کنید", "ویرایش آیتم");
                return;
            }
            int store_id = 0;
            int.TryParse(store_id_tb.Text, out store_id);
            string item_name = item_name_tb.Text;
            int buy_price = 0;
            int.TryParse(buy_price_tb.Text, out buy_price);
            int cell_price = 0;
            int.TryParse(cell_price_tb.Text, out cell_price);
            int count = 0;
            int.TryParse(count_tb.Text, out count);
            string buy_date = buy_date_tb.Text;
            string cell_date = cell_date_tb.Text;
            string service_item = service_item_cb.Checked ? "بله" : "خیر";
            Store store = new Store(selected_id, store_id, item_name, buy_price, cell_price, count, buy_date, cell_date, service_item);
            bool result = new stores_database().edite_stor_in_datebase(store);
            if (result)
            {
                MessageBox.Show("آیتم با موفقیت ویرایش شد", "ویرایش آیتم");
                clear_data();
                Load_Items_To_List();
            }
            else
            {
                MessageBox.Show("هنگام ویرایش آیتم مشکلی بوجود امده است", "ویرایش آیتم");
            }
        }
        private void delete_item_bt_Click(object sender, EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("یک آیتم را انتخاب کنید", "حذف آیتم");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا مطمئن هستید؟", "حذف آیتم", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                bool result = new stores_database().delete_stor_from_database(selected_id);
                if (result)
                {
                    MessageBox.Show("آیتم با موفقیت حذف شد", "حذف آیتم");
                    clear_data();
                    Load_Items_To_List();
                }
                else
                {
                    MessageBox.Show("هنگام حذف آیتم مشکلی بوجود امده است", "حذف آیتم");
                }
            }
        }

        private void items_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(e.RowIndex);
                SelectRowAndFillFields(id);
            }catch(Exception ex){
                logger.record_log("Click on list Error : " + ex.ToString(), logger_message_type);
            }
        }

        private void Reset_bt_Click(object sender, EventArgs e)
        {
            Add_Item_Load();
        }
    }
}
