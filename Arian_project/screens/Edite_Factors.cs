using Arian_project.backend;
using Arian_project.Backend;
using Arian_project.Backend.styles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Edite_Factors : Form
    {
        public bool Buy_Screen { get; set; }
        public Client client {  get; set; }

        Factors_database factors_db = new Factors_database();
        Stores_database stors_db = new Stores_database();
        Database_data db = new Database_data();
        sub_factors_database sub_factor_db = new sub_factors_database();
        Transactions_database transaction_db = new Transactions_database();
        Clients_database clients_db = new Clients_database();
        Style style = new Style();
        public int factor_id { get; set; }

        public int sub_factors_id = 1;

        public string today_string { get; set; }
        private decimal payments_full_price { get; set; }
        private decimal items_full_profit { get; set; }
        private decimal items_full_price { get; set; }

        private List<Transaction> old_factor_transactions = new List<Transaction>();
        private List<Store> old_factor_items = new List<Store>();
        private List<Sub_factor> old_factor_sub_factors = new List<Sub_factor>();
        private Factor factor {  get; set; }
        public Edite_Factors(Factor factor)
        {
            InitializeComponent();
            this.items_full_price = 0;
            this.items_full_profit = 0;
            this.payments_full_price = 0;
            this.Buy_Screen = factor.factor_type == "خرید"?true:false;
            this.WindowState = FormWindowState.Maximized;
            list_items.KeyDown += list_items_KeyDown;
            this.Text = factor.factor_type;
            this.factor = factor;
            Load_Screen();
        }

        private void load_all_items_of_factor()
        {
            List<Sub_factor> items =  sub_factor_db.get_sub_factor_of_factor(this.factor.id);
            foreach(Sub_factor item in items)
            {
                Store st = Store.Get_Store_From_Sub_Factor(item);
                this.old_factor_sub_factors.Add(item);
                this.old_factor_items.Add(st);
                add_item_to_list(st);
            }
        }

        private void load_all_transactions()
        {
            List<Transaction> items = transaction_db.get_transactions_of_factor(this.factor.id);
            foreach(Transaction item in items)
            {
                this.old_factor_transactions.Add(item);
                Add_Transaction = item;
            }
        }
        private void set_client_of_factor() {
            Client user = clients_db.Get_Client_by_id(this.factor.client_id);
            if (user != null) { 
                this.client = user;
                Client_Name_tb.Text = user.user_name;
                Client_phone_tb.Text = user.phone_number;
            }
        }
        private void Load_Screen()
        {
            Set_Style();
            Set_Factor_id();
            set_date();
            load_all_items_of_factor();
            load_all_transactions();
            set_client_of_factor();
        }
        private void set_date()
        {
            Date_lb.Text = this.factor.factor_date;
            this.today_string = this.factor.factor_date;
        }
        private void Set_Factor_id()
        {
            this.factor_id = this.factor.id;
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
            new Form_Styles().Style(this);
            style.Payments_list_style(payments_llist);
            style.Store_Items_List(list_items);
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
                row.Cells[4].Value = item.cell_price;
                row.Cells[5].Value = item.count;
                row.Cells[6].Value = item.buy_date;
                row.Cells[7].Value = item.cell_date;
                row.Cells[8].Value = item.service_item;
                row.Cells[9].Value = this.factor.factor_type=="خرید"?(item.count * item.buy_price): (item.count * item.cell_price);
                row.Cells[10].Value = item.id;
                rows.Add(row);
                list_items.Rows.AddRange(rows.ToArray());
                list_items.ClearSelection();
            }
            else
            {
                MessageBox.Show("این ایتم در لیست موجود است", "ایتم انتخاب شده");
            }

            count_full_factor_price();
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
                    if (i.Cells[3].Value != null && i.Cells[5].Value != null && i.Cells[3].Value.ToString() != "" && i.Cells[5].Value.ToString() != "")
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

                        if (item_id == 0)
                        {
                            list_items.Rows[e.RowIndex].Cells[1].Value = stors_db.get_last_item_store_id();
                            list_items.Rows[e.RowIndex].Cells[6].Value = today_string;
                            list_items.Rows[e.RowIndex].Cells[7].Value = "";
                            list_items.Rows[e.RowIndex].Cells[8].Value = "خیر";
                        }
                        else
                        {
                            if (this.factor.factor_type == "فروش")
                            {
                                int store_count = stors_db.get_item_by_id(item_id).count;
                        
                                if(store_count < count)
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
                    row.Cells[9].Value != null)
                {
                    try
                    {
                        int id = 0;
                        int store_id;
                        string item_name;
                        int buy_price;
                        int cell_price;
                        int count;
                        decimal full_price;

                        if (!int.TryParse(row.Cells[1].Value.ToString(), out store_id) ||
                            row.Cells[2].Value.ToString() == "" ||
                            !int.TryParse(row.Cells[3].Value.ToString(), out buy_price) ||
                            !int.TryParse(row.Cells[4].Value.ToString(), out cell_price) ||
                            !int.TryParse(row.Cells[5].Value.ToString(), out count)||
                            !decimal.TryParse(row.Cells[9].Value.ToString(), out full_price))
                        {
                            continue; 
                        }
                        if(row.Cells[10].Value == null)
                        {
                            item_name = row.Cells[2].Value.ToString();
                            Store item_ = stors_db.get_item_by_name(item_name);
                            if(item_ == null)
                            {
                                if (this.factor.factor_type == "خرید")
                                {
                                    id = stors_db.get_last_item_id();
                                }
                            }
                            else
                            {
                                id = item_.id;
                            }
                        }
                        else
                        {
                            if (!int.TryParse(row.Cells[10].Value.ToString(), out id))
                            {
                                if (this.factor.factor_type == "فروش")
                                {
                                    MessageBox.Show("لطفا ایتم ها را انتخاب کنید و به صورت دستی وارد نکنید", "ایتم ها");
                                }
                            }
                        }
                        Store item = new Store(
                            id,
                            store_id,
                            row.Cells[2].Value.ToString(),
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
                            this.items_full_price += (cell_price * count);
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
                                this.factor.id,
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
            List<Transaction> transactions = get_transactions_list();
            Factor factor = new Factor(
                this.factor_id,
                this.client.id,
                this.client.user_name,
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

        private void revert_bank_changes() {
            string message_type = "revert_bank_changes";
            string logger_message_type = "revert bank changes transaction of old factor in bank table";
            if (this.factor.factor_type == "خرید")
            {
                foreach(Transaction item in this.old_factor_transactions)
                {
                    string sql_query = $"UPDATE banks SET balance = balance + {item.price} WHERE id = {item.bank_id}";
                    db.run_sql_query(sql_query, message_type, logger_message_type);
                }
            }else if (this.factor.factor_type == "فروش")
            {

                foreach (Transaction item in this.old_factor_transactions)
                {
                    string sql_query = $"UPDATE banks SET balance = balance - {item.price} WHERE id = {item.bank_id}";
                    db.run_sql_query(sql_query, message_type, logger_message_type);
                }
            }
        }
        private void revert_store_items() {
            string message_type = "revert_store_items";
            string logger_message_type = "revert store cahnges of factor in store table";
            if(this.factor.factor_type == "خرید")
            {
                foreach(Store item in this.old_factor_items)
                {
                    string sql_query = $"UPDATE stors SET count = count - {item.count} WHERE id = {item.id}";
                    db.run_sql_query(sql_query,message_type,logger_message_type);
                }
            }else if(this.factor.factor_type == "فروش")
            {
                foreach (Store item in this.old_factor_items)
                {
                    string sql_query = $"UPDATE stors SET count = count + {item.count} WHERE id = {item.id}";
                    db.run_sql_query(sql_query, message_type, logger_message_type);
                }
            }
        }

        private void revert_sub_factors(){ 
            foreach(Sub_factor item in this.old_factor_sub_factors)
            {
                sub_factor_db.delete_sub_factor_from_database(item.id);
            } 
        }
        private void revert_transactions() { 
            foreach(Transaction item in old_factor_transactions)
            {
                transaction_db.delete_transaction_from_database(item.id);
            }
        }
        private void reverst_factor_changes(){ 
            revert_store_items();
            revert_bank_changes();
            revert_sub_factors();
            revert_transactions();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            reverst_factor_changes();
            string Message_type = "ثبت فاکتور";
            bool payed = false;

            if(client == null)
            {
                MessageBox.Show("لطفا مشتری را انتخاب کنید",Message_type);
            } else if (list_items.Rows.Count == 0) {
                MessageBox.Show("لطفا ایتمی را انتخاب کنید", Message_type);
            }else if (payments_llist.Rows.Count == 0) {

                var res =  MessageBox.Show("فاکتور به لیست پرداخت نشده ها اضافه شود؟", "اخطار",MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) {
                    payed = false;
                }
                else
                {
                    return;
                }
            }
            Factor factor = create_factor();
            if (!payed)
            {
                factor.factor_status = "پرداخت نشده";
            }
            if(this.payments_full_price < this.items_full_price)
            {
                DialogResult res =  MessageBox.Show("مبلغ پرداخت شده از مبلغ فاکتور کمتر است \n فاکتور پرداخت نشده باقی بماند؟", Message_type,MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    payed = false;
                }
                else
                {
                    return;
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
            bool result = save_factor_data(factor);
            if (result)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد", Message_type);
                this.Close();
            }
            else
            {
                MessageBox.Show("خطا در ثبت فاکتور", Message_type);
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
                    result = db.run_sql_query(query,"update items in store",$"change items count based on the factor {factor.id}");
                    if (!result)
                    {
                        MessageBox.Show("مشکلی در ثبت تغییرات انبار بوجود امده است", "ثبت تغییرات انبار");
                        return result;
                    }
                }
                else
                {
                    int stor_id = stors_db.get_last_item_store_id();
                    Store store = new Store(0, stor_id,sub.item_name, sub.buy_price, sub.cell_price, sub.count, sub.buy_date, sub.cell_date, sub.service_item);
                    result = stors_db.insert_item_to_database(store);
                    if (!result)
                    {
                        MessageBox.Show("مشکلی در ثبت تغییرات انبار بوجود امده است", "ثبت تغییرات انبار");
                        return result;
                    }
                }
            }
            return result;
        }
        private bool save_sub_factors(Factor factor)
        {
            bool result = false;
            foreach (Store sub in factor.items)
            {
                int id = sub_factor_db.sub_factors_counter() + 1;
                Sub_factor sub_factor = new Sub_factor(
                    id,
                    this.factor.id,
                    sub.id,
                    sub.buy_price,
                    sub.cell_price,
                    this.Buy_Screen?0: ((sub.cell_price - sub.buy_price)*sub.count),
                    sub.count
                    );
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
            try
            {

                result = factors_db.edite_factor_in_datebase(factor);
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "خطایی رخ داده است");
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
                using (Payment_methods screen = new Payment_methods(this.client.id, this.sub_factors_id,new Transaction(0, "0", "0", 0, 0, 0, "0",factor_id, false)))
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
            using(Payment_methods screen = new Payment_methods(this.client.id, this.sub_factors_id, transaction))
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
