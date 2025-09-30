
using System.Drawing;
using System.Windows.Forms;

namespace Arian_project.Backend.styles
{
    public class Style
    {

        private Arian_project.Properties.Settings Props = Properties.Settings.Default;
        private Font Get_List_Font()
        {
            string Font_Name = Props.Font_Name;
            int List_Font_Size = Props.List_Font_Size;
            bool List_Font_Bold = Props.List_Font_Bold;
            FontStyle Bold = Props.List_Font_Bold ? FontStyle.Bold : FontStyle.Regular;
            Font List_Font = new Font(Font_Name, List_Font_Size, Bold);
            return List_Font;
        }

        private Font Get_Font()
        {
            string Font_Name = Props.Font_Name;
            int Font_Size = Props.List_Font_Size;
            bool Font_Bold = Props.List_Font_Bold;
            FontStyle Bold = Props.List_Font_Bold ? FontStyle.Bold : FontStyle.Regular;
            Font Font = new Font(Font_Name, Font_Size, Bold);
            return Font;
        }

        public void Store_Items_List(DataGridView List)
        {

            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.MultiSelect = false;
            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            //List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //List.AllowUserToAddRows = false;



            List.Columns.Clear();

            List.Columns.Add("id", "ش");
            List.Columns[0].DataPropertyName = "id";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("store_id", "ش انبار");
            List.Columns[1].DataPropertyName = "store_id";
            List.Columns[1].Visible = false;
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("item_name", "نام ایتم");
            List.Columns[2].DataPropertyName = "item_name";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("buy_price", "قیمت خرید");
            List.Columns[3].DataPropertyName = "buy_price";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("cell_price", "قیمت فروش");
            List.Columns[4].DataPropertyName = "cell_price";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("count", "تعداد");
            List.Columns[5].DataPropertyName = "count";
            List.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("buy_date", "تاریخ خرید");
            List.Columns[6].DataPropertyName = "buy_data";
            List.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[6].Visible = false;

            List.Columns.Add("cell_date", "تاریخ فروش");
            List.Columns[7].DataPropertyName = "cell_date";
            List.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[7].Visible = false;

            List.Columns.Add("service_item", "ایتم خدماتی");
            List.Columns[8].DataPropertyName = "service_item";
            List.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[8].Visible = false;


            List.Columns.Add("full_price", "قیمت کل");
            List.Columns[9].DataPropertyName = "full_price";
            List.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("item_id", "ش ایتم");
            List.Columns[10].DataPropertyName = "item_id";
            List.Columns[10].Visible = false;
            List.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;


        }
        public void Stores_List_Style(DataGridView List)
        {
            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.MultiSelect = false;
            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            //List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            //List.AllowUserToAddRows = false;
            


            List.Columns.Clear();

            List.Columns.Add("id","ش");
            List.Columns[0].DataPropertyName = "id";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("store_id", "ش انبار");
            List.Columns[1].DataPropertyName = "store_id";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("item_name", "نام ایتم");
            List.Columns[2].DataPropertyName = "item_name";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("buy_price", "قیمت خرید");
            List.Columns[3].DataPropertyName = "buy_price";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("cell_price", "قیمت فروش");
            List.Columns[4].DataPropertyName = "cell_price";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("count", "تعداد");
            List.Columns[5].DataPropertyName = "count";
            List.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("buy_date", "تاریخ خرید");
            List.Columns[6].DataPropertyName = "buy_data";
            List.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("cell_date", "تاریخ فروش");
            List.Columns[7].DataPropertyName = "cell_date";
            List.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("service_item", "ایتم خدماتی");
            List.Columns[8].DataPropertyName = "service_item";
            List.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void Services_List_Style(DataGridView List)
        {

            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;

            List.Columns.Clear();

            List.Columns.Add("number", "ش");
            List.Columns[0].DataPropertyName = "number";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("id", "ش");
            List.Columns[1].DataPropertyName = "id";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[1].Visible = false;

            List.Columns.Add("item_id", "ش");
            List.Columns[2].DataPropertyName = "item_id";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[2].Visible = false;

            List.Columns.Add("service_name", "نام سرویس");
            List.Columns[3].DataPropertyName = "service_name";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("cell_price", "قیمت فروش");
            List.Columns[4].DataPropertyName = "cell_price";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        public void Clients_List_Style(DataGridView List)
        {
            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();
            
            
            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;
              
            
            List.Columns.Clear();

            List.Columns.Add("id","ش");
            List.Columns[0].DataPropertyName = "id";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("user_name", "نام کاربر");
            List.Columns[1].DataPropertyName = "user_name";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("phone_number", "شماره همراه");
            List.Columns[2].DataPropertyName = "phone_number";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("home_number", "شماره تلفن");
            List.Columns[3].DataPropertyName = "home_number";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("company", "شرکت");
            List.Columns[4].DataPropertyName = "company";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("email", "ایمیل");
            List.Columns[5].DataPropertyName = "email";
            List.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("client_type", "نوع مشتری");
            List.Columns[6].DataPropertyName = "client_type";
            List.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("client_group", "گروه مشتری");
            List.Columns[7].DataPropertyName = "client_group";
            List.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        public void Payments_list_style(DataGridView List)
        {

            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;

            List.Columns.Clear();

            List.Columns.Add("number", "ش");
            List.Columns[0].DataPropertyName = "number";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("id", "ش");
            List.Columns[1].DataPropertyName = "id";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[1].Visible = false;

            List.Columns.Add("transaction_type", "نحوه پرداخت");
            List.Columns[2].DataPropertyName = "transaction_type";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("bank", "نام بانک");
            List.Columns[3].DataPropertyName = "bank";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("bank_id", "ایدی بانک");
            List.Columns[4].DataPropertyName = "bank_id";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[4].Visible = false;

            List.Columns.Add("price", "مبلغ");
            List.Columns[5].DataPropertyName = "price";
            List.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("client_id", "شماره مشتری");
            List.Columns[6].DataPropertyName = "client_id";
            List.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[6].Visible= false;

            List.Columns.Add("transaction_date", "تاریخ پرداخت");
            List.Columns[7].DataPropertyName = "transaction_date";
            List.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("factor_id", "ایدی فاکتور");
            List.Columns[8].DataPropertyName = "factor_id";
            List.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[8].Visible = false;

            List.Columns.Add("installment_factor", "فاکتور اقساط");
            List.Columns[9].DataPropertyName = "installment_factor";
            List.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[9].Visible = false;
        }
        public void Banks_List_Style(DataGridView List)
        {
            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;

            List.Columns.Clear();

            List.Columns.Add("id","ش");
            List.Columns[0].DataPropertyName = "id";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("name", "نام");
            List.Columns[1].DataPropertyName = "name";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("bank_type", "نوع حساب");
            List.Columns[2].DataPropertyName = "bank_type";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("balance", "موجودی");
            List.Columns[3].DataPropertyName = "balance";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void Card_Reader_List_Style(DataGridView List)
        {
            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();


            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;

            List.Columns.Clear();

            List.Columns.Add("id","ش");
            List.Columns[0].DataPropertyName = "id";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("bank_id", "بانک متصل");
            List.Columns[1].DataPropertyName = "bank_id";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("name", "نام");
            List.Columns[2].DataPropertyName = "name";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    
        public void Factor_list_style(DataGridView List)
        {

            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;

            List.Columns.Clear();

            List.Columns.Add("id", "ش");
            List.Columns[0].DataPropertyName = "id";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("client_id", "ایدی مشتری");
            List.Columns[1].DataPropertyName = "client_id";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("client_name", "نام مشتری");
            List.Columns[2].DataPropertyName = "client_name";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("factor_type", "نوع");
            List.Columns[3].DataPropertyName = "factor_type";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("full_price", "قیمت کل");
            List.Columns[4].DataPropertyName = "full_price";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("profit", "سود");
            List.Columns[5].DataPropertyName = "profit";
            List.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("payed_price", "مبلغ پرداخت شده");
            List.Columns[6].DataPropertyName = "payed_price";
            List.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("factor_date", "تاریخ");
            List.Columns[7].DataPropertyName = "factor_date";
            List.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("client_group", "گروه مشتری");
            List.Columns[8].DataPropertyName = "client_group";
            List.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("factor_status", "وضعیت");
            List.Columns[9].DataPropertyName = "factor_status";
            List.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;

        }
        
        public void installment_dates_list_style(DataGridView List)
        {

            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;

            List.Columns.Clear();

            List.Columns.Add("id", "ش");
            List.Columns[0].DataPropertyName = "id";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("date", "تاریخ");
            List.Columns[1].DataPropertyName = "date";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("price", "مبلغ");
            List.Columns[2].DataPropertyName = "price";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("payed_price", "پرداختی");
            List.Columns[3].DataPropertyName = "payed_price";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("penalty_type", "نوع جریمه");
            List.Columns[4].DataPropertyName = "penalty_type";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("penalty_price_per_day", "جریمه روزانه");
            List.Columns[5].DataPropertyName = "penalty_price_per_day";
            List.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("penalty", "جریمه");
            List.Columns[6].DataPropertyName = "جریمه";
            List.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("status", "وضعیت");
            List.Columns[7].DataPropertyName = "status";
            List.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("installment_number", "شماره قسط");
            List.Columns[8].DataPropertyName = "installment_number";
            List.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[8].Visible = false;

            List.Columns.Add("installment_id", "شماره اقساط");
            List.Columns[9].DataPropertyName = "installment_id";
            List.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[9].Visible = false;
        }

        public void Installments_list_style(DataGridView List)
        {
            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;

            List.Columns.Clear();

            List.Columns.Add("id", "ش");
            List.Columns[0].DataPropertyName = "id";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("client_id", "ایدی مشتری");
            List.Columns[1].DataPropertyName = "id";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[1].Visible = false;

            List.Columns.Add("client_name", "نام مشتری");
            List.Columns[2].DataPropertyName = "client_name";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("factor_id", "شماره فاکتور");
            List.Columns[3].DataPropertyName = "factor_id";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[3].Visible = false;

            List.Columns.Add("installment_price", "مبلغ کل اقساط");
            List.Columns[4].DataPropertyName = "installment_price";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("first_installment", "شروع اقساط");
            List.Columns[5].DataPropertyName = "first_installment";
            List.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("one_installment_price", "مبلغ هر قسط");
            List.Columns[6].DataPropertyName = "one_installment_price";
            List.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("installment_count", "تعداد قسط");
            List.Columns[7].DataPropertyName = "installment_count";
            List.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("installment_payed_count", "تعداد پرداختی");
            List.Columns[8].DataPropertyName = "installment_payed_count";
            List.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("end_installment", "اتمام شده");
            List.Columns[9].DataPropertyName = "end_installment";
            List.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("next_reminder", "روز یاداوری");
            List.Columns[10].DataPropertyName = "next_reminder";
            List.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[10].Visible = false;

            List.Columns.Add("sms_days", "روز پیام");
            List.Columns[11].DataPropertyName = "sms_days";
            List.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[11].Visible = false;

            List.Columns.Add("status", "وضعیت");
            List.Columns[12].DataPropertyName = "status";
            List.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[12].Visible = false;

        }
        public void Debts_List_Style(DataGridView List)
        {
            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;

            List.Columns.Clear();

            List.Columns.Add("number", "ش");
            List.Columns[0].DataPropertyName = "number";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("id", "ش");
            List.Columns[1].DataPropertyName = "id";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[1].Visible = false;

            List.Columns.Add("name", "هزینه");
            List.Columns[2].DataPropertyName = "name";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("price", "مبلغ");
            List.Columns[3].DataPropertyName = "price";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("date", "تاریخ");
            List.Columns[4].DataPropertyName = "date";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("desciption", "توضیحات");
            List.Columns[5].DataPropertyName = "desciption";
            List.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("bank_id", "ایدی بانک");
            List.Columns[6].DataPropertyName = "bank_id";
            List.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[6].Visible = false;

            List.Columns.Add("bank_name", "پرداخت");
            List.Columns[7].DataPropertyName = "bank_name";
            List.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    
        public void Users_List_Style(DataGridView List) {

            Font List_Font = Get_List_Font();
            Font App_Font = Get_Font();

            List.ColumnHeadersDefaultCellStyle.Font = App_Font;
            List.Font = List_Font;
            List.EditMode = DataGridViewEditMode.EditProgrammatically;
            List.RightToLeft = RightToLeft.Yes;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            List.AllowUserToAddRows = false;

            List.Columns.Clear();

            List.Columns.Add("number", "ش");
            List.Columns[0].DataPropertyName = "number";
            List.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("id", "ش");
            List.Columns[1].DataPropertyName = "id";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[1].Visible = false;

            List.Columns.Add("username", "نام کاربری");
            List.Columns[2].DataPropertyName = "username";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("password", "رمز");
            List.Columns[3].DataPropertyName = "password";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            List.Columns.Add("access", "دسترسی ها");
            List.Columns[4].DataPropertyName = "access";
            List.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            List.Columns[4].Visible = false;
        }
    }
}
