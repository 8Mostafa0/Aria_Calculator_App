using Arian_project.backend;
using Arian_project.Backend.styles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Chouse_Client : Form
    {
        public Chouse_Client()
        {
            InitializeComponent();
        }
        Clients_database clients_db = new Clients_database();
        public Client ReturnClient { get; private set; }
        private void fill_clients_type_cb()
        {
            List<string> clients_types = clients_db.Get_Clients_Types();
            client_type_cb.DataSource = clients_types;
            
        }
        public DataTable Clients_Lits_Set
        {
            set
            {

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
                Clients_List.Rows.AddRange(rows.ToArray());
                Clients_List.ClearSelection();

            }
        }
        private void Load_Clients()
        {

            Clients_List.Rows.Clear();
            new Style().Clients_List_Style(Clients_List);
            Clients_Lits_Set = clients_db.Clients_list();
        }
        private void Chouse_Client_Load_1(object sender, System.EventArgs e)
        {
            Load_Clients();
            fill_clients_type_cb();
            clear_data();

        }
        private void clear_data()
        {
            try
            {
                name_tb.Text = "";
                phone_tb.Text = "";
                home_phone_tb.Text = "";
                client_type_cb.SelectedIndex = 0;
            }catch
            {

                Load_Clients();
            }
        }
        private void SelectRowFillFields(int id)
        {
            try { 
                var row = Clients_List.Rows[id];
                name_tb.Text = row.Cells[1].Value.ToString();
                phone_tb.Text = row.Cells[2].Value.ToString();
                home_phone_tb.Text = row.Cells[3].Value.ToString();
                this.ReturnClient = new Client(
                    id = int.Parse(row.Cells[0].Value.ToString()),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    row.Cells[6].Value.ToString(),
                    row.Cells[7].Value.ToString()
                );
                this.Close();
            }
            catch { }
        }
        private void Clients_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowFillFields(e.RowIndex);
        }

        private void name_tb_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                string name = name_tb.Text;
                string sql_query = "";
                if (name != "")
                {
                    sql_query = $"SELECT * FROM clients WHERE user_name LIKE '%{name}%'";
                }
                DataTable users = clients_db.Clients_list(sql_query);
                Clients_List.Rows.Clear();
                Clients_Lits_Set = users;
            }
            catch 
            {
                Load_Clients();
            }
        }

        private void phone_tb_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                string name = phone_tb.Text;
                string sql_query = "";
                if (name != "")
                {
                    sql_query = $"SELECT * FROM clients WHERE phone_number LIKE '%{name}%'";
                }
                DataTable users = clients_db.Clients_list(sql_query);
                Clients_List.Rows.Clear();
                Clients_Lits_Set = users;

            }catch
            {
                Load_Clients();
            }
        }

        private void home_phone_tb_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                string name = home_phone_tb.Text;
                string sql_query = "";
                if (name != "")
                {
                    sql_query = $"SELECT * FROM clients WHERE home_number LIKE '%{name}%'";
                }
                DataTable users = clients_db.Clients_list(sql_query);
                Clients_List.Rows.Clear();
                Clients_Lits_Set = users;

            }catch
            {
                Load_Clients();
            }
        }

        private void client_type_cb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string name = client_type_cb.Text;
                string sql_query = "";
                if (name != "")
                {
                    sql_query = $"SELECT * FROM clients WHERE client_type LIKE '%{name}%'";
                }
                DataTable users = clients_db.Clients_list(sql_query);
                Clients_List.Rows.Clear();
                Clients_Lits_Set = users;
                
            }catch 
            {
                Load_Clients();

            }
        }
    }
}

