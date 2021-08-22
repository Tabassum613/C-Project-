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
    public partial class Students_Make_Post : Form
    {
        public Students_Make_Post()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Student_Dashboard studentDashboard = new Student_Dashboard();
            studentDashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Post_Blogs postBlogs = new Post_Blogs();
            postBlogs.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Post_Question postQuestion = new Post_Question();
            postQuestion.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Post_Portfolio postPortfolio = new Post_Portfolio();
            postPortfolio.Show();
        }
    }
}
