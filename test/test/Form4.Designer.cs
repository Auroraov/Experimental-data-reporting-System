
namespace test
{
    partial class Form4
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tladd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabase1DataSet2 = new test.MyDatabase1DataSet2();
            this.labTableAdapter = new test.MyDatabase1DataSet2TableAdapters.labTableAdapter();
            this.tlname = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlpho = new System.Windows.Forms.TextBox();
            this.tename = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.laddDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.lpho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tulname = new System.Windows.Forms.TextBox();
            this.tuladd = new System.Windows.Forms.TextBox();
            this.tulpho = new System.Windows.Forms.TextBox();
            this.tuename = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tdlname = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "上传";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "实验室名称";
            // 
            // tladd
            // 
            this.tladd.AutoSize = true;
            this.tladd.Location = new System.Drawing.Point(250, 18);
            this.tladd.Name = "tladd";
            this.tladd.Size = new System.Drawing.Size(65, 12);
            this.tladd.TabIndex = 3;
            this.tladd.Text = "实验室地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "实验室电话";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "实验名称";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.labBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(145, 193);
            this.dataGridView1.TabIndex = 6;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // labBindingSource
            // 
            this.labBindingSource.DataMember = "lab";
            this.labBindingSource.DataSource = this.myDatabase1DataSet2;
            // 
            // myDatabase1DataSet2
            // 
            this.myDatabase1DataSet2.DataSetName = "MyDatabase1DataSet2";
            this.myDatabase1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labTableAdapter
            // 
            this.labTableAdapter.ClearBeforeFill = true;
            // 
            // tlname
            // 
            this.tlname.Location = new System.Drawing.Point(24, 44);
            this.tlname.Name = "tlname";
            this.tlname.Size = new System.Drawing.Size(145, 21);
            this.tlname.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 21);
            this.textBox1.TabIndex = 8;
            // 
            // tlpho
            // 
            this.tlpho.Location = new System.Drawing.Point(383, 44);
            this.tlpho.Name = "tlpho";
            this.tlpho.Size = new System.Drawing.Size(145, 21);
            this.tlpho.TabIndex = 9;
            // 
            // tename
            // 
            this.tename.Location = new System.Drawing.Point(559, 44);
            this.tename.Name = "tename";
            this.tename.Size = new System.Drawing.Size(145, 21);
            this.tename.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laddDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.labBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(204, 129);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(145, 193);
            this.dataGridView2.TabIndex = 11;
            // 
            // laddDataGridViewTextBoxColumn2
            // 
            this.laddDataGridViewTextBoxColumn2.DataPropertyName = "ladd";
            this.laddDataGridViewTextBoxColumn2.HeaderText = "ladd";
            this.laddDataGridViewTextBoxColumn2.Name = "laddDataGridViewTextBoxColumn2";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lpho});
            this.dataGridView3.DataSource = this.labBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(383, 129);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(145, 193);
            this.dataGridView3.TabIndex = 12;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.ColumnHeadersVisible = false;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ename});
            this.dataGridView4.DataSource = this.labBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(559, 129);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(145, 193);
            this.dataGridView4.TabIndex = 13;
            // 
            // lpho
            // 
            this.lpho.DataPropertyName = "lpho";
            this.lpho.HeaderText = "lpho";
            this.lpho.Name = "lpho";
            // 
            // ename
            // 
            this.ename.DataPropertyName = "ename";
            this.ename.HeaderText = "ename";
            this.ename.Name = "ename";
            // 
            // tulname
            // 
            this.tulname.Location = new System.Drawing.Point(24, 91);
            this.tulname.Name = "tulname";
            this.tulname.Size = new System.Drawing.Size(145, 21);
            this.tulname.TabIndex = 14;
            // 
            // tuladd
            // 
            this.tuladd.Location = new System.Drawing.Point(204, 91);
            this.tuladd.Name = "tuladd";
            this.tuladd.Size = new System.Drawing.Size(145, 21);
            this.tuladd.TabIndex = 15;
            // 
            // tulpho
            // 
            this.tulpho.Location = new System.Drawing.Point(383, 91);
            this.tulpho.Name = "tulpho";
            this.tulpho.Size = new System.Drawing.Size(145, 21);
            this.tulpho.TabIndex = 16;
            // 
            // tuename
            // 
            this.tuename.Location = new System.Drawing.Point(559, 91);
            this.tuename.Name = "tuename";
            this.tuename.Size = new System.Drawing.Size(145, 21);
            this.tuename.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(711, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "更改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tdlname
            // 
            this.tdlname.Location = new System.Drawing.Point(24, 369);
            this.tdlname.Name = "tdlname";
            this.tdlname.Size = new System.Drawing.Size(145, 21);
            this.tdlname.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(204, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tdlname);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tuename);
            this.Controls.Add(this.tulpho);
            this.Controls.Add(this.tuladd);
            this.Controls.Add(this.tulname);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tename);
            this.Controls.Add(this.tlpho);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tlname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tladd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实验室";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tladd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyDatabase1DataSet2 myDatabase1DataSet2;
        private System.Windows.Forms.BindingSource labBindingSource;
        private MyDatabase1DataSet2TableAdapters.labTableAdapter labTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tlname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tlpho;
        private System.Windows.Forms.TextBox tename;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn laddDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ename;
        private System.Windows.Forms.TextBox tulname;
        private System.Windows.Forms.TextBox tuladd;
        private System.Windows.Forms.TextBox tulpho;
        private System.Windows.Forms.TextBox tuename;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tdlname;
        private System.Windows.Forms.Button button4;
    }
}