namespace QLyDiemSinhvien.View
{
    partial class FrmQuanly
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
            panel1 = new Panel();
            lbName = new Label();
            btnGiangvien = new Button();
            btnMonhoc = new Button();
            btnLophoc = new Button();
            btnDangxuat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDangxuat);
            panel1.Controls.Add(btnLophoc);
            panel1.Controls.Add(btnMonhoc);
            panel1.Controls.Add(btnGiangvien);
            panel1.Controls.Add(lbName);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 606);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(94, 37);
            lbName.Name = "lbName";
            lbName.Size = new Size(61, 29);
            lbName.TabIndex = 0;
            lbName.Text = "name";
            // 
            // btnGiangvien
            // 
            btnGiangvien.Location = new Point(0, 143);
            btnGiangvien.Name = "btnGiangvien";
            btnGiangvien.Size = new Size(250, 49);
            btnGiangvien.TabIndex = 1;
            btnGiangvien.Text = "Giảng viên";
            btnGiangvien.UseVisualStyleBackColor = true;
            // 
            // btnMonhoc
            // 
            btnMonhoc.Location = new Point(0, 198);
            btnMonhoc.Name = "btnMonhoc";
            btnMonhoc.Size = new Size(250, 49);
            btnMonhoc.TabIndex = 2;
            btnMonhoc.Text = "Môn học";
            btnMonhoc.UseVisualStyleBackColor = true;
            // 
            // btnLophoc
            // 
            btnLophoc.Location = new Point(0, 253);
            btnLophoc.Name = "btnLophoc";
            btnLophoc.Size = new Size(250, 49);
            btnLophoc.TabIndex = 3;
            btnLophoc.Text = "Lớp học";
            btnLophoc.UseVisualStyleBackColor = true;
            // 
            // btnDangxuat
            // 
            btnDangxuat.Location = new Point(78, 567);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(94, 29);
            btnDangxuat.TabIndex = 4;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.UseVisualStyleBackColor = true;
            // 
            // FrmQuanly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 609);
            Controls.Add(panel1);
            Name = "FrmQuanly";
            Text = "Quản lý";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGiangvien;
        private Label lbName;
        private Button btnMonhoc;
        private Button btnDangxuat;
        private Button btnLophoc;
    }
}