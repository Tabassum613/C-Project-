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
    public partial class Professional_Dashboard : Form
    {
        public Professional_Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Professional_Posts professionalPosts = new Professional_Posts();
            professionalPosts.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Professionals_Make_Post professionalMakePost = new Professionals_Make_Post();
            professionalMakePost.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Professional_Profile professional_profile = new Professional_Profile();
            professional_profile.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Chatting_Professional chattingProfessional = new Chatting_Professional();
            chattingProfessional.Show();
            this.Hide();
        }
    }
}
