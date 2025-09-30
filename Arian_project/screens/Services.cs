using Arian_project.Backend;
using Arian_project.Backend.styles;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Services : Form
    {
        int selected_item_id = 0;
        int selected_service_id = 0;
        Services_database service_db = new Services_database();
        Stores_database store_db = new Stores_database();
        Style style = new Style();
        int counter = 1;
        public Services()
        {
            InitializeComponent();
            set_style();
            load_lists();
        }

        private void load_lists()
        {
            Set_Services_items = service_db.get_items_not_in_services();
            Set_Services_list = service_db.get_services_datatable();
        }

        

        DataTable Set_Services_items
        {
            set {
                service_items.Rows.Clear();
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Rows.Count - 1; i++)
                {
                    var d = value.Rows[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(service_items);
                    row.Cells[0].Value = d[0];
                    row.Cells[1].Value = d[1];
                    row.Cells[2].Value = d[2];
                    row.Cells[3].Value = d[3];
                    row.Cells[4].Value = d[4];
                    row.Cells[5].Value = d[5];
                    row.Cells[6].Value = d[6];
                    row.Cells[7].Value = d[7];
                    row.Cells[8].Value = d[8];
                    rows.Add(row);
                }
                service_items.Rows.AddRange(rows.ToArray());
                service_items.ClearSelection();
            }
        }

        DataTable Set_Services_list
        {
            set
            {

                services_list.Rows.Clear();
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Rows.Count - 1; i++)
                {
                    var d = value.Rows[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(services_list);
                    row.Cells[0].Value = counter;
                    row.Cells[1].Value = d[0];
                    row.Cells[2].Value = d[1];
                    row.Cells[3].Value = d[2];
                    row.Cells[4].Value = d[3];
                    counter++;
                    rows.Add(row);
                }
                services_list.Rows.AddRange(rows.ToArray());
                services_list.ClearSelection();

            }
        }


        private void set_style() {
            style.Stores_List_Style(service_items);
            style.Services_List_Style(services_list);
            new Form_Styles().Style(this);
        }
        private Store get_selected_item()
        {

            int index = service_items.SelectedRows[0].Index;
            
            DataGridViewCellCollection data = service_items.Rows[index].Cells;
            Store item = new Store(
                    int.Parse(data[0].Value.ToString()),
                    int.Parse(data[1].Value.ToString()),
                    data[2].Value.ToString(),
                    decimal.Parse(data[3].Value.ToString()),
                    decimal.Parse(data[4].Value.ToString()),
                    int.Parse(data[5].Value.ToString()),
                    data[6].Value.ToString(),
                    data[7].Value.ToString(),
                    data[8].Value.ToString()
                );
            return item;

        }
        private void service_items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Store item = get_selected_item();
            this.selected_item_id = item.id;
            item_name_tb.Text = item.item_name;
            service_name.Text = "";
            price_tb.Text = "";
            this.selected_service_id = 0;

        }

        private void glassButton2_Click(object sender, System.EventArgs e)
        {
            if(this.selected_service_id == 0)
            {
                MessageBox.Show("", "حذف سرویس");
            }
            else
            {
                bool result = service_db.delete_service_from_database(this.selected_service_id);
                if (result)
                {
                    MessageBox.Show("حذف سرویس با موفقیت انجام شد", "حذف سرویس");
                    load_lists();
                }
                else
                {
                    MessageBox.Show("هنگام حذف سرویس مشکلی بوجود امده است", "حذف سرویس");
                }
            }
        }

        private void glassButton1_Click(object sender, System.EventArgs e)
        {
            if(this.selected_service_id == 0)
            {
                if (this.selected_item_id == 0)
                {
                    MessageBox.Show("لطفا ابتدا ایتمی را انتخاب کنید", "ذخیره سرویس");
                }
                else
                {
                    if (service_db.store_item_exist_in_services_database(this.selected_item_id))
                    {
                        MessageBox.Show("ایتمی با این سرویس در ذخیره شده است لطفا سرویس را حذف یا ویرایش کنید", "ذخیره سرویس");
                    }
                    else
                    {
                        int service_id = service_db.get_last_service_id() + 1;
                        Store item = store_db.get_item_by_id(this.selected_item_id);
                        Service service = new Service(
                                service_id,
                                item.id,
                                service_name.Text,
                                decimal.Parse(price_tb.Text)
                            );
                        bool result = service_db.insert_service_to_database(service);
                        if (result)
                        {
                            MessageBox.Show("سرویس با موفقیت ذخیره شد", "ذخیره سرویس");
                            load_lists();
                        }
                        else
                        {
                            MessageBox.Show("هنگام ذخیره سرویس مشکلی بوحود امده است", "ذخیره سرویس");

                        }
                    }
                }

            }
            else
            {
                Service service = service_db.get_Service_by_id(this.selected_item_id);
                bool resutl = service_db.edite_service_in_datebase(service);
                if (resutl)
                {
                    MessageBox.Show("سرویس با موفقیت ویرایش شد", "ویرایش سرویس");
                    load_lists();
                }
                else
                {
                    MessageBox.Show("هنگام ویرایش سرویس مشکلی بوجود امده است", "ویرایش سرویس");
                }
            }
            
        }
        private Service get_selected_service()
        {
            int index = services_list.SelectedRows[0].Index;
            DataGridViewCellCollection data = services_list.Rows[index].Cells;
            Service service = new Service(
                    int.Parse(data[1].Value.ToString()),
                    int.Parse(data[2].Value.ToString()),
                    data[3].Value.ToString(),
                    decimal.Parse(data[4].Value.ToString())
                );
            this.selected_service_id = service.id;
            this.selected_item_id = 0;
            return service;
        }
        private void services_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Service service = get_selected_service();
            Store item = store_db.get_item_by_id(service.item_id);
            item_name_tb.Text = item.item_name;
            service_name.Text = service.service_name;
            price_tb.Text = service.cell_price.ToString();
        }
    }
}
