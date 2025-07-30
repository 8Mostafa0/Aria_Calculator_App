using System;
using System.Linq;
using System.Windows.Forms;
using Arian_project.backend;
using Arian_project.screens;

namespace Arian_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            var addItem = new Add_Item();
            addItem.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var backend = new Database_data();
            backend.check_directorys();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var users = new Clients_Detailes();
            users.ShowDialog();
        }
    }
}
