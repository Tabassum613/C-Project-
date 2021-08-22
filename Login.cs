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

namespace EngineersPortal
{
    public partial class Login : Form
    {
        public static string username;
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        //public static string id;

        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;



            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            SqlConnection c = new SqlConnection(cs);

            //id = textBox1.Text;

            if (comboBox1.Text.Equals("Student"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Student WHERE Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'", c);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Student_Dashboard studentDashboard = new Student_Dashboard();
                    studentDashboard.ShowDialog();

                }
                else
                    MessageBox.Show("Invalid username or password", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text.Equals("Professional"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM ProfessionalUser WHERE Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'", c);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Professional_Dashboard professionalDashboard = new Professional_Dashboard();
                    professionalDashboard.ShowDialog();
                }
                else
                    MessageBox.Show("Invalid username or password", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text.Equals("Admin"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Admin WHERE Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'", c);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Admin_Dashboard dashboard = new Admin_Dashboard();
                    dashboard.ShowDialog();

                }
                else
                    MessageBox.Show("Invalid username or password", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Choose an option to login", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
