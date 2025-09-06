using System;
using System.Windows.Forms;

namespace Arian_project.screens
{
    public partial class PMessageBox : Form
    {
        public Button result { get; set; }
        public PMessageBox(string title,string text, Button[] buttons)
        {
            InitializeComponent();
            load_screen(title,text,buttons);
        }
        private void load_screen(string title, string text, Button[] buttons) {
            this.Text = title;
            this.text_lb.Text = text;

            TableLayoutPanel panel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = buttons.Length,
                RowCount = 1 
            };

            int index = 0;
            foreach (Button bt in buttons)
            {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / buttons.Length));
                bt.Dock = DockStyle.Fill;
                bt.Click += (sender, e) => button_clicked(bt, e);
                panel.Controls.Add(buttons[index], index, 0);
                index++;
            }
           
            tableLayoutPanel1.Controls.Add(panel, 0, 1);
        }

        private void button_clicked(Button sender, EventArgs e) {
            this.result = sender;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
