using Arian_project.Backend;
using Arian_project.Backend.Database;
using System;

using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Create_Admin : Form
    {
        public Admin admin = Admin.Empty();
        Users_database users_db = new Users_database();
        public Create_Admin()
        {
            InitializeComponent();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            if(
                tb_username.Text !=""||
                tb_password.Text != "" ||
                tb_repassword.Text != ""
                )
            {
                if(tb_password.Text == tb_repassword.Text)
                {
                    this.admin = new Admin(1, tb_username.Text, tb_password.Text, "1111111111111");
                    bool result = users_db.insert_user_in_database(admin);
                    if (result)
                    {
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("مشکلی هنگام ذخیره سازی بوجود امده است", "حساب ادمین");
                    }
                }
                else
                {
                    MessageBox.Show("رمز عبور یکسان نیست","رمز عبور");
                }
            }
        }
    }
}
