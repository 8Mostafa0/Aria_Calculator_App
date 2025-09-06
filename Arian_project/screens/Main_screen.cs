using Arian_project.Backend;
using Arian_project.backend;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Main_screen : Form
    {
        public Main_screen()
        {
            InitializeComponent();
            new Database_data().check_directorys();
            this.WindowState = FormWindowState.Maximized;
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
            Buy_Item buyScreen = new Buy_Item(true);
            buyScreen.ShowDialog();
            //this.Hide();
        }

        private void setting_screen_bt_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
            Set_From_Style();
        }

        private void cell_screen_Bt_Click(object sender, EventArgs e)
        {

            Buy_Item buyScreen = new Buy_Item(false);
            buyScreen.ShowDialog();
        }

        private void Exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clients_screen_bt_Click(object sender, EventArgs e)
        {
            Clients_Detailes screen = new Clients_Detailes();
            screen.ShowDialog();
        }

        private void banks_screen_bt_Click(object sender, EventArgs e)
        {
            Banks banks_screen = new Banks();
            banks_screen.ShowDialog();
        }

        private void card_readers_screen_bt_Click(object sender, EventArgs e)
        {
            Card_Readers screen = new Card_Readers();
            screen.ShowDialog();
        }

        private void stores_screen_bt_Click(object sender, EventArgs e)
        {

            Add_Item screen = new Add_Item();
            screen.ShowDialog();
        }

        private void services_screen_bt_Click(object sender, EventArgs e)
        {
            Services screen = new Services();
            screen.ShowDialog();
        }

        private void factors_screen_bt_Click(object sender, EventArgs e)
        {
            Factors_screen screen = new Factors_screen();
            screen.ShowDialog();
        }
    }
}
