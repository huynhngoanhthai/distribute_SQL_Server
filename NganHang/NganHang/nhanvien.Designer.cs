namespace NganHang
{
    partial class nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.DSNVDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SDTTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PhaiComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DiaChiTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSNVDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // DSNVDataGridView
            // 
            this.DSNVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSNVDataGridView.Location = new System.Drawing.Point(156, 40);
            this.DSNVDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DSNVDataGridView.Name = "DSNVDataGridView";
            this.DSNVDataGridView.RowTemplate.Height = 28;
            this.DSNVDataGridView.Size = new System.Drawing.Size(621, 206);
            this.DSNVDataGridView.TabIndex = 22;
            this.DSNVDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSNVDataGridView_CellClick);
            this.DSNVDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DSNVDataGridView_CellFormatting);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 56);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SDTTextBox
            // 
            this.SDTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTTextBox.Location = new System.Drawing.Point(261, 339);
            this.SDTTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SDTTextBox.Name = "SDTTextBox";
            this.SDTTextBox.Size = new System.Drawing.Size(199, 26);
            this.SDTTextBox.TabIndex = 37;
            this.SDTTextBox.TextChanged += new System.EventHandler(this.SDTTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(155, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Số điện thoại";
            // 
            // PhaiComboBox
            // 
            this.PhaiComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhaiComboBox.FormattingEnabled = true;
            this.PhaiComboBox.Items.AddRange(new object[] {
            "NAM",
            "NU"});
            this.PhaiComboBox.Location = new System.Drawing.Point(657, 302);
            this.PhaiComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhaiComboBox.Name = "PhaiComboBox";
            this.PhaiComboBox.Size = new System.Drawing.Size(117, 28);
            this.PhaiComboBox.TabIndex = 33;
            this.PhaiComboBox.TextChanged += new System.EventHandler(this.PhaiComboBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(586, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Giới tính";
            // 
            // DiaChiTextBox
            // 
            this.DiaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiTextBox.Location = new System.Drawing.Point(215, 302);
            this.DiaChiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DiaChiTextBox.Name = "DiaChiTextBox";
            this.DiaChiTextBox.Size = new System.Drawing.Size(325, 26);
            this.DiaChiTextBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Địa chỉ";
            // 
            // TenTextBox
            // 
            this.TenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTextBox.Location = new System.Drawing.Point(657, 259);
            this.TenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TenTextBox.Name = "TenTextBox";
            this.TenTextBox.Size = new System.Drawing.Size(117, 26);
            this.TenTextBox.TabIndex = 29;
            this.TenTextBox.TextChanged += new System.EventHandler(this.TenTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên";
            // 
            // HoTextBox
            // 
            this.HoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTextBox.Location = new System.Drawing.Point(422, 259);
            this.HoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HoTextBox.Name = "HoTextBox";
            this.HoTextBox.Size = new System.Drawing.Size(153, 26);
            this.HoTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Họ";
            // 
            // MaTextBox
            // 
            this.MaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTextBox.Location = new System.Drawing.Point(215, 259);
            this.MaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaTextBox.Name = "MaTextBox";
            this.MaTextBox.Size = new System.Drawing.Size(158, 26);
            this.MaTextBox.TabIndex = 25;
            this.MaTextBox.TextChanged += new System.EventHandler(this.MaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã NV";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(589, 382);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(185, 26);
            this.PasswordTextBox.TabIndex = 41;
            this.PasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mật khẩu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Enabled = false;
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTextBox.Location = new System.Drawing.Point(275, 380);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(169, 26);
            this.LoginTextBox.TabIndex = 39;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 384);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tên đăng nhập";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 376);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 32);
            this.button4.TabIndex = 42;
            this.button4.Text = "trở lại";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 34);
            this.button5.TabIndex = 43;
            this.button5.Text = "Đổi chi nhanh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 419);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SDTTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PhaiComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiaChiTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TenTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DSNVDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "nhanvien";
            this.Text = "nhanvien";
            this.Load += new System.EventHandler(this.nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSNVDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DSNVDataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SDTTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PhaiComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiaChiTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}