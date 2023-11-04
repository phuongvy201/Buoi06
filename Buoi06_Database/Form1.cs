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
    public partial class Form1 : Form
    {
        SinhVienDAO svDAO = new SinhVienDAO();
        KhoaDAO khDAO = new KhoaDAO();
        string insertupdate = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSV.Enabled = false;
            btnXoa.Enabled = false;
            loadDSSinhVien();
            loadDSKhoa();
            TongSinhVien();
        }
        private void loadDSSinhVien()
        {
            dgvDanhSach.DataSource = svDAO.getList();
        }
        private void loadDSKhoa()
        {
            cbKhoa.DataSource = khDAO.getList();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }
        private void TongSinhVien()
        {
            txtTongSV.Text = svDAO.getCount().ToString();
        }
        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaSV.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSV.Enabled = false;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if(rowindex==-1||rowindex>=dgvDanhSach.Rows.Count-1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                txtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;
                if(txtMaSV.Text.Length!=10)
                {
                    throw new Exception("Mã sinh viên 10 ký tự số");
                }
                if(!double.TryParse(txtDiemTB.Text,out diemtb))
                {
                    throw new Exception("Điểm sinh viên số");
                }
                string masv = txtMaSV.Text;
                string hoten = txtMaSV.Text;
                int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
                SinhVien sv=new SinhVien(masv, hoten, makhoa, diemtb);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            svDAO.InsertOne(sv);
                            loadDSSinhVien();
                            TongSinhVien();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            svDAO.UpdateTwo(sv);
                            loadDSSinhVien();
                            TongSinhVien();
                            MessageBox.Show("Cập nhật thành công", "Thông báo");
                            break;
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSV.Text.Length!=10)
                {
                    throw new Exception("Mã sinh viên không đúng");
                }    
                string masv = txtMaSV.Text;
                svDAO.DeleteOne(masv);
                loadDSSinhVien();
                TongSinhVien();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int makhoa = int.Parse(cbKhoa.Text);
            dgvDanhSach.DataSource = svDAO.getList(makhoa);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.No)
            {
                e.Cancel = true;
            }    
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblThongTinSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void gbxChucNang_Enter(object sender, EventArgs e)
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

        private void gbThongTin_Enter(object sender, EventArgs e)
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

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblMaSV_Click(object sender, EventArgs e)
        {

        }
    }
}
