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
    public partial class Notice : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Notice()
        {
            InitializeComponent();
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet3.Notice' table. You can move, or remove it, as needed.
            this.noticeTableAdapter.Fill(this.system_DatabaseDataSet3.Notice);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E22HUV1\SQLEXPRESS;Initial Catalog=System_Database;Integrated Security=True");
            string query = "select noticeDescription, noticeTitle, noticeAuthor from Notice";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;


            label7.Text = $"Total Notice: {dataGridView1.RowCount}";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Notice where noticeTitle like '" + textBox2.Text + "%' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
