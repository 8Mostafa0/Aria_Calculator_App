using Arian_project.Backend;
using Arian_project.Backend.styles;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Services : Form
    {

        Services_database db = new Services_database();
        Style style = new Style();
        public Services()
        {
            InitializeComponent();
            set_style();
            load_lists();
        }

        private void load_lists()
        {
            Set_Services_items = db.get_items_not_in_services();
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

        DataTable Ser_Services_list
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
                services_list.Rows.AddRange(rows.ToArray());
                services_list.ClearSelection();

            }
        }


        private void set_style() {
            style.Stores_List_Style(service_items);
            service_items.AllowUserToAddRows = true;
        }
    }
}
