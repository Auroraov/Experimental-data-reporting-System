
namespace test
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tename = new System.Windows.Forms.TextBox();
            this.tetime = new System.Windows.Forms.TextBox();
            this.tetname = new System.Windows.Forms.TextBox();
            this.tsno = new System.Windows.Forms.TextBox();
            this.myDatabase1DataSet = new test.MyDatabase1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabase1DataSet1 = new test.MyDatabase1DataSet1();
            this.experimentTableAdapter = new test.MyDatabase1DataSet1TableAdapters.experimentTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.etimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experimentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.etnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experimentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.labBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.experimentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.labTableAdapter = new test.MyDatabase1DataSet1TableAdapters.labTableAdapter();
            this.labBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabase1DataSet2 = new test.MyDatabase1DataSet2();
            this.labBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.labTableAdapter1 = new test.MyDatabase1DataSet2TableAdapters.labTableAdapter();
            this.labBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuename = new System.Windows.Forms.TextBox();
            this.tuetime = new System.Windows.Forms.TextBox();
            this.tuetname = new System.Windows.Forms.TextBox();
            this.tusno = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tdename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "实验名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "实验时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "指导教师";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "学号";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tename
            // 
            this.tename.Location = new System.Drawing.Point(24, 47);
            this.tename.Name = "tename";
            this.tename.Size = new System.Drawing.Size(145, 21);
            this.tename.TabIndex = 8;
            // 
            // tetime
            // 
            this.tetime.Location = new System.Drawing.Point(192, 47);
            this.tetime.Name = "tetime";
            this.tetime.Size = new System.Drawing.Size(145, 21);
            this.tetime.TabIndex = 9;
            // 
            // tetname
            // 
            this.tetname.Location = new System.Drawing.Point(362, 47);
            this.tetname.Name = "tetname";
            this.tetname.Size = new System.Drawing.Size(145, 21);
            this.tetname.TabIndex = 10;
            // 
            // tsno
            // 
            this.tsno.Location = new System.Drawing.Point(532, 47);
            this.tsno.Name = "tsno";
            this.tsno.Size = new System.Drawing.Size(145, 21);
            this.tsno.TabIndex = 11;
            // 
            // myDatabase1DataSet
            // 
            this.myDatabase1DataSet.DataSetName = "MyDatabase1DataSet";
            this.myDatabase1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.experimentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(145, 182);
            this.dataGridView1.TabIndex = 14;
            // 
            // enameDataGridViewTextBoxColumn
            // 
            this.enameDataGridViewTextBoxColumn.DataPropertyName = "ename";
            this.enameDataGridViewTextBoxColumn.HeaderText = "ename";
            this.enameDataGridViewTextBoxColumn.Name = "enameDataGridViewTextBoxColumn";
            // 
            // experimentBindingSource
            // 
            this.experimentBindingSource.DataMember = "experiment";
            this.experimentBindingSource.DataSource = this.myDatabase1DataSet1;
            // 
            // myDatabase1DataSet1
            // 
            this.myDatabase1DataSet1.DataSetName = "MyDatabase1DataSet1";
            this.myDatabase1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // experimentTableAdapter
            // 
            this.experimentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etimeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.experimentBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(192, 138);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(145, 182);
            this.dataGridView2.TabIndex = 15;
            // 
            // etimeDataGridViewTextBoxColumn
            // 
            this.etimeDataGridViewTextBoxColumn.DataPropertyName = "etime";
            this.etimeDataGridViewTextBoxColumn.HeaderText = "etime";
            this.etimeDataGridViewTextBoxColumn.Name = "etimeDataGridViewTextBoxColumn";
            // 
            // experimentBindingSource1
            // 
            this.experimentBindingSource1.DataMember = "experiment";
            this.experimentBindingSource1.DataSource = this.myDatabase1DataSet1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etnameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.experimentBindingSource2;
            this.dataGridView3.Location = new System.Drawing.Point(362, 138);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(148, 182);
            this.dataGridView3.TabIndex = 16;
            // 
            // etnameDataGridViewTextBoxColumn
            // 
            this.etnameDataGridViewTextBoxColumn.DataPropertyName = "etname";
            this.etnameDataGridViewTextBoxColumn.HeaderText = "etname";
            this.etnameDataGridViewTextBoxColumn.Name = "etnameDataGridViewTextBoxColumn";
            // 
            // experimentBindingSource2
            // 
            this.experimentBindingSource2.DataMember = "experiment";
            this.experimentBindingSource2.DataSource = this.myDatabase1DataSet1;
            // 
            // labBindingSource1
            // 
            this.labBindingSource1.DataMember = "lab";
            this.labBindingSource1.DataSource = this.myDatabase1DataSet1;
            // 
            // labBindingSource
            // 
            this.labBindingSource.DataMember = "lab";
            this.labBindingSource.DataSource = this.myDatabase1DataSet1;
            // 
            // experimentBindingSource3
            // 
            this.experimentBindingSource3.DataMember = "experiment";
            this.experimentBindingSource3.DataSource = this.myDatabase1DataSet1;
            // 
            // labTableAdapter
            // 
            this.labTableAdapter.ClearBeforeFill = true;
            // 
            // labBindingSource2
            // 
            this.labBindingSource2.DataMember = "lab";
            this.labBindingSource2.DataSource = this.myDatabase1DataSet1;
            // 
            // myDatabase1DataSet2
            // 
            this.myDatabase1DataSet2.DataSetName = "MyDatabase1DataSet2";
            this.myDatabase1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labBindingSource3
            // 
            this.labBindingSource3.DataMember = "lab";
            this.labBindingSource3.DataSource = this.myDatabase1DataSet2;
            // 
            // labTableAdapter1
            // 
            this.labTableAdapter1.ClearBeforeFill = true;
            // 
            // labBindingSource4
            // 
            this.labBindingSource4.DataMember = "lab";
            this.labBindingSource4.DataSource = this.myDatabase1DataSet2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.ColumnHeadersVisible = false;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.experimentBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(532, 138);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(145, 182);
            this.dataGridView4.TabIndex = 17;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // tuename
            // 
            this.tuename.Location = new System.Drawing.Point(24, 101);
            this.tuename.Name = "tuename";
            this.tuename.Size = new System.Drawing.Size(145, 21);
            this.tuename.TabIndex = 18;
            // 
            // tuetime
            // 
            this.tuetime.Location = new System.Drawing.Point(192, 101);
            this.tuetime.Name = "tuetime";
            this.tuetime.Size = new System.Drawing.Size(145, 21);
            this.tuetime.TabIndex = 19;
            // 
            // tuetname
            // 
            this.tuetname.Location = new System.Drawing.Point(362, 101);
            this.tuetname.Name = "tuetname";
            this.tuetname.Size = new System.Drawing.Size(145, 21);
            this.tuetname.TabIndex = 20;
            // 
            // tusno
            // 
            this.tusno.Location = new System.Drawing.Point(532, 101);
            this.tusno.Name = "tusno";
            this.tusno.Size = new System.Drawing.Size(145, 21);
            this.tusno.TabIndex = 21;
            this.tusno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(683, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "更改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tdename
            // 
            this.tdename.Location = new System.Drawing.Point(24, 347);
            this.tdename.Name = "tdename";
            this.tdename.Size = new System.Drawing.Size(145, 21);
            this.tdename.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.tdename);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tusno);
            this.Controls.Add(this.tuetname);
            this.Controls.Add(this.tuetime);
            this.Controls.Add(this.tuename);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tsno);
            this.Controls.Add(this.tetname);
            this.Controls.Add(this.tetime);
            this.Controls.Add(this.tename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实验数据";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tename;
        private System.Windows.Forms.TextBox tetime;
        private System.Windows.Forms.TextBox tetname;
        private System.Windows.Forms.TextBox tsno;
        private MyDatabase1DataSet myDatabase1DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyDatabase1DataSet1 myDatabase1DataSet1;
        private System.Windows.Forms.BindingSource experimentBindingSource;
        private MyDatabase1DataSet1TableAdapters.experimentTableAdapter experimentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn enameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn etimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource experimentBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn etnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource experimentBindingSource2;
        private System.Windows.Forms.BindingSource experimentBindingSource3;
        private System.Windows.Forms.BindingSource labBindingSource;
        private MyDatabase1DataSet1TableAdapters.labTableAdapter labTableAdapter;
        private System.Windows.Forms.BindingSource labBindingSource1;
        private System.Windows.Forms.BindingSource labBindingSource2;
        private MyDatabase1DataSet2 myDatabase1DataSet2;
        private System.Windows.Forms.BindingSource labBindingSource3;
        private MyDatabase1DataSet2TableAdapters.labTableAdapter labTableAdapter1;
        private System.Windows.Forms.BindingSource labBindingSource4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tuename;
        private System.Windows.Forms.TextBox tuetime;
        private System.Windows.Forms.TextBox tuetname;
        private System.Windows.Forms.TextBox tusno;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tdename;
    }
}