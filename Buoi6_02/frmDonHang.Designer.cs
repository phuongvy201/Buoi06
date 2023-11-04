namespace Buoi6_02
{
    partial class frmDonHang
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
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbxDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblThongTinSinhVien = new System.Windows.Forms.Label();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.dtNgayDatHang = new System.Windows.Forms.DateTimePicker();
            this.dtNgayGiaoHang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKieuDH = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.gbxChucNang.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(16, 28);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(85, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã đơn hàng";
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
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(164, 25);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(268, 22);
            this.txtMaDH.TabIndex = 2;
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
            // gbxDanhSach
            // 
            this.gbxDanhSach.Controls.Add(this.dgvDanhSach);
            this.gbxDanhSach.Location = new System.Drawing.Point(20, 346);
            this.gbxDanhSach.Name = "gbxDanhSach";
            this.gbxDanhSach.Size = new System.Drawing.Size(917, 275);
            this.gbxDanhSach.TabIndex = 23;
            this.gbxDanhSach.TabStop = false;
            this.gbxDanhSach.Text = "Danh sách";
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
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(499, 28);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(95, 16);
            this.lblDiemTB.TabIndex = 3;
            this.lblDiemTB.Text = "Ngày đặt hàng";
            // 
            // lblThongTinSinhVien
            // 
            this.lblThongTinSinhVien.AutoSize = true;
            this.lblThongTinSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSinhVien.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinSinhVien.Location = new System.Drawing.Point(338, 19);
            this.lblThongTinSinhVien.Name = "lblThongTinSinhVien";
            this.lblThongTinSinhVien.Size = new System.Drawing.Size(267, 29);
            this.lblThongTinSinhVien.TabIndex = 20;
            this.lblThongTinSinhVien.Text = "QUẢN LÝ ĐƠN HÀNG";
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
            this.gbxChucNang.TabIndex = 22;
            this.gbxChucNang.TabStop = false;
            this.gbxChucNang.Text = "Chức năng";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtGhiChu);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.cbKieuDH);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.dtNgayGiaoHang);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.dtNgayDatHang);
            this.gbThongTin.Controls.Add(this.lblDiemTB);
            this.gbThongTin.Controls.Add(this.txtMaDH);
            this.gbThongTin.Controls.Add(this.lblMaSV);
            this.gbThongTin.Location = new System.Drawing.Point(20, 69);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(917, 187);
            this.gbThongTin.TabIndex = 21;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // dtNgayDatHang
            // 
            this.dtNgayDatHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDatHang.Location = new System.Drawing.Point(625, 25);
            this.dtNgayDatHang.Name = "dtNgayDatHang";
            this.dtNgayDatHang.Size = new System.Drawing.Size(268, 22);
            this.dtNgayDatHang.TabIndex = 13;
            this.dtNgayDatHang.ValueChanged += new System.EventHandler(this.dtNgayDatHang_ValueChanged);
            // 
            // dtNgayGiaoHang
            // 
            this.dtNgayGiaoHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayGiaoHang.Location = new System.Drawing.Point(625, 92);
            this.dtNgayGiaoHang.Name = "dtNgayGiaoHang";
            this.dtNgayGiaoHang.Size = new System.Drawing.Size(268, 22);
            this.dtNgayGiaoHang.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ngày giao hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kiểu đơn hàng";
            // 
            // cbKieuDH
            // 
            this.cbKieuDH.FormattingEnabled = true;
            this.cbKieuDH.Location = new System.Drawing.Point(167, 88);
            this.cbKieuDH.Name = "cbKieuDH";
            this.cbKieuDH.Size = new System.Drawing.Size(265, 24);
            this.cbKieuDH.TabIndex = 18;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(164, 151);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(268, 22);
            this.txtGhiChu.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ghi chú";
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 640);
            this.Controls.Add(this.gbxDanhSach);
            this.Controls.Add(this.lblThongTinSinhVien);
            this.Controls.Add(this.gbxChucNang);
            this.Controls.Add(this.gbThongTin);
            this.Name = "frmDonHang";
            this.Text = "frmDonHang";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            this.gbxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.gbxChucNang.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbxDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblThongTinSinhVien;
        private System.Windows.Forms.GroupBox gbxChucNang;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKieuDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayGiaoHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayDatHang;
    }
}