
using System.Drawing;
using System.Windows.Forms;

namespace Arian_project.Backend.styles
{
    internal class Style
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

        public void Stores_List_Style(DataGridView List)
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

            List.Columns.Add("store_id", "ش انبار");
            List.Columns[1].DataPropertyName = "store_id";
            List.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("item_name", "نام ایتم");
            List.Columns[2].DataPropertyName = "item_name";
            List.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("buy_price", "قیمت خرید");
            List.Columns[3].DataPropertyName = "buy_price";
            List.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;


            List.Columns.Add("cell_price", "فیمت فروش");
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
    }
}
