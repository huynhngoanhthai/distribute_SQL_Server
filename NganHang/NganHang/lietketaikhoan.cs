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
    public partial class lietketaikhoan : Form
    {
        private String linkServer, CN, TuNgay, DenNgay;

        private void lietketaikhoan_Load(object sender, EventArgs e)
        {
            
            if (CN == "BEN THANH" || CN == "TAN DINH")
            {
                label1.Text += "Ở CHI NHÁNH " + CN;   
            }
            else
            {
                label1.Text += "Ở TẤT CẢ CÁC CHI NHANH";
            }

            label2.Text += TuNgay;
            label3.Text += DenNgay;
        }

        public lietketaikhoan(String linkServer, String CN, String TuNgay, String DenNgay)
        {
            this.linkServer = linkServer;
            this.CN = CN;
            this.TuNgay = TuNgay;
            this.DenNgay = DenNgay;
            InitializeComponent();

            String sql = "";
            if (CN == "BEN THANH")
            {
                sql = "SELECT * FROM TaiKhoan WHERE MACN = 'CN1' AND NGAYMOTK BETWEEN '" + TuNgay + "' AND '" + DenNgay + "' ";
            }
            else if (CN == "TAN DINH")
            {
                sql = "SELECT * FROM TaiKhoan WHERE MACN = 'CN2' AND NGAYMOTK BETWEEN '" + TuNgay + "' AND '" + DenNgay + "' ";
            }
            else
            {
                sql = "SELECT * FROM TaiKhoan WHERE NGAYMOTK BETWEEN '" + TuNgay + "' AND '" + DenNgay + "' ";
            }

            SqlConnection cnn = new SqlConnection(linkServer);
            cnn.Open();
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt;

        }

        private void adc()
        {
           
        }
    }
}
