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

        private void Form1_Load(object sender, EventArgs e)
        {

            var backend = new Database_data();
            backend.check_directorys();

            //var transaction_db = new transactions_database();
            //Transaction transaction = new Transaction(1,"aaaa","melo",75000,1,"1404/5/8","recived");
            //var result = transaction_db.delete_transaction_from_database(3);
            //int users_count = transaction_db.transactions_list().Count();
            //MessageBox.Show(users_count.ToString(), "count");
            //MessageBox.Show(result.ToString(), "count");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form users = new Clients_Detailes();
            users.ShowDialog();
        }
    }
}
