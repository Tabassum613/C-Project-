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
    public partial class Student_Posts : Form
    {
        public Student_Posts()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Student_Posts_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Student_Dashboard studentDashboard = new Student_Dashboard();
            studentDashboard.Show();
            this.Hide();
        }
    }
}
