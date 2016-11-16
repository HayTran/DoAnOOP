namespace QuanLyCuaHang
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(43, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(62, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "CHÀO MỪNG BẠN ĐẾN VỚI PHẦN MỀM ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(164, 89);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(190, 27);
            this.txtMaNhanVien.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(164, 134);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(190, 27);
            this.txtMatKhau.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(43, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(100, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "QUẢN LÝ CỬA HÀNG TIỆN LỢI";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(116, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vui lòng chọn chế độ đăng nhập";
            // 
            // btnBanHang
            // 
            this.btnBanHang.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBanHang.Image = global::QuanLyCuaHang.Properties.Resources.shop_cart_add_icon;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(260, 219);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(114, 45);
            this.btnBanHang.TabIndex = 8;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnQuanLy.Image = global::QuanLyCuaHang.Properties.Resources.Inventory_icon;
            this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.Location = new System.Drawing.Point(104, 219);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(110, 45);
            this.btnQuanLy.TabIndex = 7;
            this.btnQuanLy.Text = "Quản lý ";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(451, 289);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnQuanLy);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}