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
    public partial class home : Form
    {
        String linkServer;
     
        
        public home(String linkServer)
        {
            InitializeComponent();
            this.linkServer = linkServer;
            String LoginName = linkServer.Split(';')[2].Substring(4);
            String ROLE="";
            SqlConnection cnn = new SqlConnection(linkServer);
            cnn.Open();
            string sql = "EXEC [dbo].[SP_DANGNHAP] '" + LoginName + "'";  
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataReader reader = com.ExecuteReader();
            while(reader.Read())
            {
                  ROLE = reader.GetString(2);
            }
            if(ROLE == "NGANHANG")
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button4.Hide() ;
                button7.Hide();
            }
        }
        private String getLinkServer()
        {
            return linkServer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer KhachHang = new customer(getLinkServer());
            KhachHang.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            taikhoan TK = new taikhoan(getLinkServer());
            TK.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nhanvien T = new nhanvien(getLinkServer());
            T.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giaodich T = new giaodich(getLinkServer());
            T.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baocao T = new baocao(getLinkServer());
            T.Show();
            this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            taologin l = new taologin(linkServer);
            l.Show();
        }
    }

   
}
