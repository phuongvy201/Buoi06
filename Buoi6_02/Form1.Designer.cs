namespace Buoi6_02
{
    partial class Form1
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
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblThongTinSinhVien = new System.Windows.Forms.Label();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.gbxDanhSach = new System.Windows.Forms.GroupBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.gbxChucNang.SuspendLayout();
            this.gbxDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(625, 25);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(268, 22);
            this.txtDonViTinh.TabIndex = 12;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(625, 84);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(268, 24);
            this.cbLoaiSP.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.AcceptsReturn = true;
            this.txtTenSP.Location = new System.Drawing.Point(164, 85);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(268, 22);
            this.txtTenSP.TabIndex = 5;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(499, 88);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(95, 16);
            this.lblKhoa.TabIndex = 4;
            this.lblKhoa.Text = "Loại sản phẩm";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(499, 28);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(67, 16);
            this.lblDiemTB.TabIndex = 3;
            this.lblDiemTB.Text = "Đơn vị tính";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(164, 25);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(268, 22);
            this.txtMaSP.TabIndex = 2;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(16, 28);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(88, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sản phẩm";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtGiaBan);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.txtGiaMua);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.txtDonViTinh);
            this.gbThongTin.Controls.Add(this.cbLoaiSP);
            this.gbThongTin.Controls.Add(this.txtTenSP);
            this.gbThongTin.Controls.Add(this.lblKhoa);
            this.gbThongTin.Controls.Add(this.lblDiemTB);
            this.gbThongTin.Controls.Add(this.txtMaSP);
            this.gbThongTin.Controls.Add(this.lblHoTen);
            this.gbThongTin.Controls.Add(this.lblMaSV);
            this.gbThongTin.Location = new System.Drawing.Point(20, 76);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(917, 187);
            this.gbThongTin.TabIndex = 13;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(16, 88);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(93, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Tên sản phẩm";
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
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
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
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
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
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            // lblThongTinSinhVien
            // 
            this.lblThongTinSinhVien.AutoSize = true;
            this.lblThongTinSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSinhVien.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinSinhVien.Location = new System.Drawing.Point(338, 26);
            this.lblThongTinSinhVien.Name = "lblThongTinSinhVien";
            this.lblThongTinSinhVien.Size = new System.Drawing.Size(294, 29);
            this.lblThongTinSinhVien.TabIndex = 12;
            this.lblThongTinSinhVien.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // gbxChucNang
            // 
            this.gbxChucNang.Controls.Add(this.btnLoc);
            this.gbxChucNang.Controls.Add(this.btnXoa);
            this.gbxChucNang.Controls.Add(this.btnThoat);
            this.gbxChucNang.Controls.Add(this.btnLuu);
            this.gbxChucNang.Controls.Add(this.btnCapNhat);
            this.gbxChucNang.Controls.Add(this.btnThem);
            this.gbxChucNang.Location = new System.Drawing.Point(20, 269);
            this.gbxChucNang.Name = "gbxChucNang";
            this.gbxChucNang.Size = new System.Drawing.Size(917, 78);
            this.gbxChucNang.TabIndex = 14;
            this.gbxChucNang.TabStop = false;
            this.gbxChucNang.Text = "Chức năng";
            // 
            // gbxDanhSach
            // 
            this.gbxDanhSach.Controls.Add(this.dgvDanhSach);
            this.gbxDanhSach.Location = new System.Drawing.Point(20, 353);
            this.gbxDanhSach.Name = "gbxDanhSach";
            this.gbxDanhSach.Size = new System.Drawing.Size(917, 275);
            this.gbxDanhSach.TabIndex = 15;
            this.gbxDanhSach.TabStop = false;
            this.gbxDanhSach.Text = "Danh sách";
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.AcceptsReturn = true;
            this.txtGiaMua.Location = new System.Drawing.Point(164, 145);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(268, 22);
            this.txtGiaMua.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giá mua";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.AcceptsReturn = true;
            this.txtGiaBan.Location = new System.Drawing.Point(626, 145);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(267, 22);
            this.txtGiaBan.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giá bán";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 640);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblThongTinSinhVien);
            this.Controls.Add(this.gbxChucNang);
            this.Controls.Add(this.gbxDanhSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.gbxChucNang.ResumeLayout(false);
            this.gbxDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblThongTinSinhVien;
        private System.Windows.Forms.GroupBox gbxChucNang;
        private System.Windows.Forms.GroupBox gbxDanhSach;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label3;
    }
}

