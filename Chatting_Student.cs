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
    public partial class Chatting_Student : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Chatting_Student()
        {
            InitializeComponent();
            textBox3.Text = Login.username.ToString();
        }

        private void Chatting_Student_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Student_Dashboard studentDashboard = new Student_Dashboard();
            studentDashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Student_Dashboard studentDashboard = new Student_Dashboard();
            studentDashboard.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection c = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Update Messages set messageReply = @messageReply, messageReceiver = @messageReceiver", c);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@messageReply", textBox1.Text);
                cmd.Parameters.AddWithValue("@messageReceiver", textBox3.Text);

                c.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Message sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                c.Close();
            }

            BindGridView();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Messages";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox9.Clear();
        }
    }
}
