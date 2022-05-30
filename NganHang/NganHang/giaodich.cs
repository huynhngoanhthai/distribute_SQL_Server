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
    public partial class giaodich : Form
    {
        private String linkServer;
        public giaodich(String linkServer)
        {
            this.linkServer = linkServer;
            InitializeComponent();
            STKNhanTextBox.BackColor = Color.Red;
            ResetFrom();
            addAutocComplete();
        }
        private void addAutocComplete()
        {
            AutoCompleteStringCollection auto1 = new AutoCompleteStringCollection();
            CMNDTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CMNDTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            
            foreach (DataGridViewRow row in DSTKDataGridView.Rows)
            {
                auto1.Add(Convert.ToString(row.Cells["CMND"].Value));
            }

            CMNDTextBox.AutoCompleteCustomSource = auto1;
       
        }
        private void ResetFrom()
        {
            HoTenTextBox.Clear();
            CMNDTextBox.Clear();
            SoDuTextBox.Clear(); 
            STKNhanTextBox.Clear();
            SoTienChuyenTextBox.Clear();
            SoTienGuiTextBox.Clear();
            SoTienRutTextBox.Clear();

            ChuyenTienRadioButton.Checked = false;
            GuiTienRadioButton.Checked = false;
            RutTienRadioButton.Checked = false;

            SqlConnection cnn = new SqlConnection(linkServer);
            cnn.Open();
            string sql = "select * from taikhoan";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            DSTKDataGridView.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

       
        private void DSTKDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DSTKDataGridView.Rows[e.RowIndex];
                SoTKTextBox.Text = Convert.ToString(row.Cells["SOTK"].Value);
            }
            catch (Exception)
            {


            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            home HOME = new home(linkServer);
            HOME.Show();
            this.Hide();
        }

        private void SoTKTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(linkServer);
            cnn.Open();
            string sql = "EXEC [dbo].[sp_InfoSOTK] '"+SoTKTextBox.Text+"'";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataReader DR1 = com.ExecuteReader();
            if (DR1.Read())
            {
                HoTenTextBox.Text = DR1.GetValue(3).ToString()+" "+ DR1.GetValue(4).ToString();
                CMNDTextBox.Text = DR1.GetValue(2).ToString();
                SoDuTextBox.Text = DR1.GetValue(1).ToString();
            }
            cnn.Close();
        }

        private String MaNVHienTai(SqlConnection cnn)
        {
            String LoginName = linkServer.Split(';')[2].Substring(4);
 
            String sql = "EXEC [dbo].[SP_DANGNHAP] '" + LoginName + "'";
            SqlCommand com = new SqlCommand(sql, cnn);
 
            return com.ExecuteScalar().ToString();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // so tai khoan thuc hien
            String SoTK = SoTKTextBox.Text;
            // chuyen
            String STKNhan = STKNhanTextBox.Text;
            String SoTienChuyen = SoTienChuyenTextBox.Text;
            //rut
            String SoTienRut = SoTienRutTextBox.Text;
            //gui
            String SoTienGui = SoTienGuiTextBox.Text;
            //connect DB
            try
            {
                SqlConnection cnn = new SqlConnection(linkServer);
                cnn.Open();
                String sql = "";
                if (ChuyenTienRadioButton.Checked == true)
                {
                    sql = "EXEC [dbo].[sp_ChuyenTien] '" + SoTK + "', " + SoTienChuyen + ", '" + STKNhan + "', '" + MaNVHienTai(cnn) + "'";
                   
                }
                else if (RutTienRadioButton.Checked == true)
                {
                    sql = "EXEC [dbo].[sp_RutTien] '" + SoTK + "', " + SoTienRut + ",'" + MaNVHienTai(cnn) + "' ";
                }
                else if (GuiTienRadioButton.Checked == true)
                {
                    sql = "EXEC [dbo].[sp_GuiTien] '" + SoTK + "', " + SoTienGui + ",'" + MaNVHienTai(cnn) + "' ";
                }
                else
                {
  
                    throw new ArgumentNullException(paramName:"ERROR", message: "vui long chọn kiểu giao dịch");
                }
                SqlCommand com = new SqlCommand(sql, cnn);
                com.ExecuteNonQuery();

                cnn.Close();
                ResetFrom();
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
            
        }

        private void STKNhanTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DSTKDataGridView.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (STKNhanTextBox.Text == "")
                {
                    STKNhanTextBox.BackColor = Color.Red;
                    break;
                }
                else if (STKNhanTextBox.Text == Convert.ToString(row.Cells["SOTK"].Value).Replace(" ", ""))// Or your condition 
                {
                    STKNhanTextBox.BackColor = Color.Green;
                    break;
                }
                else
                    STKNhanTextBox.BackColor = Color.Red;

            }
            

        }

        private void CMNDTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
