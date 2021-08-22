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
    public partial class Post_Management : Form
    {
        public Post_Management()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Blog_Post_Management blogManagement = new Blog_Post_Management();
            blogManagement.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Solution_Post_Management solutionManagement = new Solution_Post_Management();
            solutionManagement.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Portfolio_Post_Management portfolioManagement = new Portfolio_Post_Management();
            portfolioManagement.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Job_Circular_Post_Management jobCircularPostManagement = new Job_Circular_Post_Management();
            jobCircularPostManagement.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Notice_Post_Management noticeManagement = new Notice_Post_Management();
            noticeManagement.Show();
            this.Hide();
        }
    }
}
