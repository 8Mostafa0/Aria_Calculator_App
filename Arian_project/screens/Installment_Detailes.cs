
using Arian_project.Backend;
using Arian_project.Backend.Database;
using Arian_project.Backend.styles;
using System.Collections.Generic;
using System.Transactions;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Installment_Detailes : Form
    {
        Client_Installment installment {  get; set; }
        Transactions_database transactions_db = new Transactions_database();
        Installment_transaction_database i_transactions_db = new Installment_transaction_database(); 

        public Installment_Detailes(Client_Installment installment)
        {
            InitializeComponent();
            Set_Style();
            Load_Client_Installment(installment);
        }

        private void Set_Style()
        {
            Style style = new Style();
            style.Payments_list_style(payments_list);
            style.installment_dates_list_style(installment_list);
        }
        private void Load_Client_Installment(Client_Installment installment) {
            installment_id_lb.Text = installment.id.ToString();
            client_id_lb.Text = installment.client_id.ToString();
            client_name_lb.Text = installment.client_name;
            factor_id_lb.Text = installment.factor_id.ToString();
            full_installment_price_lb.Text = installment.installment_price.ToString();
            first_installment_date_lb.Text = installment.first_installment.ToString();
            one_installment_price_lb.Text = installment.one_installment_price.ToString();
            installment_count_lb.Text = installment.installment_count.ToString();
            installment_payed_count_lb.Text = installment.installment_payed_count.ToString();
            end_installment_lb.Text = installment.end_instllment ? "بله" : "خیر";
            reminder_lb.Text = installment.next_reminder.ToString();
            status_lb.Text = installment.status;
            this.installment = installment;
            Load_Installment_date(installment);
        }

        private void load_installment_payments(int factor_id) { 
            string sql_query = $"SELECT * FROM transactions WHERE installment_factor='True' AND factor_id='{factor_id}'";
            List<Transaction> transactions1 = transactions_db.get_installment_transactions(sql_query);
            foreach (Transaction trans in transactions1) {
                Add_Transaction = trans;
            }
            
        }
        private void Load_Installment_transactions(int installment_id) {
            string sql_query = $"SELECT * FROM installment_transactions WHERE installment_id='{installment_id}'";
            List<Installment_transaction> transactions = i_transactions_db.get_installment_transactions_list(sql_query);
            Set_Installments_List = transactions;
        }

        Transaction Add_Transaction
        {
            set
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(payments_list);
                row.Cells[0].Value = value.id;
                row.Cells[1].Value = value.transaction_type;
                row.Cells[2].Value = value.bank;
                row.Cells[3].Value = value.price;
                row.Cells[4].Value = value.transaction_date;
                row.Cells[5].Value = value.bank_id;
                row.Cells[6].Value = value.client_id;
                row.Cells[7].Value = installment.factor_id;

                rows.Add(row);
                payments_list.Rows.AddRange(rows.ToArray());
                payments_list.ClearSelection();
            }
        }

        List<Installment_transaction> Set_Installments_List
        {
            set
            {
                new Style().installment_dates_list_style(installment_list);
                installment_list.Rows.Clear();
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Count - 1; i++)
                {
                    var d = value[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(installment_list);
                    row.Cells[0].Value = d.id;
                    row.Cells[1].Value = d.date;
                    row.Cells[2].Value = d.price;
                    row.Cells[3].Value = d.payed_price;
                    row.Cells[4].Value = d.penalty_type;
                    row.Cells[5].Value = d.penalty_price_per_day;
                    row.Cells[6].Value = d.penalty;
                    row.Cells[7].Value = d.status;
                    row.Cells[8].Value = d.installment_number;
                    row.Cells[9].Value = d.installment_id;
                    rows.Add(row);
                }
                installment_list.Rows.Clear();
                installment_list.Rows.AddRange(rows.ToArray());
                installment_list.ClearSelection();
            }
        }
        private void Load_Installment_date(Client_Installment installment_id) { 
            Load_Installment_transactions(installment_id.id);
            load_installment_payments(installment_id.factor_id);
            installment = installment_id;
        }

        private void glassButton2_Click(object sender, System.EventArgs e)
        {
            int id = payments_list.Rows.Count + 1;
            using (Payment_methods screen = new Payment_methods(installment.client_id, id, Transaction.empty()))
            {
                screen.ShowDialog();
                if (screen.DialogResult == DialogResult.OK) {
                    Add_Transaction = screen.method;
                }
            }
        }
    }
}
