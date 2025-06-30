using System.Windows.Forms;
using Arian_project.backend.Database;
using ghest.Backend.Logs;

namespace Arian_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new log().init_logs();
            Database databse = new Database();
            databse.check_directorys();
        }
    }
}
