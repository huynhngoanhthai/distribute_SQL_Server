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
    public partial class customer : Form
    {
        private String linkServer;
        public customer(String linkServer)
        {
            InitializeComponent();
            this.linkServer = linkServer;
            DateTime now = DateTime.Now;
           
            NgayCapTextBox.Text = now.ToShortDateString();
            SqlConnection cnn = new SqlConnection(linkServer);
            cnn.Open();
            string sql = "select * from khachhang";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            DSKHDataGridView.DataSource = dt; //đổ dữ liệu vào datagridview

        }
        private bool checkedEmpty()
        {
            String CMND = CMNDTextBox.Text;
            String Ho = HoTextBox.Text;
            String Ten = TenTextBox.Text;
            String DiaChi = DiaChiTextBox.Text;
            String GioiTinh = GioiTinhComboBox.Text;
            String NgayCap = NgayCapTextBox.Text;
            String SDT = SDTTextBox.Text;
            if (string.IsNullOrEmpty(CMND) || string.IsNullOrEmpty(Ho) || string.IsNullOrEmpty(Ten) || string.IsNullOrEmpty(DiaChi) || string.IsNullOrEmpty(GioiTinh) || string.IsNullOrEmpty(NgayCap) || string.IsNullOrEmpty(SDT))
            {
                MessageBox.Show("MUST NOT EMPTY");
                return true;
            }
            else
                return false;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void resetFrom()
        {
            customer NewForm = new customer(linkServer);
            NewForm.Show();
            this.Dispose(false);
        }
        private void Reset()
        {
            CMNDTextBox.Clear();
            HoTextBox.Clear();
            TenTextBox.Clear();
            DiaChiTextBox.Clear();
            GioiTinhComboBox.SelectedIndex = 0;
            NgayCapTextBox.Clear();
            SDTTextBox.Clear();
           

            DateTime now = DateTime.Now;
            NgayCapTextBox.Text = now.ToShortDateString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime now = DateTime.Now;
            NgayCapTextBox.Text = now.ToShortDateString();

            String CMND = CMNDTextBox.Text;
            String Ho = HoTextBox.Text;
            String Ten = TenTextBox.Text;
            String DiaChi = DiaChiTextBox.Text;
            String GioiTinh = GioiTinhComboBox.Text;
            String NgayCap = NgayCapTextBox.Text;
            String SDT = SDTTextBox.Text;
            // connect DB
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
                    string query = "EXEC [dbo].[sp_themKH] '" + CMND + "', '" + Ho + "', '" + Ten + "', '" + DiaChi + "', '" + GioiTinh + "', '" + SDT + "', '" + serverName + "' ";

                    SqlCommand com = new SqlCommand(query, cnn);

                    com.ExecuteNonQuery();

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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SDTTextBox_TextChanged(object sender, EventArgs e)
        {
     
            if (System.Text.RegularExpressions.Regex.IsMatch(SDTTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                SDTTextBox.Text = SDTTextBox.Text.Remove(SDTTextBox.Text.Length - 1);
            }
        
    }

        private void GioiTinhComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void GioiTinhComboBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(GioiTinhComboBox.Text, "[^NAM  | NU ]"))
            {
                MessageBox.Show("Please choose NAM or NU");
                GioiTinhComboBox.Text = GioiTinhComboBox.Text.Remove(GioiTinhComboBox.Text.Length - 1);
            }
        }

        private void DSKHDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DSKHDataGridView.Rows[e.RowIndex];

                CMNDTextBox.Text = Convert.ToString(row.Cells["CMND"].Value);
                HoTextBox.Text = Convert.ToString(row.Cells["ho"].Value);
                TenTextBox.Text = Convert.ToString(row.Cells["ten"].Value);
                DiaChiTextBox.Text = Convert.ToString(row.Cells["DiaChi"].Value);

                if (Convert.ToString(row.Cells["Phai"].Value) == "NAM")
                    GioiTinhComboBox.SelectedIndex = 0;
                else
                    GioiTinhComboBox.SelectedIndex = 1;


                NgayCapTextBox.Text = Convert.ToString(row.Cells["NgayCap"].Value);
                SDTTextBox.Text = Convert.ToString(row.Cells["SODT"].Value);
            }
            catch (Exception)
            {

               
            }
            
        }


        private void DSKHDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int CheckedCMNDInTable (String CMND)
        {
            foreach (DataGridViewRow row in DSKHDataGridView.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume

                if (CMND == Convert.ToString(row.Cells["CMND"].Value))// Or your condition 
                {
                    return 1;
                }
            }
            return 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            String CMND = CMNDTextBox.Text;
            String Ho = HoTextBox.Text;
            String Ten = TenTextBox.Text;
            String DiaChi = DiaChiTextBox.Text;
            String GioiTinh = GioiTinhComboBox.Text;
            String NgayCap = NgayCapTextBox.Text;
            String SDT = SDTTextBox.Text;
            //connect DB
            if (CheckedCMNDInTable(CMND) == 0)
            {
                MessageBox.Show("Không đc thai đổi CMND");
                
            }
            else if (!checkedEmpty())
            {
                try
                {

                    SqlConnection cnn = new SqlConnection(linkServer);
                    cnn.Open();

                    string query = @"EXEC sp_CapNhatKhachHang '"+ CMND + "', '" 
                        + NgayCap + "', '" + Ho + "', '" 
                        + Ten + "', '" + DiaChi + "', '" 
                        + GioiTinh + "', '" + SDT + "'";

                    SqlCommand com = new SqlCommand(query, cnn);

                    com.ExecuteNonQuery();

                    cnn.Close();

                    MessageBox.Show("successfully Update KHANG HANG");
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
            String CMND = CMNDTextBox.Text;
            //connect DB
            try
            {

                SqlConnection cnn = new SqlConnection(linkServer);
                cnn.Open();
                string query = @"EXEC [dbo].[sp_XoaKhachHang] '" + CMND +"'";

                SqlCommand com = new SqlCommand(query, cnn);

                com.ExecuteNonQuery();

                cnn.Close();

                MessageBox.Show("successfully DELETE KHANG HANG");
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

        private void NgayCapTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
