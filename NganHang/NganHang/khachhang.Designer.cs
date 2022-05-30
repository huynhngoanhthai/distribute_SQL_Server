namespace NganHang
{
    partial class customer
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DSKHDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CMNDTextBox = new System.Windows.Forms.TextBox();
            this.HoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DiaChiTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SDTTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.NgayCapTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSKHDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 50);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DSKHDataGridView
            // 
            this.DSKHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSKHDataGridView.Location = new System.Drawing.Point(156, 34);
            this.DSKHDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DSKHDataGridView.Name = "DSKHDataGridView";
            this.DSKHDataGridView.RowTemplate.Height = 28;
            this.DSKHDataGridView.Size = new System.Drawing.Size(621, 217);
            this.DSKHDataGridView.TabIndex = 3;
            this.DSKHDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSKHDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CMND";
            // 
            // CMNDTextBox
            // 
            this.CMNDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMNDTextBox.Location = new System.Drawing.Point(220, 272);
            this.CMNDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CMNDTextBox.Name = "CMNDTextBox";
            this.CMNDTextBox.Size = new System.Drawing.Size(158, 26);
            this.CMNDTextBox.TabIndex = 5;
            this.CMNDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // HoTextBox
            // 
            this.HoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTextBox.Location = new System.Drawing.Point(427, 272);
            this.HoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HoTextBox.Name = "HoTextBox";
            this.HoTextBox.Size = new System.Drawing.Size(153, 26);
            this.HoTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ";
            // 
            // TenTextBox
            // 
            this.TenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTextBox.Location = new System.Drawing.Point(661, 272);
            this.TenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TenTextBox.Name = "TenTextBox";
            this.TenTextBox.Size = new System.Drawing.Size(117, 26);
            this.TenTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên";
            // 
            // DiaChiTextBox
            // 
            this.DiaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiTextBox.Location = new System.Drawing.Point(220, 315);
            this.DiaChiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DiaChiTextBox.Name = "DiaChiTextBox";
            this.DiaChiTextBox.Size = new System.Drawing.Size(325, 26);
            this.DiaChiTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(591, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giới tính";
            // 
            // GioiTinhComboBox
            // 
            this.GioiTinhComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinhComboBox.FormattingEnabled = true;
            this.GioiTinhComboBox.Items.AddRange(new object[] {
            "NAM",
            "NU"});
            this.GioiTinhComboBox.Location = new System.Drawing.Point(662, 315);
            this.GioiTinhComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.GioiTinhComboBox.Name = "GioiTinhComboBox";
            this.GioiTinhComboBox.Size = new System.Drawing.Size(117, 28);
            this.GioiTinhComboBox.TabIndex = 13;
            this.GioiTinhComboBox.SelectedIndexChanged += new System.EventHandler(this.GioiTinhComboBox_SelectedIndexChanged);
            this.GioiTinhComboBox.TextChanged += new System.EventHandler(this.GioiTinhComboBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày cấp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SDTTextBox
            // 
            this.SDTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTTextBox.Location = new System.Drawing.Point(580, 367);
            this.SDTTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SDTTextBox.Name = "SDTTextBox";
            this.SDTTextBox.Size = new System.Drawing.Size(199, 26);
            this.SDTTextBox.TabIndex = 17;
            this.SDTTextBox.TextChanged += new System.EventHandler(this.SDTTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // NgayCapTextBox
            // 
            this.NgayCapTextBox.Location = new System.Drawing.Point(239, 369);
            this.NgayCapTextBox.Name = "NgayCapTextBox";
            this.NgayCapTextBox.Size = new System.Drawing.Size(230, 20);
            this.NgayCapTextBox.TabIndex = 15;
            this.NgayCapTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.NgayCapTextBox_MaskInputRejected);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 376);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 32);
            this.button4.TabIndex = 43;
            this.button4.Text = "trở lại";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 419);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.NgayCapTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SDTTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GioiTinhComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiaChiTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TenTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMNDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DSKHDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer";
            ((System.ComponentModel.ISupportInitialize)(this.DSKHDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DSKHDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CMNDTextBox;
        private System.Windows.Forms.TextBox HoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DiaChiTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GioiTinhComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SDTTextBox;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox NgayCapTextBox;
        private System.Windows.Forms.Button button4;
    }
}