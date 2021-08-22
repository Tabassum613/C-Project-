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
    public partial class Student_Registration : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Student_Registration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox6.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox6.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login signin = new Login();
            signin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (isvalid())
                {
                    SqlConnection c = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("Insert into Student Values(@FullName,@Username,@Gender,@Email,@Education,@Password,@ProfilePicture)", c);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Username", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Education", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox6.Text);
                    cmd.Parameters.AddWithValue("@ProfilePicture", SavePhoto());
                    c.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    c.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Insert", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            

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

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox3.Image.Save(ms, pictureBox3.Image.RawFormat);
            return ms.GetBuffer();
        }

        public bool isvalid()
        {
            if (textBox6.Text == String.Empty)
            {
                MessageBox.Show("Password is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login signin = new Login();
            signin.Show();
            this.Hide();
        }

        private void Student_Registration_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login signin = new Login();
            signin.Show();
            this.Hide();
        }
        
    }
}
