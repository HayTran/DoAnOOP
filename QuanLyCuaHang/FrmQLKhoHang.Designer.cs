namespace QuanLyCuaHang
{
    partial class FrmQLKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLKhoHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateHSD = new System.Windows.Forms.DateTimePicker();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.dateNgaySX = new System.Windows.Forms.DateTimePicker();
            this.txtNguoiNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhoHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChapNhan = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateHSD);
            this.groupBox1.Controls.Add(this.dateNgayNhap);
            this.groupBox1.Controls.Add(this.dateNgaySX);
            this.groupBox1.Controls.Add(this.txtNguoiNhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(14, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(656, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateHSD
            // 
            this.dateHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHSD.Location = new System.Drawing.Point(441, 94);
            this.dateHSD.Name = "dateHSD";
            this.dateHSD.Size = new System.Drawing.Size(200, 27);
            this.dateHSD.TabIndex = 18;
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayNhap.Location = new System.Drawing.Point(441, 28);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(200, 27);
            this.dateNgayNhap.TabIndex = 3;
            this.dateNgayNhap.ValueChanged += new System.EventHandler(this.dateNgayNhap_ValueChanged);
            // 
            // dateNgaySX
            // 
            this.dateNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySX.Location = new System.Drawing.Point(441, 61);
            this.dateNgaySX.Name = "dateNgaySX";
            this.dateNgaySX.Size = new System.Drawing.Size(200, 27);
            this.dateNgaySX.TabIndex = 17;
            // 
            // txtNguoiNhap
            // 
            this.txtNguoiNhap.Location = new System.Drawing.Point(441, 130);
            this.txtNguoiNhap.Name = "txtNguoiNhap";
            this.txtNguoiNhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNguoiNhap.Size = new System.Drawing.Size(200, 27);
            this.txtNguoiNhap.TabIndex = 16;
            this.txtNguoiNhap.TextChanged += new System.EventHandler(this.txtNguoiNhap_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(320, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Người nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(320, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hạn sử dụng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(320, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày sản xuất:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(320, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày nhập:";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(106, 130);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGiaTien.Size = new System.Drawing.Size(195, 27);
            this.txtGiaTien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá tiền:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(106, 97);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoLuong.Size = new System.Drawing.Size(195, 27);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(106, 64);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTenMH.Size = new System.Drawing.Size(195, 27);
            this.txtTenMH.TabIndex = 4;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(106, 31);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMaMH.Size = new System.Drawing.Size(195, 27);
            this.txtMaMH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên MH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã MH:";
            // 
            // dgvKhoHang
            // 
            this.dgvKhoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoHang.Location = new System.Drawing.Point(14, 270);
            this.dgvKhoHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvKhoHang.Name = "dgvKhoHang";
            this.dgvKhoHang.Size = new System.Drawing.Size(944, 371);
            this.dgvKhoHang.TabIndex = 2;
            this.dgvKhoHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoHang_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChapNhan);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(701, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 168);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChapNhan.Location = new System.Drawing.Point(133, 54);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(104, 27);
            this.btnChapNhan.TabIndex = 9;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.UseVisualStyleBackColor = true;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnThem.Location = new System.Drawing.Point(25, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 27);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnHuy.Location = new System.Drawing.Point(133, 102);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 27);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSua.Location = new System.Drawing.Point(25, 78);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 27);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnXoa.Location = new System.Drawing.Point(25, 123);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 27);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Image = global::QuanLyCuaHang.Properties.Resources._1479313693_restart_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(47, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Quay về";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmQLKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvKhoHang);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmQLKhoHang";
            this.Text = "QUẢN LÝ KHO HÀNG";
            this.Load += new System.EventHandler(this.NhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKhoHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNguoiNhap;
        private System.Windows.Forms.DateTimePicker dateHSD;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private System.Windows.Forms.DateTimePicker dateNgaySX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChapNhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
    }
}