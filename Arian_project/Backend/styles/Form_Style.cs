using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arian_project.Backend.styles
{
    public class Form_Styles
    {
        private readonly Theme_style theme = new Theme_style();
        private readonly Arian_project.Properties.Settings Props = Properties.Settings.Default;

        private Font Get_List_Font()
        {
            try
            {
                string fontName = Props.Font_Name ?? "Segoe UI"; // Fallback font
                int fontSize = Props.Font_Size > 0 ? Props.Font_Size : 10; // Fallback size
                FontStyle fontStyle = Props.Font_Bold ? FontStyle.Bold : FontStyle.Regular;
                return new Font(fontName, fontSize, fontStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Font creation failed: {ex.Message}", "Error");
                return new Font("Segoe UI", 10, FontStyle.Regular);
            }
        }

        public void Style(Form form)
        {
            if (form == null) return;

            Font font = Get_List_Font();
            Color btColor = theme.Theme_Bt_Color.IsEmpty ? Color.FromArgb(33, 150, 243) : theme.Theme_Bt_Color; // Fallback color
            Color bgColor = Props.Background_Colour.IsEmpty ? Color.White : Props.Background_Colour; // Fallback
            bool themeMode = Props.Theme_Dark_Light;
            Color lbColor = themeMode ? Color.White : Color.Black;

            form.BackColor = bgColor;

            ApplyStylesToControls(form.Controls, font, btColor, lbColor, bgColor);
        }

        private void ApplyStylesToControls(Control.ControlCollection controls, Font font, Color btColor, Color lbColor, Color bgColor)
        {
            foreach (Control control in controls)
            {
                try
                {
                    if (control is Button || control.GetType().Name == "GlassButton") 
                    {
                        control.BackColor = btColor;
                        control.ForeColor = lbColor;
                        control.Font = font;

                    }else if (control is Panel && control.GetType().Name == "RoundPanel") { 
                        control.BackColor = theme.Theme_Secondary_Color;
                    }else if(control is Panel)
                    {
                        control.BackColor = bgColor;
                    }
                    else if (control is Label)
                    {
                        control.Font = font;
                        control.ForeColor = lbColor;
                    }

                    if (control.HasChildren)
                    {
                        ApplyStylesToControls(control.Controls, font, btColor, lbColor, bgColor);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error styling control {control.Name}: {ex.Message}", "Error");
                }
            }
        }
    }
}