namespace Dang_Nhap
{
    partial class Init
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
            this.txtDangNhap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoathethong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDangNhap.Location = new System.Drawing.Point(174, 120);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(75, 23);
            this.txtDangNhap.TabIndex = 1;
            this.txtDangNhap.Text = "Đăng nhập";
            this.txtDangNhap.UseVisualStyleBackColor = false;
            this.txtDangNhap.Click += new System.EventHandler(this.txtDangNhap_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(49, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng kí";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chào mừng đến với khách sạn";
            // 
            // btnThoathethong
            // 
            this.btnThoathethong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThoathethong.Location = new System.Drawing.Point(202, 7);
            this.btnThoathethong.Name = "btnThoathethong";
            this.btnThoathethong.Size = new System.Drawing.Size(92, 23);
            this.btnThoathethong.TabIndex = 4;
            this.btnThoathethong.Text = "Thoát hệ thống";
            this.btnThoathethong.UseVisualStyleBackColor = false;
            this.btnThoathethong.Click += new System.EventHandler(this.btnThoathethong_Click);
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(296, 199);
            this.Controls.Add(this.btnThoathethong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDangNhap);
            this.Name = "Init";
            this.Text = "Init";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txtDangNhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoathethong;
    }
}