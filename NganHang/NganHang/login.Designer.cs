namespace NganHang
{
    partial class login
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
            this.DangNhapButton = new System.Windows.Forms.Button();
            this.MatKhauTextBox = new System.Windows.Forms.TextBox();
            this.DangNhapTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChiNhanhComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DangNhapButton
            // 
            this.DangNhapButton.Location = new System.Drawing.Point(284, 291);
            this.DangNhapButton.Margin = new System.Windows.Forms.Padding(2);
            this.DangNhapButton.Name = "DangNhapButton";
            this.DangNhapButton.Size = new System.Drawing.Size(225, 30);
            this.DangNhapButton.TabIndex = 4;
            this.DangNhapButton.Text = "Đăng nhập";
            this.DangNhapButton.UseVisualStyleBackColor = true;
            this.DangNhapButton.Click += new System.EventHandler(this.DangNhapButtonClick);
            // 
            // MatKhauTextBox
            // 
            this.MatKhauTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhauTextBox.Location = new System.Drawing.Point(284, 244);
            this.MatKhauTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MatKhauTextBox.Name = "MatKhauTextBox";
            this.MatKhauTextBox.PasswordChar = '*';
            this.MatKhauTextBox.Size = new System.Drawing.Size(227, 29);
            this.MatKhauTextBox.TabIndex = 3;
            this.MatKhauTextBox.Tag = "3";
            this.MatKhauTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.MatKhauTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MatKhauTextBox_KeyDown);
            // 
            // DangNhapTextBox
            // 
            this.DangNhapTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhapTextBox.Location = new System.Drawing.Point(284, 181);
            this.DangNhapTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DangNhapTextBox.Name = "DangNhapTextBox";
            this.DangNhapTextBox.Size = new System.Drawing.Size(227, 29);
            this.DangNhapTextBox.TabIndex = 2;
            this.DangNhapTextBox.Tag = "2";
            this.DangNhapTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chi nhánh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ChiNhanhComboBox
            // 
            this.ChiNhanhComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "BEN THANH",
            "TAN DINH"});
            this.ChiNhanhComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ChiNhanhComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ChiNhanhComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiNhanhComboBox.FormattingEnabled = true;
            this.ChiNhanhComboBox.Location = new System.Drawing.Point(284, 122);
            this.ChiNhanhComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChiNhanhComboBox.Name = "ChiNhanhComboBox";
            this.ChiNhanhComboBox.Size = new System.Drawing.Size(227, 32);
            this.ChiNhanhComboBox.TabIndex = 1;
            this.ChiNhanhComboBox.Tag = "1";
            this.ChiNhanhComboBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ChiNhanhComboBox_MeasureItem);
            this.ChiNhanhComboBox.SelectedIndexChanged += new System.EventHandler(this.label1_Click);
            this.ChiNhanhComboBox.TextChanged += new System.EventHandler(this.ChiNhanhComboBox_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 419);
            this.Controls.Add(this.ChiNhanhComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DangNhapTextBox);
            this.Controls.Add(this.MatKhauTextBox);
            this.Controls.Add(this.DangNhapButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DangNhapButton;
        private System.Windows.Forms.TextBox MatKhauTextBox;
        private System.Windows.Forms.TextBox DangNhapTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ChiNhanhComboBox;
    }
}

