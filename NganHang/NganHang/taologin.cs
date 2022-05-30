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
    public partial class taologin : Form
    {
        private String linkServer;
        public taologin(String linkServer)
        {
            this.linkServer = linkServer;
            InitializeComponent();
            Password2TextBox.BackColor = Color.Red;
        }
        private bool checkedEmpty()
        {
            String MaNV = LoginTextBox.Text;
            String MaNVMoi =UserTextBox.Text;
            String pass = PasswordTextBox.Text;
            String pass2 = Password2TextBox.Text;
            if (string.IsNullOrEmpty(MaNV) || string.IsNullOrEmpty(MaNVMoi) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("MUST NOT EMPTY");
                return true;
            }
            else
                return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            String login = LoginTextBox.Text;
            String pass = PasswordTextBox.Text;
            String nameuser = UserTextBox.Text;
           if(PasswordTextBox.Text != Password2TextBox.Text)
                 MessageBox.Show("password khong trung khop");
           else if(!checkedEmpty())
            {
                try
                {
                   
                    SqlConnection cnn = new SqlConnection(linkServer);
                    cnn.Open();
                    string query = "EXEC [dbo].[sp_TaoTaiKhoan] '"+ login + "','"+pass+"','"+ nameuser + "','NGANHANG'";
                    MessageBox.Show(query);
                    SqlCommand com = new SqlCommand(query, cnn);
                    com.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("tao tai khoan thanh cong");
                    this.Close();

                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password2TextBox_TextChanged(object sender, EventArgs e)
        {
            if(Password2TextBox.Text == PasswordTextBox.Text && Password2TextBox.Text != "")
            {
                Password2TextBox.BackColor = Color.LightGreen;
            }
            else
                Password2TextBox.BackColor = Color.Red;
        }
    }
}
