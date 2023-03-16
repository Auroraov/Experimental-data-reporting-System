using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace test//学生
{
    public partial class Form2 : Form
    {
        private SqlConnection conn;
        private static string conString = ConfigurationManager.ConnectionStrings["sqlserver"].ToString();
        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection(conString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“myDatabase1DataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.myDatabase1DataSet.student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlserver = "insert into student(sno,sname,sage,spho)values('{0}','{1}','{2}','{3}')";
            sqlserver = string.Format(sqlserver, tsno.Text.Trim(), tsname.Text.Trim(), tsage.Text.Trim(), tspho.Text.Trim());

            SqlCommand cmd = new SqlCommand(sqlserver, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("插入数据成功！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("连接数据库失败，具体为:" + ex.Message, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//更改
        {
            string sqlserver = "update student set ";
            if (!string.IsNullOrWhiteSpace(tusno.Text.Trim())) sqlserver += "sno='" + tusno.Text.Trim() + "',";
            if (!string.IsNullOrWhiteSpace(tusname.Text.Trim())) sqlserver += "sname='" + tusname.Text.Trim() + "',";
            if (!string.IsNullOrWhiteSpace(tusage.Text.Trim())) sqlserver += "sage='" + tusage.Text.Trim() + "',";
            if (!string.IsNullOrWhiteSpace(tuspho.Text.Trim())) sqlserver += "spho='" + tuspho.Text.Trim() + "',";

            sqlserver = sqlserver.Substring(0, sqlserver.Length - 1);
            sqlserver = sqlserver + " where sno='" + tusno.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlserver, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("更新数据成功！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("没有找到数据！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新数据失败，具体为:" + ex.Message, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)//删除
        {
            if (string.IsNullOrWhiteSpace(tdsno.Text.Trim()))
            {
                MessageBox.Show("请输入要删除的学生的学号", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlserver = "delete from student where SNO='{0}'";
            sqlserver = string.Format(sqlserver, tdsno.Text.Trim());
            SqlCommand cmd = new SqlCommand(sqlserver, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("删除数据成功！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("没有找到数据！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("删除数据失败，具体为;" + ex.Message, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

        }

      
      
    }
}
