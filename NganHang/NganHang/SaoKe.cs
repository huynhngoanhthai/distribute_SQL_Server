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
    public partial class saoke : Form
    {
        private String linkServer;
        private String SoTK;
        private String TuNgay;
        private String DenNgay;
        public saoke(String linkServer,String SoTK,String TuNgay,String DenNgay)
        {
            this.SoTK = SoTK;
            this.TuNgay = TuNgay;
            this.DenNgay = DenNgay;
            InitializeComponent();
            this.linkServer = linkServer;
           
            SqlConnection cnn = new SqlConnection(linkServer);
            cnn.Open();

            string sql = "EXEC [dbo].[sp_BaoCaoGiaoDich] '"+SoTK+"', '"+ TuNgay + "', '"+DenNgay+"', 'NGANHANG'";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            SaoKeDataGridView.DataSource = dt;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saoke_Load(object sender, EventArgs e)
        {
            label2.Text = label2.Text + SoTK;
            label4.Text = label4.Text + TuNgay;
            label5.Text = label5.Text + DenNgay;
            try {
                SqlConnection cnn = new SqlConnection(linkServer);
                cnn.Open();
                string sql = "EXEC [dbo].[sp_InfoSOTK] '" + SoTK + "'";
                SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                SqlDataReader DR1 = com.ExecuteReader();
                if (DR1.Read())
                {
                    label3.Text = label3.Text + DR1.GetValue(3).ToString() + " " + DR1.GetValue(4).ToString();
                }
                cnn.Close(); }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
