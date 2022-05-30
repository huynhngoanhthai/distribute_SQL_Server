using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class taikhoan : Form
    {
        private String linkServer;
        public taikhoan(String linkServer)
        {
            this.linkServer = linkServer;
            InitializeComponent();
            SqlConnection cnn = new SqlConnection(linkServer);
            cnn.Open();
            string sql = "select * from TAIKHOAN";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            DSTKDataGridView.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkedEmpty()
        {
            String SoTK = SoTaiKhoanTextBox.Text;
            String CMND = CMNDTextBox.Text;
            String SoDu = SoDuTextBox.Text;
            if (string.IsNullOrEmpty(CMND) || string.IsNullOrEmpty(SoTK) || string.IsNullOrEmpty(SoTK) )
            {
                MessageBox.Show("MUST NOT EMPTY");
                return true;
            }
            else
                return false;
        }
        private void resetFrom()
        {
            taikhoan NewForm = new taikhoan(linkServer);
            NewForm.Show();
            this.Dispose(false);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            String SoTK = SoTaiKhoanTextBox.Text;
            String CMND = CMNDTextBox.Text;
            String SoDu = SoDuTextBox.Text;
            if (!checkedEmpty())
            {
                try
                {
                    String serverName = linkServer.Substring(7, 23);
                    if (serverName == @"DESKTOP-HLUE84B\SERVER1")
                        serverName = "CN1";
                    else
                        serverName = "CN2";

                    SqlConnection cnn = new SqlConnection(linkServer);
                    cnn.Open();
                    string query = "INSERT INTO [TAIKHOAN] (SOTK,CMND,SODU,MACN,NGAYMOTK ) VALUES('" + SoTK + "', '" + CMND + "', 0, '" + serverName + "', getdate()) ";

                    SqlCommand com = new SqlCommand(query, cnn);

                    com.ExecuteNonQuery();

                    // String useSP_GuiTien = "exec [dbo].[sp_GuiTien] '"+SoTK+"',"+SoDu+"";
                    cnn.Close();

                    MessageBox.Show("successfully add KHANG HANG");

                    resetFrom();
                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message);
                }
            }

        }

        private void SoDuTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SoDuTextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                SoDuTextBox.Text = SoDuTextBox.Text.Remove(SoDuTextBox.Text.Length - 1);
            }
        }

        private void DSTKDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DSTKDataGridView.Rows[e.RowIndex];

                SoTaiKhoanTextBox.Text = Convert.ToString(row.Cells["SOTK"].Value);
                CMNDTextBox.Text = Convert.ToString(row.Cells["CMND"].Value);
                SoDuTextBox.Text = Convert.ToString(row.Cells["SODU"].Value);
              

                
            }
            catch (Exception)
            {


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String SoTK = SoTaiKhoanTextBox.Text;
            String CMND = CMNDTextBox.Text;
            if (!checkedEmpty())
            {
                try
                {
                    SqlConnection cnn = new SqlConnection(linkServer);
                    cnn.Open();
                    string query = "UPDATE [TAIKHOAN] SET CMND='" +CMND+"' WHERE SOTK='"+SoTK+"'";

                    SqlCommand com = new SqlCommand(query, cnn);

                    com.ExecuteNonQuery();

                    // String useSP_GuiTien = "exec [dbo].[sp_GuiTien] '"+SoTK+"',"+SoDu+"";
                    cnn.Close();

                    MessageBox.Show("successfully Update tai khoan");

                    resetFrom();
                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String SoTK = SoTaiKhoanTextBox.Text;
            //connect DB
            try
            {

                SqlConnection cnn = new SqlConnection(linkServer);
                cnn.Open();
                string query = @"DELETE FROM [TAIKHOAN] WHERE SOTK='" + SoTK + "'";

                SqlCommand com = new SqlCommand(query, cnn);

                com.ExecuteNonQuery();

                cnn.Close();

                MessageBox.Show("successfully DELETE TAI KHOAN");
                resetFrom();
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home h = new home(linkServer);
            h.Show();
            this.Hide();
        }
    }
}
