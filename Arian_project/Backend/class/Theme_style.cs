
using System.Drawing;

namespace Arian_project.Backend
{
    public class Theme_style
    {
        public int List_Font_Size { get; set; }
        public int FontSize { get; set; }
        public bool List_Font_Bold { get; set; }
        public bool Font_Bold { get; set; }
        public Color Light_Theme_Main_Color { get; set; }
        public Color Dark_Theme_Main_Color { get; set; }
        public Color Theme_Secondary_Color { get; set; }
        public Color Theme_Accent_Color { get; set; }
        public bool Theme_Mode { get; set; }
        public string Theme_Font { get; set; }
        public Color Theme_Bt_Color { get; set; }
        public Font Theme_Bt_Font { get; set; }
        public bool Theme_Bt_Font_Bold { get; set; }
        public int Theme_Bt_Font_Size { get; set; }
        public Font Theme_Lb_Font { get; set; }
        public bool Theme_Lb_Font_Bold { get; set; }
        public int Theme_Lb_Font_Size { get; set; }

        private Arian_project.Properties.Settings Props = Properties.Settings.Default;
        public Theme_style()
        {


            this.List_Font_Size = Props.List_Font_Size;
            this.FontSize = Props.Font_Size;
            this.List_Font_Bold= Props.List_Font_Bold;
            this.Font_Bold = Props.Font_Bold;
            this.Dark_Theme_Main_Color = Props.Dark_Theme_Main_Color;
            this.Light_Theme_Main_Color = Props.Light_Theme_Main_Color;
            this.Theme_Secondary_Color = Props.Theme_Secondary_Color;
            this.Theme_Accent_Color = Props.Theme_Accent_Color;
            this.Theme_Mode = Props.Theme_Mode;
            this.Theme_Bt_Color = Props.Theme_Bt_Color;
            this.Theme_Font = Props.Theme_Font;
            this.Theme_Bt_Font = Props.Theme_Bt_Font;
            this.Theme_Bt_Font_Bold = Props.Theme_Bt_Font_Bold;
            this.Theme_Bt_Font_Size = Props.Theme_Bt_Font_Size;
            this.Theme_Lb_Font = Props.Theme_Lb_Font;
            this.Theme_Lb_Font_Bold = Props.Theme_Lb_Font_Bold;
            this.Theme_Lb_Font_Size = Props.Theme_Lb_Font_Size;
        }


        public void Change_Thme_Font(string font_name) { 
            this.Theme_Font = font_name;
            this.Save_Changes();
        }

        public void Chane_Theme_Secondary_Color(Color color)
        {
            this.Theme_Secondary_Color = color;
            this.Save_Changes();
        }
        public Font app_font()
        {
            return new Font(this.Theme_Font, this.FontSize, this.Font_Bold ? FontStyle.Bold : FontStyle.Regular);
        }
        public void Save_Changes()
        {

            Props.List_Font_Size = this.List_Font_Size;
            Props.Font_Size = this.FontSize ;
            Props.List_Font_Bold = this.List_Font_Bold;
            Props.Font_Bold = this.Font_Bold ;
            Props.Dark_Theme_Main_Color = this.Dark_Theme_Main_Color;
            Props.Light_Theme_Main_Color = this.Light_Theme_Main_Color;
            Props.Theme_Secondary_Color = this.Theme_Secondary_Color;
            Props.Theme_Accent_Color = this.Theme_Accent_Color;
            Props.Theme_Mode = this.Theme_Mode;
            Props.Theme_Font = this.Theme_Font;
            Props.Theme_Bt_Color = this.Theme_Bt_Color;
            Props.Theme_Bt_Font = this.Theme_Bt_Font;
            Props.Theme_Bt_Font_Bold = this.Theme_Bt_Font_Bold;
            Props.Theme_Bt_Font_Size = this.Theme_Bt_Font_Size;
            Props.Theme_Lb_Font = this.Theme_Lb_Font;
            Props.Theme_Lb_Font_Bold = this.Theme_Lb_Font_Bold;
            Props.Theme_Lb_Font_Size = this.Theme_Lb_Font_Size;
            Props.Save();
        }
    }
}
