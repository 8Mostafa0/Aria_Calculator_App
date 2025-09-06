using Arian_project.backend;
using Arian_project.Backend;
using Arian_project.Backend.styles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Installment_Payment : Form
    {
        private Factor factor {  get; set; }
        private clients_database clients_db = new clients_database();
        installment_calculator calculator = new installment_calculator();
        penalty_calculator penaty_cl = new penalty_calculator();
        private string today_string {  get; set; }
        iran_date date = new iran_date();
        public Installment_Payment(Factor factor)
        {
            InitializeComponent();
            this.factor = factor;
            
        }

        private void Installment_Payment_Load(object sender, System.EventArgs e)
        {
            set_date();
            load_data();
            set_style();
        }
        private void set_date()
        {
            int[] data = date.Today();
            this.today_string = data[0].ToString() +"/"+ data[1].ToString() + "/"+data[2].ToString();
        }
        private void set_style() { }

        private void load_data() {
            
            factor_id_lb.Text = this.factor.id.ToString();
            installment_id_lb.Text = "1";
            Client user = clients_db.Get_Client_by_id(this.factor.client_id);
            user_name_lb.Text = user.user_name;
            phone_number_lb.Text = user.phone_number;
            factor_full_price_lb.Text = this.factor.full_price.ToString();
            factor_left_over_price_lb.Text = (this.factor.full_price - this.factor.payed_price).ToString();
            factor_date_lb.Text = this.factor.factor_date;
            int[] next_months = date.next_months(1);
            installment_first_pay_date_lb.Text = next_months[0].ToString() + "/" + next_months[1].ToString() + "/" + next_months[2].ToString();
            installment_profit_lb.Text = "3";
            installment_price_lb.Text = "";
            isntallment_full_profit_lb.Text = "0";
            ful_price_lb.Text = this.factor.full_price.ToString();
            string installment_type = calculator.installment_type();
            installment_percent_type.Text = "سود اقساط("+installment_type+")";
            add_penalty_types();
            load_penalty_values();
            month_count_lb.Text = "1";

        }

        private void load_penalty_values()
        {
            string penalty_method = penaty_cl.penalty_method();
            int index = penalty_type_cb.Items.IndexOf(penalty_method);
            penalty_type_cb.SelectedIndex = index;
            decimal penalty_value = penaty_cl.penalty_value();
            penalty_value_tb.Text = penalty_value.ToString();

        }
        private void add_penalty_types()
        {
            List<string> items = new List<string>()
            {
                "ثابت",
                "درصدی"
            };
            penalty_type_cb.DataSource = items;
        }
        private bool item_exist_in_list(int id)
        {
            foreach (DataGridViewRow row in installment_payments_date.Rows)
            {
                if (row.Cells[0].Value.ToString() == id.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        List<Installment_transaction> Set_Installments_Dates
        {
            set
            {
                new Style().installment_dates_list_style(installment_payments_date);
                installment_payments_date.Rows.Clear();
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i <= value.Count - 1; i++)
                {
                    var d = value[i];
                    if (!item_exist_in_list(int.Parse(d.id.ToString())))
                    { 
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(installment_payments_date);
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
                }
                installment_payments_date.Rows.Clear();
                installment_payments_date.Rows.AddRange(rows.ToArray());
                installment_payments_date.ClearSelection();
            }
        }
        private void calculate_installment()
        {
            try
            {
                if (!string.IsNullOrEmpty(month_count_lb.Text))
                {
                    int months = 1;
                    try
                    {
                        months = int.Parse(month_count_lb.Text);
                    }
                    catch (Exception ex) {
                        MessageBox.Show("لطفا تعداد ماه را عددی وارد کنید", "تعداد ماه");
                        months = 1;
                    }
                    if(months > 0)
                    {

                        decimal factor_left_over_price = Math.Round(this.factor.full_price - this.factor.payed_price);
                        decimal ont_month_price = Math.Round(calculator.installment_method(factor_left_over_price, 1));
                        decimal installment_full_price = Math.Round((ont_month_price * months)+factor_left_over_price);
                        decimal installment_full_profit = Math.Round(ont_month_price * months);
                        string penalty_type = penalty_type_cb.Text;
                        decimal penalty_per_day = Math.Round(penaty_cl.penalty_per_day(ont_month_price, penalty_type));
                        string first_isntallment_date = installment_first_pay_date_lb.GetText("yyyy/MM/dd");
                        string penalty_method = penalty_type ;

                        isntallment_full_profit_lb.Text = (installment_full_profit - factor_left_over_price).ToString();
                        installment_price_lb.Text = ont_month_price.ToString();
                        ful_price_lb.Text = installment_full_profit.ToString();
                    
                        List<Installment_transaction> transactions = new List<Installment_transaction>();

                        for(int i = 1;i <= months; i++){
                            int[] int_installment_date = date.next_month_of(i,first_isntallment_date);
                            string installment_date = int_installment_date[0].ToString() + "/" + int_installment_date[1].ToString() + "/" + int_installment_date[2].ToString();
                            transactions.Add(
                                new Installment_transaction(
                                    i,
                                    installment_date,
                                    ont_month_price,
                                    0,
                                    penalty_method,
                                    penalty_per_day,
                                    0,
                                    "پرداخت نشده",
                                    i,
                                    0
                                    )
                                );
                        }
                        Set_Installments_Dates = transactions;
                    }
                    else
                    {
                        MessageBox.Show("تعداد ماه باید بیشتر از 1 باشد", "تعداد ماه");
                        month_count_lb.Text = months.ToString();
                    }

                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString(), "erro");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (penalty_type_cb.SelectedIndex)
            {
                case 0:penalty_text.Text = "مبلغ جریمه";penalty_value_tb.Text = penaty_cl.penalty_value(penalty_type_cb.Text).ToString(); break;
                case 1: penalty_text.Text = "درصد جریمه"; penalty_value_tb.Text = penaty_cl.penalty_value(penalty_type_cb.Text).ToString(); break;
                default: penalty_text.Text = "مقدار جریمه"; break;
            }
            calculate_installment();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            calculate_installment();
        }
    }
}
