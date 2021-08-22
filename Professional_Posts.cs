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
    public partial class Professional_Posts : Form
    {
        public Professional_Posts()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Professional_Dashboard professionalDashboard = new Professional_Dashboard();
            professionalDashboard.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
                Notice notice = new Notice();
                notice.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Blogs blogs = new Blogs();
            blogs.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Solution solution = new Solution();
            solution.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Portfolio portfolio = new Portfolio();
            portfolio.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Job_Circular jobCircular = new Job_Circular();
            jobCircular.Show();
        }
    }
}
