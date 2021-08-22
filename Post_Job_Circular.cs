using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace EngineersPortal
{
    public partial class Post_Job_Circular : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Post_Job_Circular()
        {
            InitializeComponent();
            textBox3.Text = Login.username.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                SqlConnection c = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Insert into jobCircular Values(@jobCircularDescription, @jobCircularTitle, @jobCircularPicture, @jobCircularAuthor)", c);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@jobCircularDescription", textBox1.Text);
                cmd.Parameters.AddWithValue("@jobCircularTitle", textBox2.Text);
                cmd.Parameters.AddWithValue("@jobCircularAuthor", textBox3.Text);
                cmd.Parameters.AddWithValue("@jobCircularPicture", SavePhoto());

                c.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Job Circular has been posted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                c.Close();
            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox3.Image.Save(ms, pictureBox3.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox3.Image = new Bitmap(open.FileName);
            }
        }

        private void Post_Job_Circular_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
