using Arian_project.backend;
using Arian_project.Backend;
using Arian_project.Backend.styles;
using ghest.Backend.Logs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Buy_Item : Form
    {
        public bool Buy_Screen { get; set; }
        public Client client {  get; set; }

        factors_database factors_db = new factors_database();
        stores_database stors_db = new stores_database();
        Database_data db = new Database_data();
        sub_factors_database sub_factor_db = new sub_factors_database();
        transactions_database transaction_db = new transactions_database();
        Style style = new Style();
        public int factor_id { get; set; }

        public int sub_factors_id = 1;

        public string today_string { get; set; }
        private decimal payments_full_price { get; set; }
        private decimal items_full_profit { get; set; }
        private decimal items_full_price { get; set; }

        public Buy_Item(bool buy)
        {
            InitializeComponent();
            this.items_full_price = 0;
            this.items_full_profit = 0;
            this.payments_full_price = 0;
            this.Buy_Screen = buy;
            this.WindowState = FormWindowState.Maximized;
            list_items.KeyDown += list_items_KeyDown;
            this.Text = buy?"خرید":"فروش";
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
            this.today_string = today_date[0].ToString() + "/" + today_date[1].ToString() + "/" + today_date[2].ToString();
            Date_lb.Text = this.today_string;
        }
        private void Set_Factor_id()
        {
            this.factor_id = factors_db.factors_counter() + 1;
            Factor_id_lb.Text = this.factor_id.ToString();
        }
        private void textBox2_Click(object sender, System.EventArgs e)
        {
            using (Chouse_Client screen = new Chouse_Client()) { 
                screen.ShowDialog();
                try
                {
                    Client user = screen.ReturnClient;
                    if (user != null) {
                        client = user;
                        Client_Name_tb.Text = user.user_name;
                        Client_phone_tb.Text = user.phone_number;
                    }
                }catch
                {

                }
            }
        }

        private void Set_Style()
        {
            style.Payments_list_style(payments_llist);
            style.Store_Items_List(list_items);
            Theme_style theme = new Theme_style();
            Font app_font = theme.app_font();
            Color bt_color = theme.Theme_Bt_Color;
            Color bg_color = theme.Theme_Mode?theme.Dark_Theme_Main_Color: theme.Light_Theme_Main_Color;
            
            label1.Font = app_font;
            label2.Font = app_font;
            label3.Font = app_font;
            label4.Font = app_font;
            Date_lb.Font = app_font;
            Factor_id_lb.Font = app_font;

            Client_Name_tb.Font = app_font;
            Client_phone_tb.Font= app_font;

            this.BackColor = bg_color;
        }
        private bool item_exist_in_list(int item_id) {
            if(list_items.Rows.Count > 1)
            {
                foreach (DataGridViewRow i in list_items.Rows) { 
                    if(i.Cells[10].Value != null)
                    {
                        if(int.Parse(i.Cells[10].Value.ToString()) == item_id)
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
                int id = list_items.Rows.Count ;
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(list_items);
                row.Cells[0].Value = id;
                row.Cells[1].Value = item.store_id;
                row.Cells[2].Value = item.item_name;
                row.Cells[3].Value = item.buy_price;
                row.Cells[4].Value = "0";
                row.Cells[5].Value = "0";
                row.Cells[6].Value = item.buy_date;
                row.Cells[7].Value = item.cell_date;
                row.Cells[8].Value = item.service_item;
                row.Cells[9].Value = "0";
                row.Cells[10].Value = item.id;
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
            if (e.ColumnIndex == 2) {
                using (Chouse_Item screen = new Chouse_Item()) { 
                    screen.ShowDialog();
                    Store item = screen.selected_item;
                    if (item != null) { 
                        add_item_to_list(item);
                    }
                }
            }
        }
        private void count_full_factor_price()
        {
            decimal full_price = 0;
            if (this.Buy_Screen)
            {
                foreach(DataGridViewRow i in list_items.Rows)
                {
                    if (i.Cells[3].Value != null && i.Cells[5].Value != null && i.Cells[3].Value.ToString() != "" && i.Cells[5].Value .ToString() != "")
                    {
                        decimal price = decimal.Parse(i.Cells[3].Value.ToString());
                        int count = int.Parse(i.Cells[5].Value.ToString());
                        decimal item_price = (price * count);
                        full_price += item_price;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow i in list_items.Rows)
                {

                    if (i.Cells[4].Value != null && i.Cells[5].Value != null && i.Cells[4].Value.ToString() != "" && i.Cells[5].Value.ToString() != "")
                    {
                        decimal price = decimal.Parse(i.Cells[4].Value.ToString());
                        int count = int.Parse(i.Cells[5].Value.ToString());
                        full_price += (price * count);
                    }
                }
            }
            full_price_lb.Text = full_price.ToString();
        }
        private void list_items_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            count_full_factor_price();
            if (list_items.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null&& list_items.Rows[e.RowIndex].Cells[4].Value != null&& list_items.Rows[e.RowIndex].Cells[5].Value != null)
            {
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    try
                    {
                        int item_id = 0;
                        decimal price = 0; 
                        if (this.Buy_Screen)
                        {
                            price = decimal.Parse(list_items.Rows[e.RowIndex].Cells[3].Value.ToString());
                        }
                        else
                        {
                            price = decimal.Parse(list_items.Rows[e.RowIndex].Cells[4].Value.ToString());
                        }
                        int count = int.Parse(list_items.Rows[e.RowIndex].Cells[5].Value.ToString());
                        try
                        {
                            if(list_items.Rows[e.RowIndex].Cells[10].Value != null)
                            {
                                item_id = int.Parse(list_items.Rows[e.RowIndex].Cells[10].Value.ToString());
                            }
                            else
                            {
                                item_id = 0;
                            }
                        }
                        catch
                        {
                            item_id = 0;
                        }

                        if(item_id == 0)
                        {
                            //item_id = stors_db.get_last_item_id() + 1;
                            //list_items.Rows[e.RowIndex].Cells[10].Value = item_id;
                            list_items.Rows[e.RowIndex].Cells[1].Value = stors_db.get_last_item_store_id();
                            list_items.Rows[e.RowIndex].Cells[6].Value = today_string;
                            list_items.Rows[e.RowIndex].Cells[7].Value = "";
                            list_items.Rows[e.RowIndex].Cells[8].Value = "خیر";
                        }
                        else
                        {
                            if (this.Buy_Screen == false)
                            {
                                int store_count = stors_db.get_item_by_id(item_id).count;

                                if (store_count < count)
                                {
                                    MessageBox.Show("تعداد وارد شده از موجودی انبار کمتر است", "موجودی انبار");
                                    return;
                                }
                            }
                        }
                        decimal full_price = price * count;
                        list_items.Rows[e.RowIndex].Cells[9].Value = full_price;
                        
                    }
                    catch { }
                }
            }
        }
        private List<Store> get_items_list()
        {
            List<Store> items = new List<Store>();
            foreach (DataGridViewRow row in list_items.Rows)
            {
                if (row.Cells[1].Value != null &&
                    row.Cells[2].Value != null && row.Cells[3].Value != null &&
                    row.Cells[4].Value != null && row.Cells[5].Value != null &&
                    row.Cells[6].Value != null && row.Cells[7].Value != null &&
                    row.Cells[8].Value != null && row.Cells[9].Value != null)
                {
                    try
                    {
                        int store_id;
                        int buy_price;
                        int cell_price;
                        int count;
                        decimal full_price;

                        if (!int.TryParse(row.Cells[1].Value.ToString(), out store_id) ||
                            !int.TryParse(row.Cells[3].Value.ToString(), out buy_price) ||
                            !int.TryParse(row.Cells[4].Value.ToString(), out cell_price) ||
                            !int.TryParse(row.Cells[5].Value.ToString(), out count)||
                            !decimal.TryParse(row.Cells[9].Value.ToString(), out full_price))
                        {
                            continue; 
                        }
                        int id = 0;
                        string item_name = row.Cells[2].Value.ToString();
                        if (stors_db.item_exist_in_store(item_name))
                        {
                            id = stors_db.get_item_by_name(item_name).id;
                        }
                        else
                        {
                            id = stors_db.get_last_item_id();
                        }
                            Store item = new Store(
                                id,
                                store_id,
                                item_name,
                                buy_price,
                                cell_price,
                                count,
                                row.Cells[6].Value?.ToString() ?? today_string,
                                row.Cells[7].Value?.ToString() ?? string.Empty,
                                row.Cells[8].Value?.ToString() ?? "خیر"
                            );
                        items.Add(item);
                        if (this.Buy_Screen)
                        {
                            this.items_full_price += (buy_price * count);
                        }
                        else
                        {
                            this.items_full_profit += ((cell_price - buy_price) * count);
                            this.items_full_price += full_price;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"خطا در پردازش ردیف {row.Index + 1}: {ex.Message}", "خطا");
                        continue; 
                    }
                }
            }
            return items;
        }
        private List<Transaction> get_transactions_list()
        {
            this.payments_full_price = 0M;
            List<Transaction> transactions = new List<Transaction>();

            if (this.client == null)
            {
                MessageBox.Show("مشتری انتخاب نشده است!", "خطا");
                return transactions; 
            }

            foreach (DataGridViewRow row in payments_llist.Rows)
            {
                if (!row.IsNewRow) 
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null &&
                        row.Cells[2].Value != null && row.Cells[3].Value != null &&
                        row.Cells[4].Value != null && row.Cells[5].Value != null)
                    {
                        try
                        {
                            int id;
                            decimal price;

                            if (!int.TryParse(row.Cells[0].Value.ToString(), out id) ||
                                !decimal.TryParse(row.Cells[3].Value.ToString(), out price))
                            {
                                continue; 
                            }

                            Transaction transaction = new Transaction(
                                id,
                                row.Cells[2].Value.ToString(),
                                row.Cells[1].Value.ToString(), 
                                int.Parse(row.Cells[5].Value.ToString()),
                                price,
                                this.client.id,
                                row.Cells[4].Value.ToString(),
                                factor_id,
                                false
                            );
                            transactions.Add(transaction);
                            this.payments_full_price += transaction.price;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"خطا در پردازش ردیف {row.Index + 1}: {ex.Message}", "خطا");
                            continue; 
                        }
                    }
                }
            }
            return transactions;
        }
        private Factor create_factor()
        {
            this.items_full_price = 0;
            this.items_full_profit = 0;
            List<Store> items = get_items_list();
            List<Transaction > transactions = get_transactions_list();
            Factor factor = new Factor(
                this.factor_id,
                this.client.id,
                this.Buy_Screen?"خرید":"فروش",
                this.items_full_price,
                this.items_full_profit,
                this.payments_full_price,
                this.Date_lb.GetText("yyyy/MM/dd"),
                this.client.client_type,
                "پرداخت نشده"
                );
            factor.items = items;
            factor.transactions = transactions;
            return factor;
        }
        private void glassButton1_Click(object sender, EventArgs e)
        {
            string Message_type = "ثبت فاکتور";
            if(client == null)
            {
                MessageBox.Show("لطفا مشتری را انتخاب کنید",Message_type);
                return;
            } else if (list_items.Rows.Count == 0) {
                MessageBox.Show("لطفا ایتمی را انتخاب کنید", Message_type);
                return;
            }

            Factor factor = create_factor();
            factor.factor_status = "پرداخت شده";
            if(this.payments_full_price < this.items_full_price)
            {
                Button[] buttons =
                {
                    new Button(){Text="پرداخت قسطی"},
                    new Button(){Text="پرداخت نشده"}
                };
                using (PMessageBox screen = new PMessageBox("فاکتور پرداخت نشده", "فاکتور به لیست پرداخت نشده ها اضافه شود یا قسطی پرداخت شود؟", buttons))
                {
                    screen.ShowDialog();
                    if (screen.DialogResult == DialogResult.OK)
                    {
                        factor.factor_status = screen.result.Text;
                    }
                }
            }
            else if(this.payments_full_price > this.items_full_price)
            {
                DialogResult res =  MessageBox.Show("مبلغ پرداخت شده از مبلغ فاکتور بیشتر است !\nفاکتور ذخیره شود؟", Message_type);
                if(res == DialogResult.Yes)
                {
                    factor.factor_status = "پرداخت شده";
                }
                else
                {
                    return;
                }
            }
            else
            {
                factor.factor_status = "پرداخت شده";
            }
            if(factor.factor_status == "پرداخت قسطی") {
                using(Installment_Payment screen = new Installment_Payment(factor))
                {
                    screen.ShowDialog();
                }
            }
            else
            {
                bool result = save_factor_data(factor);
                if (result)
                {
                    MessageBox.Show("فاکتور با موفقیت ثبت شد", Message_type);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("خطا در ثبت فاکتور", Message_type);
                    reverst_factor_changes(factor);
                }
            }
        }

        private bool save_transactions(Factor factor)
        {
            bool result = false;
            foreach (Transaction trans in factor.transactions)
            {
                result = transaction_db.insert_transaction_to_database(trans);
                if (!result)
                {
                    MessageBox.Show("مشکلی در ثبت رسید ها بوحود امده است","ثبت رسید ها");
                    return result;
                }
            }
            return result;
        }
        private bool save_store_changes(Factor factor)
        {
            bool result = false;
            foreach(Store sub in factor.items)
            {
                try {
                    if (stors_db.item_exist_in_store(sub.item_name))
                    {
                        if (!this.Buy_Screen) { 
                            Store item = stors_db.get_item_by_id(sub.id);
                            if(item.count < sub.count)
                            {
                                DialogResult res =  MessageBox.Show("موجودی ایتم در انبار کمتر از مقدار وارد شده است مقدار صفر ثبت شود؟", "موجودی ایتم",MessageBoxButtons.YesNo);
                                if (res == DialogResult.Yes) {
                                    sub.count = item.count;
                                }
                            }
                        }
                        string operation = this.Buy_Screen ? "+" : "-";
                        string query = $"UPDATE stors SET count = count {operation} {sub.count} WHERE id = {sub.id}";
                        result = db.run_sql_query(query,"update items in store",$"change items count base on the factor {factor.id}");
                        return result;
                    }
                    else if(this.Buy_Screen)
                    {
                        int stor_id = stors_db.get_last_item_store_id();
                        Store store = new Store(sub.id, stor_id,sub.item_name, sub.buy_price, sub.cell_price, sub.count, sub.buy_date, sub.cell_date, sub.service_item);
                        result = stors_db.insert_item_to_database(store);
                        if (!result)
                        {
                            MessageBox.Show("مشکلی در ثبت تغییرات انبار بوجود امده است", "ثبت تغییرات انبار");
                            return result;
                        }
                    }
                }catch(Exception ex) {
                    MessageBox.Show(ex.ToString(), "erro");
                }
            }
            return result;
        }
        private void revert_bank_changes(Factor factor)
        {
            string message_type = "revert_bank_changes";
            string logger_message_type = "revert bank changes transaction of old factor in bank table";
            if (factor.factor_type == "خرید")
            {
                foreach (Transaction item in factor.transactions)
                {
                    string sql_query = $"UPDATE banks SET balance = balance + {item.price} WHERE id = {item.bank_id}";
                    db.run_sql_query(sql_query, message_type, logger_message_type);
                }
            }
            else if (factor.factor_type == "فروش")
            {

                foreach (Transaction item in factor.transactions)
                {
                    string sql_query = $"UPDATE banks SET balance = balance - {item.price} WHERE id = {item.bank_id}";
                    db.run_sql_query(sql_query, message_type, logger_message_type);
                }
            }
        }
        private void revert_store_items(Factor factor)
        {
            string message_type = "revert_store_items";
            string logger_message_type = "revert store cahnges of factor in store table";
            if (factor.factor_type == "خرید")
            {
                foreach (Store item in factor.items)
                {
                    string sql_query = $"UPDATE stors SET count = count - {item.count} WHERE id = {item.id}";
                    db.run_sql_query(sql_query, message_type, logger_message_type);
                }
            }
            else if (factor.factor_type == "فروش")
            {
                foreach (Store item in factor.items)
                {
                    string sql_query = $"UPDATE stors SET count = count + {item.count} WHERE id = {item.id}";
                    db.run_sql_query(sql_query, message_type, logger_message_type);
                }
            }
        }

        private void revert_sub_factors(Factor factor)
        {
            List<Sub_factor> items = sub_factor_db.get_sub_factor_of_factor(factor.id);
            foreach (Sub_factor sub in items)
            {
                sub_factor_db.delete_sub_factor_from_database(sub.id);
            }
        }
        private void revert_transactions(Factor factor)
        {
            foreach (Transaction item in factor.transactions)
            {
                transaction_db.delete_transaction_from_database(item.id);
            }
        }
        private void reverst_factor_changes(Factor factor)
        {
            revert_store_items(factor);
            revert_bank_changes(factor);
            revert_sub_factors(factor);
            revert_transactions(factor);
            factors_db.delete_factor_from_database(factor.id);
        }

        private bool save_sub_factors(Factor factor)
        {
            bool result = false;
            foreach (Store sub in factor.items)
            {
                int id = sub_factor_db.sub_factors_counter() + 1;
                Sub_factor sub_factor = Sub_factor.Get_Sub_Factor_from_store(id, factor.id, (sub.cell_price - sub.buy_price), sub);
                result = sub_factor_db.insert_sub_factor_to_database(sub_factor);
                if (!result)
                {
                    return result;
                }
            }
            return result;
        }
        private bool save_factor_data(Factor factor) {

            bool result = false;
            result = factors_db.insert_factor_to_database(factor);
            if (result)
            {
                result = save_transactions(factor);
                if (!result) {
                    MessageBox.Show("در هنگام ثبت تراکنش مشکلی بوجود امده است", "ثبت تراکنش");
                    return result;
                }
                result = save_store_changes(factor);
                if (!result)
                {
                    MessageBox.Show("در هنگام ثبت ایتم مشکلی بوجود امده است", "ثبت ایتم");
                    return result;
                }
                result = save_sub_factors(factor);
                if (!result)
                {
                    MessageBox.Show("درهنگام ثبت ایتم های فاکتور مشکلی بوجود امده است", "ثبت ایتم ها");
                    return result;
                }
                result = add_transactions_to_banks(factor);
                if (!result)
                {
                    MessageBox.Show("درهنگام تسویه مبالغ حساب فاکتور به حساب مشکلی بوجود امده است", "تسویه حساب");
                    return result;
                }
            }
            else
            {
                MessageBox.Show("خطا در ثبت فاکتور", "ثبت فاکتور");
            }

            return result;

        }

        Transaction Add_Transaction
        {
            set
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(payments_llist);
                row.Cells[0].Value = value.id;
                row.Cells[1].Value = value.transaction_type;
                row.Cells[2].Value = value.bank;
                row.Cells[3].Value = value.price;
                row.Cells[4].Value = value.transaction_date;
                row.Cells[5].Value = value.bank_id;
                row.Cells[6].Value = value.client_id;
                row.Cells[7].Value = factor_id;

                rows.Add(row);
                payments_llist.Rows.AddRange(rows.ToArray());
                payments_llist.ClearSelection();
            }
        }

        private bool add_transactions_to_banks(Factor factor)
        {
            bool result = false;
            foreach(Transaction trans in factor.transactions)
            {
                string message_type = "add_transactions_to_banks";
                string logger_message_type = "add full price of items to banks";
                string operation = this.Buy_Screen ? "-" : "+";
                string sql_query = $"UPDATE banks SET balance = balance {operation} {trans.price} WHERE id = {trans.bank_id}";
                result = new Database_data().run_sql_query(sql_query, message_type, logger_message_type);
                if (!result) {
                    MessageBox.Show("هنگام تغییر موجودی حساب مشکلی بوجود امده است", "موجودی حساب");
                }
            }
            return result;
        }
        private void glassButton2_Click(object sender, EventArgs e)
        {
            if (client == null) {
                MessageBox.Show("لطفا ابتدا مشتری را انتخاب کنید","مشتری");
            }
            else
            {
                using (Payment_methods screen = new Payment_methods(this.client, this.sub_factors_id,new Transaction(0, "0", "0", 0, 0, 0, "0",factor_id,false)))
                {
                    screen.ShowDialog();
                    if (screen.method != null && screen.method.id != 0)
                    {
                        Add_Transaction = screen.method;
                        this.sub_factors_id = payments_llist.Rows.Count+1;
                    }
                }
            }
        }

        private void fix_list_ids()
        {
            for (int i = 0; i < list_items.Rows.Count; i++)
            {
                if (!list_items.Rows[i].IsNewRow)
                {
                    list_items.Rows[i].Cells["id"].Value = i + 1; 
                }
            }
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in list_items.SelectedRows)
            {
                if(row.Cells[0].Value != null)
                {
                    list_items.Rows.RemoveAt(row.Index);
                }
            }
            if (list_items.IsCurrentCellInEditMode)
            {
                list_items.ClearSelection();
                list_items.Refresh();
            }
            fix_list_ids();
        }
        private void list_items_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (list_items.IsCurrentCellInEditMode)
                {
                    list_items.EndEdit();
                }

                if (list_items.SelectedRows.Count == 0)
                {
                    MessageBox.Show("لطفاً حداقل یک ردیف انتخاب کنید!", "هشدار");
                    return;
                }

                if (MessageBox.Show("آیا مطمئن هستید که می‌خواهید ردیف‌های انتخاب‌شده را حذف کنید؟", "تأیید حذف", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                foreach (DataGridViewRow row in list_items.SelectedRows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value != null)
                    {
                        list_items.Rows.RemoveAt(row.Index);
                    }
                }

                fix_list_ids();


                list_items.Refresh();
            }
        }

        private void payments_llist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewCellCollection row = payments_llist.Rows[id].Cells; ;
            Transaction transaction = new Transaction(
                int.Parse(row[0].Value.ToString()),
                row[1].Value.ToString(),
                row[2].Value.ToString(),
                int.Parse(row[5].Value.ToString()),
                decimal.Parse(row[3].Value.ToString()),
                int.Parse(row[6].Value.ToString()),
                row[4].Value.ToString(),
                factor_id,
                false
                );
            using(Payment_methods screen = new Payment_methods(this.client, this.sub_factors_id, transaction))
            {
                screen.ShowDialog();
                if(screen.method != null && screen.method != transaction)
                {
                    transaction = screen.method;
                    payments_llist.Rows[id].Cells[1].Value = transaction.transaction_type;
                    payments_llist.Rows[id].Cells[2].Value = transaction.bank;
                    payments_llist.Rows[id].Cells[3].Value = transaction.price;
                    payments_llist.Rows[id].Cells[4].Value = transaction.transaction_date;
                    payments_llist.Rows[id].Cells[5].Value = transaction.bank_id;
                }
            }
        }
    }
}
