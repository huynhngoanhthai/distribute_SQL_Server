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
    public partial class doichinhanh : Form
    {
        private String linkServer;
        public doichinhanh(String linkServer,String MaNV)
        {
            this.linkServer = linkServer;
            InitializeComponent();
            textBox1.Text = MaNV;
        }
        private bool checkedEmpty()
        {
            String MaNV = textBox1.Text;
            String MaNVMoi = textBox2.Text;
            String pass = textBox3.Text;
            if (string.IsNullOrEmpty(MaNV) || string.IsNullOrEmpty(MaNVMoi) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("MUST NOT EMPTY");
                return true;
            }
            else
                return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String MaNV = textBox1.Text.Trim();
            String MaNVMoi = textBox2.Text;
            String pass = textBox3.Text;
            String MaCN = "";
            String serverName = linkServer.Substring(7, 23);
            if (serverName == @"DESKTOP-HLUE84B\SERVER1")
                MaCN = "CN1";
            else if (serverName == @"DESKTOP-HLUE84B\SERVER2")
                MaCN = "CN2";

            if (comboBox1.Text == "BEN THANH")
            {
                MaCN = "CN1";
            }
            else 
            {
                MaCN = "CN2";
            }

            if (!checkedEmpty())
            {
                try
                {
                    
                    SqlConnection cnn = new SqlConnection(linkServer);
                    cnn.Open();
                    string query = "EXEC sp_NhanVienChuyenChiNhanh '" + MaNV + "','"+MaCN+"','"+MaNVMoi+"','"+pass+"' ";
                    MessageBox.Show(query);
                    SqlCommand com = new SqlCommand(query, cnn);
                    com.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("successfully ADD NHAN VIEN");
                 
                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
