using Arian_project.Backend;
using Arian_project.Backend.Database;
using System;
using System.Collections.Generic;
using System.Transactions;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Payment_methods : Form
    {

        public Transaction method { get; set; } 
        public int client_id { get; set; }

        public Transactions_database db = new Transactions_database();

        public int method_index = 0;
        public string today_string { get; set; }

        private Card_reader_database card_reader_db = new Card_reader_database();

        private Banks_database banks_db = new Banks_database();

        private int id = 1;
        public Payment_methods(int client_id, int id,Transaction transaction)
        {
            InitializeComponent();
            this.client_id = client_id;
            this.id = id;
            this.method = transaction;
        }


        public void add_payments_method()
        {
            List<string> payments = new List<string> { 
                "کارتخوان",
                "حساب به حساب",
                "نقدی"
            };

            payment_methods_cb.DataSource = payments;

        }

        public void set_date()
        {
            Iran_date calender = new Iran_date();
            int[] today =  calender.Today();
            this.today_string = today[0].ToString() + "/" + today[1].ToString() + "/" + today[2].ToString();
            date_lb.Text = this.today_string;
            
        }
        public void set_style()
        {

        }

        private void Payment_methods_Load(object sender, EventArgs e)
        {
            set_date();
            set_style();
            add_payments_method();
            check_transaction();
        }
        private void check_transaction()
        {
            if(method.id > 0)
            {
                payment_methods_cb.Text = method.transaction_type;
                banks_cb.Text = method.bank;
                price_tb.Text = method.price.ToString();
            }
        }
        private void glassButton1_Click(object sender, EventArgs e)
        {
            if (payment_methods_cb.SelectedIndex < 0)
            {
                MessageBox.Show("لطفا نحوه پرداخت را انتخاب کنید", "نحوه پرداخت");
            }
            else if (banks_cb.SelectedIndex < 0 && this.method_index != 2)
            {
                MessageBox.Show("لطفا بانک را انتخاب کنید", "بانک");
            }
            else if (price_tb.Text.Length > 0)
            {
                try{
                    string price_text = price_tb.Text;
                    int price = int.Parse(price_text);
                    if (price > 0) {
                        string bank_name = "";
                        int bank_id = 0;
                        string method = "";
                        if(payment_methods_cb.SelectedIndex == 2)
                        {
                            bank_id = 0;
                            bank_name = "نقدی";
                            method = "نقدی";
                        }
                        else
                        {
                            if(payment_methods_cb.SelectedIndex == 0)
                            {
                                method = payment_methods_cb.SelectedValue.ToString();
                                string p_bank = banks_cb.SelectedValue.ToString();
                                Card_Reader card_reader = new Card_reader_database().get_card_reader_by_name(p_bank);
                                Bank bank = new Banks_database().get_bank_data_by_id(card_reader.bank_id);
                                bank_name = bank.name;
                                bank_id = bank.id;
                            } else if(payment_methods_cb.SelectedIndex == 1)
                            {
                                method = payment_methods_cb.SelectedValue.ToString();
                                string p_bank = banks_cb.SelectedValue.ToString();
                                Bank bank = banks_db.get_bank_by_name(p_bank);
                                bank_name = bank.name;
                                bank_id = bank.id;

                            }
                        }
                        this.method = new Transaction(this.id,method,bank_name,bank_id,price,client_id, this.today_string,this.method.factor_id, false);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("لطفا مبلغ را وارد کنید","مبلغ");
                    }
                }
                catch
                {
                    MessageBox.Show("لطفا مقدار را عددی وارد کنید", "مبلغ");
                }
            }
        }

        private void payment_methods_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.method_index = payment_methods_cb.SelectedIndex;
            List<string> banks_list = new List<string>();
            if (this.method_index == 0)
            {
                banks_cb.Enabled = true;
                List<Card_Reader> card_readers = card_reader_db.card_readers_list_array();
                foreach (Card_Reader reader in card_readers)
                {
                    banks_list.Add(reader.name);
                }
            }
            else if (this.method_index == 1) {
                banks_list = banks_db.get_banks_name();
                banks_cb.Enabled = true;
            }
            else
            {
                banks_list.Clear();
                banks_cb.Enabled = false;
            }
            banks_cb.DataSource = banks_list;
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
