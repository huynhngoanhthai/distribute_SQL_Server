using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class baocao : Form
    {
        private String linkServer;
        public baocao(String linkServer)
        {
            this.linkServer = linkServer;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            home h = new home(linkServer);
            h.Show();
            this.Hide();
        }

        private void baocao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Sotk = SoTKTextBox.Text;
            
            String TuNgay = TuNgayTextBox.Text;
            String DenNgay = DenNgayTextBox.Text;

            saoke sk = new saoke(linkServer, Sotk, TuNgay, DenNgay);
            sk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String CN = ChiNhanhTKComboBox.Text;
            String TuNgay = TuNgayTKtextBox.Text;
            String DenNgay = DenNgayTKTextBox.Text;
            lietketaikhoan sk = new lietketaikhoan(linkServer, CN, TuNgay, DenNgay);
            sk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String CN = comboBox2.Text;
            lietkekhachhang sk = new lietkekhachhang(linkServer, CN);
            sk.Show();
        }
    }
}
