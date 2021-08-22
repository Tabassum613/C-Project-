using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineersPortal
{
    public partial class User_Management : Form
    {
        public User_Management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_User_Management studentUserManagement = new Student_User_Management();
            studentUserManagement.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Professional_User_Management professionalUserManagement = new Professional_User_Management();
            professionalUserManagement.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
