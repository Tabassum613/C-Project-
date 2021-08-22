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
    public partial class Post_Blogs : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Post_Blogs()
        {
            InitializeComponent();
            textBox3.Text = Login.username.ToString();
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



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Post_Blogs_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                SqlConnection c = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Insert into Blog Values(@blogDescription, @blogTitle, @blogAuthorName, @blogPicture)", c);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@blogDescription", textBox1.Text);
                cmd.Parameters.AddWithValue("@blogTitle", textBox2.Text);
                cmd.Parameters.AddWithValue("@blogAuthorName", textBox3.Text);
                cmd.Parameters.AddWithValue("@blogPicture", SavePhoto());

                c.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Blog has been posted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
