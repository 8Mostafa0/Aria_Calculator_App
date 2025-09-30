using Arian_project.Backend;
using Arian_project.Backend.Database;
using Arian_project.Backend.styles;
using System;

using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Login_screen : Form
    {
        public bool can_Login = false;
        public Admin user = Admin.Empty();
        Users_database users_db = new Users_database();
        private bool show_pass = false;
        public Login_screen()
        {
            InitializeComponent();
            new Form_Styles().Style(this);
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            if (tb_username.Text != "" || tb_passwprod.Text != "")
            {
                string username = tb_username.Text;
                string password = tb_passwprod.Text;
                if (users_db.admin_login(username, password)) {
                    this.can_Login = true;
                    user = users_db.get_admin_data(username, password);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور درست واد نشده است", "خطا");
                }
            }
            else
            {
                    MessageBox.Show("لطفا ابتدا نام کاربری و رمز عبور را وارد کنید", "خطا");
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

            if (show_pass)
            {
                pass_img.Image = Arian_project.Properties.Resources.round_visibility_black_24dp1;
                tb_passwprod.UseSystemPasswordChar = false;
            }
            else
            {
                pass_img.Image = Arian_project.Properties.Resources.round_visibility_off_black_24dp1;
                tb_passwprod.UseSystemPasswordChar = true;
            }
            show_pass = !show_pass;
        }
    }
}
