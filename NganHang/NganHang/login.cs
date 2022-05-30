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
    public partial class login : Form
    {
        

        public login()
        {
            InitializeComponent();
            this.ChiNhanhComboBox.Text = "BEN THANH";
            string[] installs = new string[] { "BEN THANH", "TAN DINH" };
            ChiNhanhComboBox.Items.AddRange(installs);
            this.Controls.Add(this.ChiNhanhComboBox);
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tileBarDropDownContainer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangNhapButtonClick(object sender, EventArgs e)
        {
            try

            {
                String serverName = "";
                String UID = DangNhapTextBox.Text;
                String PASS = MatKhauTextBox.Text;

                if (ChiNhanhComboBox.Text == "BEN THANH")
                    serverName = @"DESKTOP-HLUE84B\SERVER1";
                else
                    serverName = @"DESKTOP-HLUE84B\SERVER2";

                String linkServer = "server=" + serverName + ";database=NGANHANG;UID=" + UID + ";password=" + PASS;
                SqlConnection con = new SqlConnection(linkServer);               
                con.Open();
       
                MessageBox.Show("Đăng nhập thành công!");


               home HOME = new home(linkServer);
                HOME.Show();
                this.Hide();
                

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }

        }

        private void MatKhauTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DangNhapButtonClick(sender, e);
            
        }

        private void ChiNhanhComboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            MessageBox.Show("!@3");
        }

        private void ChiNhanhComboBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
