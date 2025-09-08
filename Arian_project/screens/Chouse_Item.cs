using Arian_project.Backend;
using Arian_project.Backend.styles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Arian_project.screens
{
    public partial class Chouse_Item : Form
    {
        public Store selected_item { get; set; }
        Theme_style theme = new Theme_style();
        Style style = new Style();
        Stores_database db = new Stores_database();
        public Chouse_Item()
        {
            InitializeComponent();
            set_style();
            load_items_to_list();
        }


        DataTable set_users_to_list
        {

            set
            {

                items_list.Rows.Clear();
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Rows.Count - 1; i++)
                {
                    var d = value.Rows[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(items_list);
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
                items_list.Rows.AddRange(rows.ToArray());
                items_list.ClearSelection();

            }
        }

        private void load_items_to_list()
        {
            DataTable items = db.stores_list();
            set_users_to_list = items;
        }
        private void add_stores_to_cb()
        {
            List<string> list = db.list_stores();
            stores_cb.DataSource = list;
        }
        private void set_style()
        {
            items_list.AllowUserToAddRows = false;
            items_list.EditMode = DataGridViewEditMode.EditProgrammatically;
            style.Stores_List_Style(items_list);
            add_stores_to_cb();
        }

        private void stores_cb_SelectedValueChanged(object sender, System.EventArgs e)
        {
            string name = stores_cb.Text;
            if (name != "")
            {
                string query = $"SELECT * FROM stors WHERE store_id='{name}'";
                DataTable items = db.stores_list(query);
                set_users_to_list = items;
            }
        }
        private void SelectRowFillFields(int id)
        {
            var data = items_list.Rows[id].Cells;
            Store item = new Store(
                int.Parse(data[0].Value.ToString()),
                int.Parse(data[1].Value.ToString()),
                data[2].Value.ToString(),
                int.Parse(data[3].Value.ToString()),
                int.Parse(data[4].Value.ToString()),
                int.Parse(data[5].Value.ToString()),
                data[6].Value.ToString(),
                data[7].Value.ToString(),
                data[8].Value.ToString()
                );
            selected_item = item;
            this.Close();
        }
        private void items_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                SelectRowFillFields(e.RowIndex);

            }
        }

        private void item_name_tb_TextChanged(object sender, EventArgs e)
        {

            string name = item_name_tb.Text;
            string store_id = stores_cb.Text;
            if (name != "")
            {
                string query = $"SELECT * FROM stors WHERE store_id='{store_id}' AND item_name LIKE '{name}'";
                DataTable items = db.stores_list(query);
                set_users_to_list = items;
            }
        }
    }
}
