using Buoi06_Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;

namespace Buoi6_02
{
    public partial class frmDonHang : Form
    {
        DonHangDAO spDAO = new DonHangDAO();
        string insertupdate = "";

        public frmDonHang()
        {
            InitializeComponent();
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaDH.Enabled = false;
            btnXoa.Enabled = false;
            loadLoaiSP();
            loadDSSanPham();
        }
        private void loadDSSanPham()
        {
            dgvDanhSach.DataSource = spDAO.getList();
        }
        private void loadLoaiSP()
        {
            cbKieuDH.DataSource = spDAO.getList();
            cbKieuDH.DisplayMember = "KieuDonHang";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaDH.Enabled = true;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaDH.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các điều kiện và dữ liệu nhập vào
                DateTime ngayDatHang;
                DateTime ngayGiaoHang;
                if (!DateTime.TryParse(dtNgayDatHang.Text, out ngayDatHang) ||
                    !DateTime.TryParse(dtNgayGiaoHang.Text, out ngayGiaoHang))
                {
                    throw new Exception("Vui lòng nhập ngày đặt hàng và ngày giao hàng hợp lệ.");
                }

                if (string.IsNullOrWhiteSpace(cbKieuDH.Text))
                {
                    throw new Exception("Vui lòng điền đầy đủ thông tin đơn hàng.");
                }

                int maDonHang = int.Parse(txtMaDH.Text);
                string kieuDonHang = cbKieuDH.Text;
                string ghiChu = txtGhiChu.Text;

                DonHang donHang = new DonHang(maDonHang, ngayDatHang, ngayGiaoHang, kieuDonHang, ghiChu);

                switch (insertupdate)
                {
                    case "insert":
                        {
                            spDAO.InsertOne(donHang);
                            loadDSSanPham();
                            MessageBox.Show("Thêm đơn hàng thành công.", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            spDAO.UpdateOne(donHang);
                            loadDSSanPham();
                            MessageBox.Show("Cập nhật đơn hàng thành công.", "Thông báo");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }

        }

        private void dtNgayDatHang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0 && rowIndex < dgvDanhSach.Rows.Count - 1)
                {
                    cbKieuDH.Text = dgvDanhSach.Rows[rowIndex].Cells["KieuDonHang"].Value.ToString();
                    dtNgayGiaoHang.Text = dgvDanhSach.Rows[rowIndex].Cells["NgayGiaoHang"].Value.ToString();
                    dtNgayDatHang.Text = dgvDanhSach.Rows[rowIndex].Cells["NgayDatHang"].Value.ToString();
                    txtMaDH.Text = dgvDanhSach.Rows[rowIndex].Cells["MaDonHang"].Value.ToString();
                    txtGhiChu.Text = dgvDanhSach.Rows[rowIndex].Cells["GhiChu"].Value.ToString();

                    btnXoa.Enabled = true;
                }
                else
                {
                    throw new Exception("Chưa chọn đơn hàng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int masp = int.Parse(txtMaDH.Text);
                spDAO.DeleteOne(masp);
                loadDSSanPham();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
