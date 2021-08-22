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
    public partial class Student_Dashboard : Form
    {
        public Student_Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Student_Posts studentPosts = new Student_Posts();
            studentPosts.Show();
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
            Students_Make_Post studentMakePost = new Students_Make_Post();
            studentMakePost.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Student_Profile student_profile = new Student_Profile();
            student_profile.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Chatting_Student chattingStudent = new Chatting_Student();
            chattingStudent.Show();
            this.Hide();
        }
    }
}
