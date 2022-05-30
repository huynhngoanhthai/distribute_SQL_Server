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
    public partial class lietkekhachhang : Form
    {
        private String linkServer,CN;
        public lietkekhachhang(String linkServer, String CN)
        {
            InitializeComponent();
            this.linkServer = linkServer;
            this.CN = CN;
            String sql = "";
            if (CN == "BEN THANH")
            {
                sql = "SELECT * FROM (SELECT * FROM khachhang UNION ALL SELECT * FROM LINK.NGANHANG.dbo.khachhang) AS a WHERE a.MACN='CN1'";
            }
            else if (CN == "TAN DINH")
            {
                sql = "SELECT * FROM (SELECT * FROM khachhang UNION ALL SELECT * FROM LINK.NGANHANG.dbo.khachhang) AS a WHERE a.MACN='CN2' ";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lietkekhachhang_Load(object sender, EventArgs e)
        {
            label1.Text += CN; 
        }
    }
}
