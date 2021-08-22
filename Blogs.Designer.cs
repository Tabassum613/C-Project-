
namespace EngineersPortal
{
    partial class Blogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blogs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blogDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogAuthorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogPictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.blogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet2 = new EngineersPortal.System_DatabaseDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.blogTableAdapter = new EngineersPortal.System_DatabaseDataSet2TableAdapters.BlogTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.system_DatabaseDataSet13 = new EngineersPortal.System_DatabaseDataSet13();
            this.blogCommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blogCommentsTableAdapter = new EngineersPortal.System_DatabaseDataSet13TableAdapters.blogCommentsTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogCommentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blogDescriptionDataGridViewTextBoxColumn,
            this.blogTitleDataGridViewTextBoxColumn,
            this.blogAuthorNameDataGridViewTextBoxColumn,
            this.blogPictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.blogBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // blogDescriptionDataGridViewTextBoxColumn
            // 
            this.blogDescriptionDataGridViewTextBoxColumn.DataPropertyName = "blogDescription";
            resources.ApplyResources(this.blogDescriptionDataGridViewTextBoxColumn, "blogDescriptionDataGridViewTextBoxColumn");
            this.blogDescriptionDataGridViewTextBoxColumn.Name = "blogDescriptionDataGridViewTextBoxColumn";
            this.blogDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // blogTitleDataGridViewTextBoxColumn
            // 
            this.blogTitleDataGridViewTextBoxColumn.DataPropertyName = "blogTitle";
            resources.ApplyResources(this.blogTitleDataGridViewTextBoxColumn, "blogTitleDataGridViewTextBoxColumn");
            this.blogTitleDataGridViewTextBoxColumn.Name = "blogTitleDataGridViewTextBoxColumn";
            this.blogTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // blogAuthorNameDataGridViewTextBoxColumn
            // 
            this.blogAuthorNameDataGridViewTextBoxColumn.DataPropertyName = "blogAuthorName";
            resources.ApplyResources(this.blogAuthorNameDataGridViewTextBoxColumn, "blogAuthorNameDataGridViewTextBoxColumn");
            this.blogAuthorNameDataGridViewTextBoxColumn.Name = "blogAuthorNameDataGridViewTextBoxColumn";
            this.blogAuthorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // blogPictureDataGridViewImageColumn
            // 
            this.blogPictureDataGridViewImageColumn.DataPropertyName = "blogPicture";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blogPictureDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.blogPictureDataGridViewImageColumn, "blogPictureDataGridViewImageColumn");
            this.blogPictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.blogPictureDataGridViewImageColumn.Name = "blogPictureDataGridViewImageColumn";
            this.blogPictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // blogBindingSource
            // 
            this.blogBindingSource.DataMember = "Blog";
            this.blogBindingSource.DataSource = this.system_DatabaseDataSet2;
            // 
            // system_DatabaseDataSet2
            // 
            this.system_DatabaseDataSet2.DataSetName = "System_DatabaseDataSet2";
            this.system_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Name = "label5";
            // 
            // blogTableAdapter
            // 
            this.blogTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // system_DatabaseDataSet13
            // 
            this.system_DatabaseDataSet13.DataSetName = "System_DatabaseDataSet13";
            this.system_DatabaseDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blogCommentsBindingSource
            // 
            this.blogCommentsBindingSource.DataMember = "blogComments";
            this.blogCommentsBindingSource.DataSource = this.system_DatabaseDataSet13;
            // 
            // blogCommentsTableAdapter
            // 
            this.blogCommentsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EngineersPortal.Properties.Resources.business_man_usersearch_thesearch_theclient_2356;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EngineersPortal.Properties.Resources.Image;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EngineersPortal.Properties.Resources.Timber;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::EngineersPortal.Properties.Resources.Lunada;
            this.panel2.Controls.Add(this.label6);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // Blogs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "Blogs";
            this.Load += new System.EventHandler(this.Blogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogCommentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System_DatabaseDataSet2 system_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource blogBindingSource;
        private System_DatabaseDataSet2TableAdapters.BlogTableAdapter blogTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn blogDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blogTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blogAuthorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn blogPictureDataGridViewImageColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System_DatabaseDataSet13 system_DatabaseDataSet13;
        private System.Windows.Forms.BindingSource blogCommentsBindingSource;
        private System_DatabaseDataSet13TableAdapters.blogCommentsTableAdapter blogCommentsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}