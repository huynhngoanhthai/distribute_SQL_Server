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
    public partial class nhanvien : Form
    {
        private String linkServer;
        public nhanvien(String linkServer)
        {
            this.linkServer = linkServer;
            InitializeComponent();

            SqlConnection cnn = new SqlConnection(linkServer);
            cnn.Open();
            string sql = "select * from NHANVIEN";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            DSNVDataGridView.DataSource = dt; //đổ dữ liệu vào datagridview
            
        }

        private void DSNVDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in DSNVDataGridView.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToString(row.Cells["TrangThaiXoa"].Value) == "1")// Or your condition 
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                
            }
        }

        private bool checkedEmpty()
        {
            String MaNV = MaTextBox.Text;
            String Ho = HoTextBox.Text;
            String Ten = TenTextBox.Text;
            String DiaChi = DiaChiTextBox.Text;
            String GioiTinh = PhaiComboBox.Text;
          
            String SDT = SDTTextBox.Text;
            if (string.IsNullOrEmpty(MaNV) || string.IsNullOrEmpty(Ho) || string.IsNullOrEmpty(Ten) || string.IsNullOrEmpty(DiaChi) || string.IsNullOrEmpty(GioiTinh)  || string.IsNullOrEmpty(SDT) || PasswordTextBox.Text == "********" || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("MUST NOT EMPTY");
                return true;
            }
            else
                return false;
        }
        private void nhanvien_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DSNVDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DSNVDataGridView.Rows[e.RowIndex];

                MaTextBox.Text = Convert.ToString(row.Cells["MANV"].Value);
                HoTextBox.Text = Convert.ToString(row.Cells["ho"].Value);
                TenTextBox.Text = Convert.ToString(row.Cells["ten"].Value);
                DiaChiTextBox.Text = Convert.ToString(row.Cells["DiaChi"].Value);
                PasswordTextBox.Text = "********";
                if (Convert.ToString(row.Cells["Phai"].Value) == "NAM")
                    PhaiComboBox.SelectedIndex = 0;
                else
                    PhaiComboBox.SelectedIndex = 1;

                SDTTextBox.Text = Convert.ToString(row.Cells["SODT"].Value);
            }
            catch (Exception)
            {


            }
        }

        private void PhaiComboBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PhaiComboBox.Text, "[^NAM  | NU ]"))
            {
                MessageBox.Show("Please choose NAM or NU");
                PhaiComboBox.Text = PhaiComboBox.Text.Remove(PhaiComboBox.Text.Length - 1);
            }
        }

        private void SDTTextBox_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(SDTTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                SDTTextBox.Text = SDTTextBox.Text.Remove(SDTTextBox.Text.Length - 1);
            }
        }
        private void resetFrom()
        {
            nhanvien NewForm = new nhanvien(linkServer);
            NewForm.Show();
            this.Dispose(false);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String MaNV = MaTextBox.Text;
            String Ho = HoTextBox.Text;
            String Ten = TenTextBox.Text;
            String DiaChi = DiaChiTextBox.Text;
            String Phai = PhaiComboBox.Text;
            String SDT = SDTTextBox.Text;
            String login = LoginTextBox.Text;
            String pass = PasswordTextBox.Text;
            // connect DB
            String LoginName = linkServer.Split(';')[2].Substring(4);
            if (!checkedEmpty())
            {
                try
                {
                    String serverName = linkServer.Substring(7, 23);
                    if (serverName == @"DESKTOP-HLUE84B\SERVER1")
                        serverName = "CN1";
                    else if (serverName == @"DESKTOP-HLUE84B\SERVER2")
                        serverName = "CN2";
                    SqlConnection cnn = new SqlConnection(linkServer);
                    cnn.Open();
                    string query = "EXEC [dbo].[sp_themNV] '" + MaNV + "', '" + Ho + "', '" + Ten + "', '" + DiaChi + "', '" + Phai+ "','" + SDT + "', '" + serverName + "','"+login+"','"+pass+"' ";
                    MessageBox.Show(query);
                    SqlCommand com = new SqlCommand(query, cnn);

                    com.ExecuteNonQuery();

                   
                    cnn.Close();

                    MessageBox.Show("successfully ADD NHAN VIEN");
                    resetFrom();
                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            home HOME = new home(linkServer);
            HOME.Show();
            this.Hide();
        }

        private void MaTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private int CheckedMaNVInTable(String CMND)
        {
            foreach (DataGridViewRow row in DSNVDataGridView.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume

                if (CMND == Convert.ToString(row.Cells["MANV"].Value))// Or your condition 
                {
                    return 1;
                }
            }
            return 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            String MaNV = MaTextBox.Text;
            String Ho = HoTextBox.Text;
            String Ten = TenTextBox.Text;
            String DiaChi = DiaChiTextBox.Text;
            String Phai = PhaiComboBox.Text;
            String SDT = SDTTextBox.Text;
            String login = LoginTextBox.Text;
            String pass = PasswordTextBox.Text;

            if(CheckedMaNVInTable(MaNV) == 0)
            {
                MessageBox.Show("Không đc thai đổi MaNV");
            }
            else if (!checkedEmpty())
            {
                try
                {
                    String LoginName = linkServer.Split(';')[2].Substring(4);
                    if (Ten == LoginName)
                    {
                        throw new ArgumentNullException(paramName: "ERROR", message: "tai khoảng đang thực thiện không đổi MK ĐC");
                    }
                    SqlConnection cnn = new SqlConnection(linkServer);
                    cnn.Open();
                    string query = "EXEC sp_updateNV '" + MaNV + "','" + Ho+"','"+Ten+ "','"+DiaChi+ "','"+Phai+ "','"+SDT+ "','" + Ten + "','"+ pass + "' ";
                    MessageBox.Show(query);
                    SqlCommand com = new SqlCommand(query, cnn);

                    com.ExecuteNonQuery();


                    cnn.Close();

                    MessageBox.Show("successfully UPDATE NHAN VIEN");
                    resetFrom();
                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message);
                }
            }

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TenTextBox_TextChanged(object sender, EventArgs e)
        {
            LoginTextBox.Text = TenTextBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String MaNV = MaTextBox.Text;
            if (!checkedEmpty())
            {
                try
                {
                    
                    SqlConnection cnn = new SqlConnection(linkServer);
                    cnn.Open();
                    string query = "EXEC [dbo].[sp_xoaNV] '" + MaNV + "' ";
                    MessageBox.Show(query);
                    SqlCommand com = new SqlCommand(query, cnn);

                    com.ExecuteNonQuery();


                    cnn.Close();

                    MessageBox.Show("successfully DELETE NHAN VIEN");
                    resetFrom();
                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String MaNV = MaTextBox.Text;
            if (CheckedMaNVInTable(MaNV) == 0)
            {
                MessageBox.Show("Không đc thai đổi MaNV");
            }
            else 
            {
                doichinhanh d = new doichinhanh(linkServer, MaNV);
                d.Show();
            }

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            PasswordTextBox.Clear();
        }
    }
}
