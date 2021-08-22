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
    public partial class Solution : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Solution()
        {
            InitializeComponent();
        }

        private void Solution_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet15.questionComment' table. You can move, or remove it, as needed.
            this.questionCommentTableAdapter.Fill(this.system_DatabaseDataSet15.questionComment);
            // TODO: This line of code loads data into the 'system_DatabaseDataSet5.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.system_DatabaseDataSet5.Question);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E22HUV1\SQLEXPRESS;Initial Catalog=System_Database;Integrated Security=True");
            string query = "select questionAuthor, questionTitle, questionDescription, questionPicture from Question";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;


            label7.Text = $"Total Question: {dataGridView1.RowCount}";
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Question";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;



            ///Image Column
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[2];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;



            //AUTOSIZE
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Image Height
            dataGridView1.RowTemplate.Height = 50;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindGridView();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            //textBox6.Clear();
            textBox4.Clear();
            //textBox7.Clear();

            pictureBox1.Image = Properties.Resources.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //if (textBox6.Text != "" && textBox7.Text != "")
            //{
            //    SqlConnection c = new SqlConnection(cs);
            //    SqlCommand cmd = new SqlCommand("Insert into questionComment Values(@questionCommenterName, @questionCommentText)", c);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@questionCommenterName", textBox6.Text);
            //    cmd.Parameters.AddWithValue("@questionCommentText", textBox7.Text);

            //    c.Open();
            //    int a = cmd.ExecuteNonQuery();
            //    if (a > 0)
            //    {
            //        MessageBox.Show("Comment has been made successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    c.Close();
            //}
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //textBox6.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            //textBox7.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
