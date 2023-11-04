namespace Buoi6_02
{
    partial class frmChiTietDH
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThongTinSinhVien = new System.Windows.Forms.Label();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.txtMaCTDH = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.gbxDanhSach = new System.Windows.Forms.GroupBox();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.gbxDanhSach.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã đơn hàng";
            // 
            // lblThongTinSinhVien
            // 
            this.lblThongTinSinhVien.AutoSize = true;
            this.lblThongTinSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSinhVien.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinSinhVien.Location = new System.Drawing.Point(338, 19);
            this.lblThongTinSinhVien.Name = "lblThongTinSinhVien";
            this.lblThongTinSinhVien.Size = new System.Drawing.Size(264, 29);
            this.lblThongTinSinhVien.TabIndex = 24;
            this.lblThongTinSinhVien.Text = "CHI TIẾT ĐƠN HÀNG";
            this.lblThongTinSinhVien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxChucNang
            // 
            this.gbxChucNang.Controls.Add(this.btnLoc);
            this.gbxChucNang.Controls.Add(this.btnXoa);
            this.gbxChucNang.Controls.Add(this.btnThoat);
            this.gbxChucNang.Controls.Add(this.btnLuu);
            this.gbxChucNang.Controls.Add(this.btnCapNhat);
            this.gbxChucNang.Controls.Add(this.btnThem);
            this.gbxChucNang.Location = new System.Drawing.Point(20, 262);
            this.gbxChucNang.Name = "gbxChucNang";
            this.gbxChucNang.Size = new System.Drawing.Size(917, 78);
            this.gbxChucNang.TabIndex = 26;
            this.gbxChucNang.TabStop = false;
            this.gbxChucNang.Text = "Chức năng";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.Silver;
            this.btnLoc.Location = new System.Drawing.Point(635, 25);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(113, 32);
            this.btnLoc.TabIndex = 8;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.Location = new System.Drawing.Point(479, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Silver;
            this.btnThoat.Location = new System.Drawing.Point(791, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Silver;
            this.btnLuu.Location = new System.Drawing.Point(323, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 32);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Silver;
            this.btnCapNhat.Location = new System.Drawing.Point(167, 25);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(113, 32);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Location = new System.Drawing.Point(11, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(164, 111);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(268, 22);
            this.txtMaSP.TabIndex = 20;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(12, 24);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(892, 245);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // txtMaCTDH
            // 
            this.txtMaCTDH.Location = new System.Drawing.Point(164, 25);
            this.txtMaCTDH.Name = "txtMaCTDH";
            this.txtMaCTDH.Size = new System.Drawing.Size(268, 22);
            this.txtMaCTDH.TabIndex = 2;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(16, 28);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(106, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã CT đơn hàng";
            // 
            // gbxDanhSach
            // 
            this.gbxDanhSach.Controls.Add(this.dgvDanhSach);
            this.gbxDanhSach.Location = new System.Drawing.Point(20, 346);
            this.gbxDanhSach.Name = "gbxDanhSach";
            this.gbxDanhSach.Size = new System.Drawing.Size(917, 275);
            this.gbxDanhSach.TabIndex = 27;
            this.gbxDanhSach.TabStop = false;
            this.gbxDanhSach.Text = "Danh sách";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtThanhTien);
            this.gbThongTin.Controls.Add(this.label7);
            this.gbThongTin.Controls.Add(this.txtSoLuong);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Controls.Add(this.txtDonGia);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.txtDonViTinh);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.txtTenSP);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.txtMaDH);
            this.gbThongTin.Controls.Add(this.txtMaSP);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.txtMaCTDH);
            this.gbThongTin.Controls.Add(this.lblMaSV);
            this.gbThongTin.Location = new System.Drawing.Point(20, 69);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(917, 187);
            this.gbThongTin.TabIndex = 25;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(164, 68);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(268, 22);
            this.txtMaDH.TabIndex = 21;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(635, 25);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(268, 22);
            this.txtTenSP.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên sản phẩm";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(635, 68);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(268, 22);
            this.txtDonViTinh.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Đơn vị tính";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(635, 111);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(268, 22);
            this.txtDonGia.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(164, 154);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(268, 22);
            this.txtSoLuong.TabIndex = 29;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(635, 154);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(268, 22);
            this.txtThanhTien.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Thành Tiền";
            // 
            // frmChiTietDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 640);
            this.Controls.Add(this.lblThongTinSinhVien);
            this.Controls.Add(this.gbxChucNang);
            this.Controls.Add(this.gbxDanhSach);
            this.Controls.Add(this.gbThongTin);
            this.Name = "frmChiTietDH";
            this.Text = "frmChiTietDH";
            this.Load += new System.EventHandler(this.frmChiTietDH_Load);
            this.gbxChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.gbxDanhSach.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThongTinSinhVien;
        private System.Windows.Forms.GroupBox gbxChucNang;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtMaCTDH;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.GroupBox gbxDanhSach;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}