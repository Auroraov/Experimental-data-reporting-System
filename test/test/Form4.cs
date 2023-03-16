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

namespace test
{
    public partial class Form4 : Form
    {
        private SqlConnection conn;
        private static string conString = ConfigurationManager.ConnectionStrings["sqlserver"].ToString();
        public Form4()
        {
            InitializeComponent();
            conn = new SqlConnection(conString);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“myDatabase1DataSet2.lab”中。您可以根据需要移动或删除它。
            this.labTableAdapter.Fill(this.myDatabase1DataSet2.lab);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlserver = "insert into lab(lname,ladd,lpho,ename)values('{0}','{1}','{2}','{3}')";
            sqlserver = string.Format(sqlserver, tlname.Text.Trim(), tladd.Text.Trim(), tlpho.Text.Trim(), tename.Text.Trim());

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

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlserver = "update lab set ";
            if (!string.IsNullOrWhiteSpace(tulname.Text.Trim())) sqlserver += "lname='" + tulname.Text.Trim() + "',";
            if (!string.IsNullOrWhiteSpace(tuename.Text.Trim())) sqlserver += "ename='" + tuename.Text.Trim() + "',";
            if (!string.IsNullOrWhiteSpace(tuladd.Text.Trim())) sqlserver += "ladd='" + tuladd.Text.Trim() + "',";
            if (!string.IsNullOrWhiteSpace(tulpho.Text.Trim())) sqlserver += "lpho='" + tulpho.Text.Trim() + "',";

            sqlserver = sqlserver.Substring(0, sqlserver.Length - 1);
            sqlserver = sqlserver + " where lname='" + tulname.Text + "'";
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
            if (string.IsNullOrWhiteSpace(tdlname.Text.Trim()))
            {
                MessageBox.Show("请输入要删除的学生的学号", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlserver = "delete from lab where lname='{0}'";
            sqlserver = string.Format(sqlserver, tdlname.Text.Trim());
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
