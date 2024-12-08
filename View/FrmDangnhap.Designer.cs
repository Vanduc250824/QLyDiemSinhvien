namespace QLyDiemSinhvien.View
{
    partial class FrmDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangnhap));
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label5 = new Label();
            btnDangnhap = new Button();
            linkFrmDangky = new LinkLabel();
            label4 = new Label();
            txtMatkhau = new TextBox();
            txtTaikhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(708, 135);
            label1.Name = "label1";
            label1.Size = new Size(200, 41);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnDangnhap);
            panel1.Controls.Add(linkFrmDangky);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMatkhau);
            panel1.Controls.Add(txtTaikhoan);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 566);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(581, 563);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(599, 35);
            label5.Name = "label5";
            label5.Size = new Size(453, 41);
            label5.TabIndex = 9;
            label5.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(757, 405);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(127, 29);
            btnDangnhap.TabIndex = 8;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // linkFrmDangky
            // 
            linkFrmDangky.AutoSize = true;
            linkFrmDangky.Location = new Point(777, 359);
            linkFrmDangky.Name = "linkFrmDangky";
            linkFrmDangky.Size = new Size(60, 20);
            linkFrmDangky.TabIndex = 7;
            linkFrmDangky.TabStop = true;
            linkFrmDangky.Text = "Đăng kí";
            linkFrmDangky.LinkClicked += linkFrmDangky_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(632, 359);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 6;
            label4.Text = "Chưa có tài khoản ?";
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(723, 298);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(260, 27);
            txtMatkhau.TabIndex = 5;
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(723, 219);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(260, 27);
            txtTaikhoan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(632, 301);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(631, 219);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Tài khoản:";
            // 
            // FrmDangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 563);
            Controls.Add(panel1);
            Name = "FrmDangnhap";
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private LinkLabel linkFrmDangky;
        private Label label4;
        private TextBox txtMatkhau;
        private TextBox txtTaikhoan;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnDangnhap;
        private Button button1;
    }
}