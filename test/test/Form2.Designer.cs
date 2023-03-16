
namespace test
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tsno = new System.Windows.Forms.TextBox();
            this.tsname = new System.Windows.Forms.TextBox();
            this.tsage = new System.Windows.Forms.TextBox();
            this.tspho = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.myDatabase1DataSet = new test.MyDatabase1DataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new test.MyDatabase1DataSetTableAdapters.studentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.sageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.sphoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tusno = new System.Windows.Forms.TextBox();
            this.tusname = new System.Windows.Forms.TextBox();
            this.tusage = new System.Windows.Forms.TextBox();
            this.tuspho = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tdsno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "年龄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "电话";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tsno
            // 
            this.tsno.Location = new System.Drawing.Point(24, 58);
            this.tsno.Name = "tsno";
            this.tsno.Size = new System.Drawing.Size(145, 21);
            this.tsno.TabIndex = 6;
            this.tsno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tsname
            // 
            this.tsname.Location = new System.Drawing.Point(187, 58);
            this.tsname.Name = "tsname";
            this.tsname.Size = new System.Drawing.Size(145, 21);
            this.tsname.TabIndex = 7;
            this.tsname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tsage
            // 
            this.tsage.Location = new System.Drawing.Point(353, 58);
            this.tsage.Name = "tsage";
            this.tsage.Size = new System.Drawing.Size(145, 21);
            this.tsage.TabIndex = 8;
            // 
            // tspho
            // 
            this.tspho.Location = new System.Drawing.Point(527, 58);
            this.tspho.Name = "tspho";
            this.tspho.Size = new System.Drawing.Size(145, 21);
            this.tspho.TabIndex = 9;
            this.tspho.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 21);
            this.button2.TabIndex = 10;
            this.button2.Text = "上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // myDatabase1DataSet
            // 
            this.myDatabase1DataSet.DataSetName = "MyDatabase1DataSet";
            this.myDatabase1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.myDatabase1DataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(145, 171);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.studentBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(187, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(145, 171);
            this.dataGridView2.TabIndex = 12;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sageDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.studentBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(353, 156);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(145, 171);
            this.dataGridView3.TabIndex = 13;
            // 
            // sageDataGridViewTextBoxColumn
            // 
            this.sageDataGridViewTextBoxColumn.DataPropertyName = "sage";
            this.sageDataGridViewTextBoxColumn.HeaderText = "sage";
            this.sageDataGridViewTextBoxColumn.Name = "sageDataGridViewTextBoxColumn";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.ColumnHeadersVisible = false;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sphoDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.studentBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(527, 156);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(145, 171);
            this.dataGridView4.TabIndex = 14;
            // 
            // sphoDataGridViewTextBoxColumn
            // 
            this.sphoDataGridViewTextBoxColumn.DataPropertyName = "spho";
            this.sphoDataGridViewTextBoxColumn.HeaderText = "spho";
            this.sphoDataGridViewTextBoxColumn.Name = "sphoDataGridViewTextBoxColumn";
            // 
            // tusno
            // 
            this.tusno.Location = new System.Drawing.Point(24, 112);
            this.tusno.Name = "tusno";
            this.tusno.Size = new System.Drawing.Size(145, 21);
            this.tusno.TabIndex = 15;
            // 
            // tusname
            // 
            this.tusname.Location = new System.Drawing.Point(187, 112);
            this.tusname.Name = "tusname";
            this.tusname.Size = new System.Drawing.Size(145, 21);
            this.tusname.TabIndex = 16;
            // 
            // tusage
            // 
            this.tusage.Location = new System.Drawing.Point(353, 112);
            this.tusage.Name = "tusage";
            this.tusage.Size = new System.Drawing.Size(145, 21);
            this.tusage.TabIndex = 17;
            // 
            // tuspho
            // 
            this.tuspho.Location = new System.Drawing.Point(527, 112);
            this.tuspho.Name = "tuspho";
            this.tuspho.Size = new System.Drawing.Size(145, 21);
            this.tuspho.TabIndex = 18;
            this.tuspho.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(694, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "更改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(187, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tdsno
            // 
            this.tdsno.Location = new System.Drawing.Point(24, 346);
            this.tdsno.Name = "tdsno";
            this.tdsno.Size = new System.Drawing.Size(145, 21);
            this.tdsno.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.tdsno);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tuspho);
            this.Controls.Add(this.tusage);
            this.Controls.Add(this.tusname);
            this.Controls.Add(this.tusno);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tspho);
            this.Controls.Add(this.tsage);
            this.Controls.Add(this.tsname);
            this.Controls.Add(this.tsno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "学生数据";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tsno;
        private System.Windows.Forms.TextBox tsname;
        private System.Windows.Forms.TextBox tsage;
        private System.Windows.Forms.TextBox tspho;
        private System.Windows.Forms.Button button2;
        private MyDatabase1DataSet myDatabase1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MyDatabase1DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sphoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tusno;
        private System.Windows.Forms.TextBox tusname;
        private System.Windows.Forms.TextBox tusage;
        private System.Windows.Forms.TextBox tuspho;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tdsno;
    }
}