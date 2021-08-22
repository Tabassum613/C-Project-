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
    public partial class Chatting_Professional : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Chatting_Professional()
        {
            InitializeComponent();
            textBox4.Text = Login.username.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Chatting_Professional_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet10.Messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter.Fill(this.system_DatabaseDataSet10.Messages);

            BindGridView();
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Professional_Dashboard professionalDashboard = new Professional_Dashboard();
            professionalDashboard.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection c = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Update Messages set messageText = @messageText, messageSender = @messageSender", c);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@messageText", textBox1.Text);
                cmd.Parameters.AddWithValue("@messageSender", textBox4.Text);

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

        public void getRecord()
        {
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
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
