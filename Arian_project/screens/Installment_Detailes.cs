
using Arian_project.backend;
using Arian_project.Backend;
using Arian_project.Backend.Database;
using Arian_project.Backend.styles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Installment_Detailes : Form
    {
        Client_Installment installment {  get; set; }
        Transactions_database transactions_db = new Transactions_database();
        Installment_transaction_database i_transactions_db = new Installment_transaction_database(); 
        Client_installment_database c_installments_db = new Client_installment_database();
        List<Transaction> old_transactions = new List<Transaction>();
        List<Installment_transaction> old_installments = new List<Installment_transaction>();
        Clients_database client_db = new Clients_database();
        private int payment_counter = 1;

        public Installment_Detailes(Client_Installment installment)
        {
            InitializeComponent();
            Set_Style();
            Load_Client_Installment(installment);
        }

        private void Set_Style()
        {
            new Form_Styles().Style(this);
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
                old_transactions.Add(trans);
            }
            
        }
        private void Load_Installment_transactions(int installment_id) {
            string sql_query = $"SELECT * FROM installment_transactions WHERE installment_id='{installment_id}'";
            List<Installment_transaction> transactions = i_transactions_db.get_installment_transactions_list(sql_query);
            old_installments = transactions;
            Set_Installments_List = transactions;
        }

        Transaction Add_Transaction
        {
            set
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(payments_list);
                row.Cells[0].Value = payment_counter;
                row.Cells[1].Value = value.id;
                row.Cells[2].Value = value.transaction_type;
                row.Cells[3].Value = value.bank;
                row.Cells[4].Value = value.bank_id;
                row.Cells[5].Value = value.price;
                row.Cells[6].Value = value.client_id;
                row.Cells[7].Value = value.transaction_date;
                row.Cells[8].Value = installment.factor_id;
                row.Cells[9].Value = value.installment_factor;
                payment_counter++;
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
            Admin admin = new Users_database().Get_Admin();
            if (admin.Ac_pay_installment())
            {
                int id = transactions_db.get_last_transaction_id();
                using (Payment_methods screen = new Payment_methods(installment.client_id, id, Transaction.empty()))
                {
                    screen.ShowDialog();
                    if (screen.DialogResult == DialogResult.OK) {
                        Add_Transaction = screen.method;
                    }
                }
            }
            else
            {
                MessageBox.Show("شما به پرداخت اقساط دسترسیی مجاز  ندارید", "دسترسی");
            }
        }
        private List<Installment_transaction> get_installment_transactions() { 
            List<Installment_transaction> installments = new List<Installment_transaction>();
            foreach(DataGridViewRow row in installment_list.Rows)
            {
                DataGridViewCellCollection data = row.Cells;
                Installment_transaction item = new Installment_transaction(
                        int.Parse(data[0].Value.ToString()),
                        data[1].Value.ToString(),
                        decimal.Parse(data[2].Value.ToString()),
                        decimal.Parse(data[3].Value.ToString()),
                        data[4].Value.ToString(),
                        decimal.Parse(data[5].Value.ToString()),
                        decimal.Parse(data[6].Value.ToString()),
                        data[7].Value.ToString(),
                        int.Parse(data[8].Value.ToString()),
                        int.Parse(data[8].Value.ToString())
                    );
                installments.Add(item);
            }
            return installments;
        
        }

        private List<Transaction> get_payments()
        {
            List<Transaction> transactions = new List<Transaction>();
            foreach (DataGridViewRow row in payments_list.Rows)
            {
                DataGridViewCellCollection data = row.Cells;
                Transaction transaction = new Transaction(
                        int.Parse(data[1].Value.ToString()),
                        data[2].Value.ToString(),
                        data[3].Value.ToString(),
                        int.Parse(data[4].Value.ToString()),
                        decimal.Parse(data[5].Value.ToString()),
                        int.Parse(data[6].Value.ToString()),
                        data[7].Value.ToString(),
                        int.Parse(data[8].Value.ToString()),
                        true
                    );
               transactions.Add(transaction);
            }
            return transactions;
        }
        private decimal calculate_payments(List<Transaction> transactions)
        {
            decimal total = 0;
            foreach (Transaction transaction in transactions)
            {
                total += transaction.price;
            }
            return total;
        }

        private int calculate_installment_payed_counts(List<Installment_transaction> installment,decimal total_payed) {
            int count = 0;
            for(int i = 0; i < installment.Count; i++) {
                decimal installment_price = installment[i].price + installment[i].penalty;
                if(total_payed > 0)
                {
                    if (total_payed - installment_price >= 0) {
                        installment[i].payed_price = installment_price;
                        installment[i].status = "پرداخت شده";
                        count++;
                        total_payed -= installment_price;
                    }
                    else
                    {
                        installment[i].payed_price = total_payed;
                        installment[i].status = "نیمه پرداخت";
                        total_payed = 0;
                    }
                }
                else
                {

                    installment[i].status = "پرداخت نشده";
                }
            }
            return count;
        }
        private bool save_transactions(List<Transaction> transactions) {
            bool result = false;
            if(transactions.Count > 0)
            {
                for(int i = 0;i<transactions.Count;i++)
                {
                        if(old_transactions.Count > i)
                        {
                            if (transactions[i] != old_transactions[i])
                            {
                                if (transactions_db.check_transactions_exist(transactions[i].id))
                                {
                                    result = transactions_db.edite_transaction_in_datebase(transactions[i]);
                                }
                                else
                                {
                                    result = transactions_db.insert_transaction_to_database(transactions[i]);
                                }
                                if (!result)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                result = true;
                            }
                        }
                        else
                        {
                            result = transactions_db.insert_transaction_to_database(transactions[i]);
                            if (!result)
                            {
                                return false;
                            }
                        }
                }
            }
            else
            {
                return true;
            }
                return result;
        }
        private bool save_installment_changes(List<Transaction> transactions, List<Installment_transaction> installments)
        {

            bool result = false;
            if (save_transactions(transactions))
            {
                for(int i = 0;i<installments.Count;i++)
                {
                    try
                    {
                        if(old_installments.Count > i)
                        {
                            if (installments[i] != old_installments[i])
                            {
                                if (i_transactions_db.check_installment_transactions_exist(installments[i].id))
                                {
                                    result = i_transactions_db.edite_installment_transaction_to_database(installments[i]);
                                }
                                if (!result)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                result = true;
                            }
                        }
                    }catch(Exception)
                    {
                    }
                }
                if (!result)
                {
                    MessageBox.Show("مشکلی هنگام ثبت اقساط بوجود امده است", "ثبت اقساط");
                }
            }
            else
            {
                MessageBox.Show("مشکلی در ثبت تراکنش ها بوحود امده است", "ثبت تراکنش ها");
            }
            return result;
        }
        private void glassButton1_Click(object sender, System.EventArgs e)
        {

            Admin admin = new Users_database().Get_Admin();
            if (admin.Ac_pay_installment())
            {
                List<Transaction> transactions = get_payments();
                List<Installment_transaction> installments = get_installment_transactions();
                decimal total_payment = calculate_payments(transactions);
                int payed_count = calculate_installment_payed_counts(installments,total_payment);
                this.installment.installment_payed_count = payed_count;
                bool result = save_installment_changes(transactions, installments);
                if (result)
                {
                    result = c_installments_db.update_client_installment_to_database(this.installment);
                    if (result)
                    {
                        MessageBox.Show("اقساط با موفقیت ثبت شدند", "ثبت اقساط");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("هنگام ویرایش قسط مشکلی بوجود امده است", "ثبت اقساط");
                    }
                }
                else
                {
                    MessageBox.Show("مشکلی در ثبت اقساط بوجود امده است", "ثبت اقساط");
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این قابلیت را ندارید", "دسترسی");
            }
            
        }

        private void delete_transaction(int id)
        {
            payments_list.Rows.RemoveAt(id);
            payments_list.Refresh();
        }
        private void payments_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewCellCollection row = payments_list.Rows[id].Cells;
            Transaction transaction = new Transaction(
                int.Parse(row[1].Value.ToString()),
                row[2].Value.ToString(),
                row[3].Value.ToString(),
                int.Parse(row[4].Value.ToString()),
                decimal.Parse(row[5].Value.ToString()),
                int.Parse(row[6].Value.ToString()),
                row[7].Value.ToString(),
                this.installment.factor_id,
                true
                );
            using (Payment_methods screen = new Payment_methods(this.installment.client_id, transaction.id,transaction)) {
                screen.ShowDialog();
                if (screen.DialogResult == DialogResult.OK) {
                    if (screen.method != null && screen.method != transaction)
                    {
                        transaction = screen.method;
                        payments_list.Rows[id].Cells[2].Value = transaction.transaction_type;
                        payments_list.Rows[id].Cells[3].Value = transaction.bank;
                        payments_list.Rows[id].Cells[4].Value = transaction.bank_id;
                        payments_list.Rows[id].Cells[5].Value = transaction.price;
                        payments_list.Rows[id].Cells[7].Value = transaction.transaction_date;
                    }

                }
                else if(screen.DialogResult == DialogResult.Abort)
                {
                    delete_transaction(id);
                }
            
            }
        }
    }
}
