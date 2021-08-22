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
    public partial class Job_Circular : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Job_Circular()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Professional_Dashboard professionalDashboard = new Professional_Dashboard();
            professionalDashboard.Show();
            this.Hide();
        }

        private void Job_Circular_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet9.jobCircular' table. You can move, or remove it, as needed.
            this.jobCircularTableAdapter.Fill(this.system_DatabaseDataSet9.jobCircular);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E22HUV1\SQLEXPRESS;Initial Catalog=System_Database;Integrated Security=True");
            string query = "select jobCircularDescription, jobCircularTitle, jobCircularPicture, jobCircularAuthor from jobCircular";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;


            label7.Text = $"Total Job Circular: {dataGridView1.RowCount}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[2].Value);
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();

            pictureBox1.Image = Properties.Resources.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from jobCircular where jobCircularTitle like '" + textBox2.Text + "%' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }
    }
}
