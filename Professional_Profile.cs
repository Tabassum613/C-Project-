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
    public partial class Professional_Profile : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Professional_Profile()
        {
            InitializeComponent();
            Professional_Get_Info();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Professional_Profile_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Professional_Get_Info()
        {
            SqlConnection c = new SqlConnection(cs);
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from ProfessionalUser where Username=@Username", c);
            cmd.Parameters.AddWithValue("@Username", Login.username.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    label15.Text = Convert.ToString(dr.GetValue(1));
                    textBox1.Text = Convert.ToString(dr.GetValue(0));
                    textBox2.Text = Convert.ToString(dr.GetValue(2));
                    textBox3.Text = Convert.ToString(dr.GetValue(5));
                    textBox4.Text = Convert.ToString(dr.GetValue(3));
                    textBox5.Text = Convert.ToString(dr.GetValue(6));
                    textBox6.Text = Convert.ToString(dr.GetValue(4));
                    byte[] img = (byte[])(dr.GetValue(7));
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                dr.Close();
            }
            c.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection c = new SqlConnection(cs);
                string query = "update ProfessionalUser set FullName=@FullName,Gender=@Gender,Email=@Email,Education=@Education,Password=@Password,ProfilePicture=@ProfilePicture where Username=@Username";
                SqlCommand cmd1 = new SqlCommand(query, c);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@Username", label15.Text);
                cmd1.Parameters.AddWithValue("@FullName", textBox1.Text);
                cmd1.Parameters.AddWithValue("@Gender", textBox2.Text);
                cmd1.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd1.Parameters.AddWithValue("@Education", textBox3.Text);
                cmd1.Parameters.AddWithValue("@Password", textBox5.Text);
                cmd1.Parameters.AddWithValue("@ProfilePicture", SavePhoto());
                c.Open();
                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Data Updated", "Unchanged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                c.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Update Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox4.ReadOnly = false;
            button3.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Professional_Dashboard professionalDashboard = new Professional_Dashboard();
            professionalDashboard.Show();
            this.Hide();
        }
    }
}
