using Arian_project.Backend;
using Arian_project.backend;
using System;
using System.Drawing;
using System.Windows.Forms;
using ghest.Backend.Logs;
using Arian_project.Backend.Database;

namespace Arian_project.screens
{
    public partial class Main_screen : Form
    {
        Users_database users_db = null;
        private Admin user = Admin.Empty();
        public Main_screen()
        {
            new Database_data().check_directorys();
            new log().init_logs();
            bool loged_in = false;
            users_db = new Users_database();
            if (users_db.get_users_count() == 0)
            {
                using (Create_Admin screen = new Create_Admin())
                {
                    screen.ShowDialog();
                    if (screen.admin.id != 0)
                    {
                        using (Login_screen screen1 = new Login_screen())
                        {
                            screen1.ShowDialog();
                            if (screen1.can_Login)
                            {
                                loged_in = true;
                            }

                        }
                    }
                }
            }
            else
            {
                using (Login_screen screen1 = new Login_screen())
                {
                    screen1.ShowDialog();
                    if (screen1.can_Login)
                    {
                        loged_in = true;
                        if (loged_in)
                        {
                            this.user = screen1.user;
                            new Users_database().Set_Admin(this.user);
                        }
                    }

                }
            }

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            if (loged_in)
            {
                main_part_of_jobs();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
        private void main_part_of_jobs()
        {
            new Installment_Manager().check_day_status();
        }

        private void Main_screen_Load(object sender, EventArgs e)
        {
            Set_From_Style();
        }

        private void Set_From_Style()
        {
            Theme_style theme = new Theme_style();
            this.BackColor = theme.Theme_Mode ? theme.Dark_Theme_Main_Color : theme.Light_Theme_Main_Color;
            widgets_panel.BackColor = theme.Theme_Secondary_Color;
            
            Color bt_color =theme.Theme_Bt_Color;

            Font app_font = theme.app_font();
            buy_screen_bt.Font = app_font;
            cell_screen_Bt.Font = app_font;
            services_screen_bt.Font = app_font;
            clients_screen_bt.Font= app_font;
            card_readers_screen_bt.Font = app_font;
            banks_screen_bt.Font = app_font;
            stores_screen_bt.Font = app_font;
            instalments_screen_bt.Font = app_font;
            debs_screen_bt.Font = app_font;
            setting_screen_bt.Font = app_font;
            Exit_bt.Font = app_font;

            buy_screen_bt.BackColor = bt_color;
            cell_screen_Bt.BackColor = bt_color;
            services_screen_bt.BackColor= bt_color;
            clients_screen_bt.BackColor =bt_color;
            card_readers_screen_bt.BackColor = bt_color ;
            banks_screen_bt.BackColor = bt_color ;
            stores_screen_bt.BackColor = bt_color ;
            instalments_screen_bt.BackColor = bt_color;
            debs_screen_bt.BackColor = bt_color;
            setting_screen_bt.BackColor = bt_color;
            Exit_bt.BackColor = bt_color;
        }

        private void buy_screen_bt_Click(object sender, EventArgs e)
        {
            if (this.user.Ac_add_buy_factor())
            {
                Buy_Item buyScreen = new Buy_Item(true);
                buyScreen.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void setting_screen_bt_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
            Set_From_Style();
        }

        private void cell_screen_Bt_Click(object sender, EventArgs e)
        {
            if (this.user.Ac_add_cell_factor())
            {
                Buy_Item buyScreen = new Buy_Item(false);
                buyScreen.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void Exit_bt_Click(object sender, EventArgs e)
        {
            new Users_database().Unset_Admin();
            System.Environment.Exit(0);
        }

        private void clients_screen_bt_Click(object sender, EventArgs e)
        {
            if (this.user.Ac_client_managment())
            {
                Clients_Detailes screen = new Clients_Detailes();
                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void banks_screen_bt_Click(object sender, EventArgs e)
        {
            if (this.user.Ac_Banks_managment())
            {
                Banks banks_screen = new Banks();
                banks_screen.ShowDialog();

            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void card_readers_screen_bt_Click(object sender, EventArgs e)
        {
            if (this.user.Ac_Card_Readers_managment())
            {
                Card_Readers screen = new Card_Readers();
                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void stores_screen_bt_Click(object sender, EventArgs e)
        {
            if (this.user.Ac_store_managment())
            {
                Add_Item screen = new Add_Item();
                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void services_screen_bt_Click(object sender, EventArgs e)
        {
            if (this.user.Ac_Services_managment())
            {
                Services screen = new Services();
                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void factors_screen_bt_Click(object sender, EventArgs e)
        {
            if(this.user.Ac_edite_buy_factor() && this.user.Ac_add_cell_factor())
            {

                Factors_screen screen = new Factors_screen();
                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void instalments_screen_bt_Click(object sender, EventArgs e)
        {
            if (this.user.Ac_pay_installment())
            {
                Installments_Screen screen = new Installments_Screen();
                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void debs_screen_bt_Click(object sender, EventArgs e)
        {
            if (this.user.Ac_debt_managment())
            {
                Debts_screen screen = new Debts_screen();
                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            if(this.user.access == "1111111111111")
            {
                using(User_Control_Screen screen = new User_Control_Screen())
                {
                    screen.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("شما به این قسمت دسترسی ندارید", "دسترسی");
            }
        }

        private void Main_screen_Leave(object sender, EventArgs e)
        {

            new Users_database().Unset_Admin();
        }

        private void Main_screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Users_database().Unset_Admin();
        }
    }
}
