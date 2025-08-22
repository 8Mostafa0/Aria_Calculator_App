using Arian_project.Backend;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            Set_Style_From();
            Setting_Load();
            set_fonst_combo_box();
        }
        Theme_style theme = new Theme_style();
        List<string> fonts = new List<string>()
            {
                "Arial",
                "Segoe UI",
                "Microsoft Sans Serif",
                "Cambria Math",
                "Sakkal Majalla"
            };
        private void Set_Style_From()
        {

            Font app_font = theme.app_font();

            this.BackColor = theme.Theme_Main_Color;



            Theme_Font_lb.Font = app_font;
            Theme_Font_Size_lb.Font = app_font;
            Theme_Font_Bold_lb.Font = app_font;

            List_Font_Size_lb.Font = app_font;
            List_Font_Bold_lb.Font = app_font;

            Theme_Bt_Color_lb.Font = app_font;
            Theme_Bt_Font_lb.Font = app_font;
            Theme_Bt_Font_Bold_lb.Font = app_font;
            Theme_Bt_Font_Size_lb.Font = app_font;

            Theme_Lb_Font_lb.Font = app_font;
            Theme_Lb_Font_Bold_lb.Font = app_font;
            Theme_Lb_Font_Size_lb.Font = app_font;

            Theme_Main_Color_lb.Font = app_font;
            Theme_Secondary_Color_lb.Font = app_font;
            Theme_Accent_Color_lb.Font = app_font;
            Theme_Mode_lb.Font = app_font;


            exit_bt.BackColor = theme.Theme_Bt_Color;
            save_bt.BackColor = theme.Theme_Bt_Color;

        }

        private void Setting_Load()
        {
            Theme_Font_tb.Text = theme.Theme_Font;
            Theme_Font_Size_tb.Text = theme.FontSize.ToString();
            Theme_Font_Bold_cb.Checked = theme.Font_Bold;

            List_Font_Size_tb.Text = theme.List_Font_Size.ToString();
            List_Font_Bold_cb.Checked = theme.List_Font_Bold;

            Theme_Bt_Color_pn.BackColor = theme.Theme_Bt_Color;
            Theme_Bt_Font_tb.Text = theme.Theme_Bt_Font.FontFamily.Name.ToString();
            Theme_Bt_Font_Bold_cb.Checked= theme.Theme_Bt_Font_Bold;
            Theme_Bt_Font_Size_tb.Text = theme.Theme_Bt_Font_Size.ToString();

            Theme_Lb_Font_tb.Text =theme.Theme_Lb_Font.Name.ToString();
            Theme_Lb_Font_Bold_cb.Checked= theme.Theme_Lb_Font_Bold;
            Theme_Lb_Font_Size_tb.Text = theme.Theme_Lb_Font_Size.ToString();

            Theme_Main_Color_pn.BackColor = theme.Theme_Main_Color;
            Theme_Secondary_Color_pn.BackColor = theme.Theme_Secondary_Color;
            Theme_Accent_Color_pn.BackColor = theme.Theme_Accent_Color;
            Theme_Mode_cb.Checked = theme.Theme_Mode;
        }

        private void set_fonst_combo_box()
        {
            Theme_Font_tb.DataSource = fonts;
            Theme_Bt_Font_tb.DataSource = fonts;
            Theme_Lb_Font_tb.DataSource = fonts;

        }

        private Color Get_Color(Color default_Color)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            DialogResult result = colorDialog1.ShowDialog();
            Color Target_Color = default_Color;
            if (result == DialogResult.OK)
            {
                Target_Color = colorDialog1.Color;
            }
            return Target_Color;
        }
        private void Theme_Bt_Color_pn_Click(object sender, EventArgs e)
        {
            Color Target = Get_Color(theme.Theme_Bt_Color);
            Theme_Bt_Color_pn.BackColor = Target;
            theme.Theme_Bt_Color = Target;
            Set_Style_From();
        }

        private void Theme_Main_Color_pn_Click(object sender, EventArgs e)
        {
            Color Target = Get_Color(theme.Theme_Main_Color);
            Theme_Main_Color_pn.BackColor = Target;
            theme.Theme_Main_Color = Target;
            Set_Style_From();
        }

        private void Theme_Secondary_Color_pn_Click(object sender, EventArgs e)
        {

            Color Target = Get_Color(theme.Theme_Accent_Color);
            Theme_Secondary_Color_pn.BackColor = Target;
            theme.Theme_Secondary_Color = Target;
            Set_Style_From();
        }

        private void Theme_Accent_Color_pn_Click(object sender, EventArgs e)
        {
            Color Target = Get_Color(theme.Theme_Secondary_Color);
            Theme_Accent_Color_pn.BackColor = Target;
            theme.Theme_Accent_Color = Target;
            Set_Style_From();
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            theme.Save_Changes();
            this.Close();
        }
    }
}
 