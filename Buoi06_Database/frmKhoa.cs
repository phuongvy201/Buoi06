using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi06_Database
{
    public partial class frmKhoa : Form
    {
        KhoaDAO khDAO = new KhoaDAO();
        string insertupdate = "";
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaKhoa.Enabled = false;
            btnXoa.Enabled = false;
            loadDSKhoa();
            
        }

        private void loadDSKhoa()
        {
            dgvDanhSach.DataSource = khDAO.getList();
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDiemTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKhoa_Click(object sender, EventArgs e)
        {

        }

        private void lblDiemTB_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblMaSV_Click(object sender, EventArgs e)
        {

        }

        private void gbxDanhSach_Enter(object sender, EventArgs e)
        {

        }

        private void txtTongSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbxChucNang_Enter(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void lblThongTinSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void gbThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void lblMaSV_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblDiemTB_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDiemTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaKhoa.Enabled = true;
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaKhoa.Enabled = false;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if(rowindex==-1||rowindex>=dgvDanhSach.Rows.Count-1)
                {
                    throw new Exception("Chưa chọn khoa");
                }
                txtMaKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["MaKhoa"].Value.ToString();
                txtTenKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtGhiChu.Text = dgvDanhSach.Rows[rowindex].Cells["GhiChu"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;
                string makhoa = txtMaKhoa.Text;
                string tenkhoa = txtTenKhoa.Text;
                string ghichu = txtGhiChu.Text;
                Khoa khoa = new Khoa(makhoa, tenkhoa, ghichu);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            khDAO.Insert(khoa);
                            loadDSKhoa();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            khDAO.Update(khoa);
                            loadDSKhoa();
                            MessageBox.Show("Cập nhật thành công", "Thông báo");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
