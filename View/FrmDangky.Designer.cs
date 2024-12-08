namespace QLyDiemSinhvien.View
{
    partial class FrmDangky
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtTaikhoan = new TextBox();
            txtMatkhau = new TextBox();
            txtNhaplai = new TextBox();
            label5 = new Label();
            txtChucvu = new ComboBox();
            btnDangky = new Button();
            btnHuy = new Button();
            label6 = new Label();
            lbCaptcha = new Label();
            label7 = new Label();
            txtCaptcha = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 25);
            label1.Name = "label1";
            label1.Size = new Size(354, 42);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 106);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 165);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 216);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhập lại mật khẩu:";
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(313, 99);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(318, 27);
            txtTaikhoan.TabIndex = 4;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(313, 162);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(318, 27);
            txtMatkhau.TabIndex = 5;
            // 
            // txtNhaplai
            // 
            txtNhaplai.Location = new Point(313, 216);
            txtNhaplai.Name = "txtNhaplai";
            txtNhaplai.Size = new Size(318, 27);
            txtNhaplai.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 272);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 7;
            label5.Text = "Chức vụ:";
            // 
            // txtChucvu
            // 
            txtChucvu.FormattingEnabled = true;
            txtChucvu.Items.AddRange(new object[] { "Admin", "Giảng viên", "Sinh viên" });
            txtChucvu.Location = new Point(313, 269);
            txtChucvu.Name = "txtChucvu";
            txtChucvu.Size = new Size(151, 28);
            txtChucvu.TabIndex = 8;
            // 
            // btnDangky
            // 
            btnDangky.Location = new Point(253, 399);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(94, 29);
            btnDangky.TabIndex = 9;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(453, 399);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 272);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Captcha:";
            // 
            // lbCaptcha
            // 
            lbCaptcha.AutoSize = true;
            lbCaptcha.Location = new Point(581, 272);
            lbCaptcha.Name = "lbCaptcha";
            lbCaptcha.Size = new Size(0, 20);
            lbCaptcha.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 324);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 13;
            label7.Text = "Nhập Captcha:";
            // 
            // txtCaptcha
            // 
            txtCaptcha.Location = new Point(313, 324);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(125, 27);
            txtCaptcha.TabIndex = 14;
            // 
            // FrmDangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 450);
            Controls.Add(txtCaptcha);
            Controls.Add(label7);
            Controls.Add(lbCaptcha);
            Controls.Add(label6);
            Controls.Add(btnHuy);
            Controls.Add(btnDangky);
            Controls.Add(txtChucvu);
            Controls.Add(label5);
            Controls.Add(txtNhaplai);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTaikhoan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDangky";
            Text = "Đăng ký";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtTaikhoan;
        private TextBox txtMatkhau;
        private TextBox txtNhaplai;
        private Label label5;
        private ComboBox txtChucvu;
        private Button btnDangky;
        private Button btnHuy;
        private Label label6;
        private Label lbCaptcha;
        private Label label7;
        private TextBox txtCaptcha;
    }
}