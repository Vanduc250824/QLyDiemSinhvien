namespace QLyDiemSinhvien
{
    partial class Dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = Properties.Resources.logo_Trường_học;
            button1.Location = new Point(-2, -2);
            button1.Name = "button1";
            button1.Size = new Size(560, 627);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 623);
            Controls.Add(button1);
            Name = "Dangnhap";
            Text = "Đăng nhập";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
