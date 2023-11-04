using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_03
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVienDao nvDao = new NhanVienDao();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadDSNhanVien();
        }
        private void loadDSNhanVien()
        {
            dgvDanhSach.DataSource = nvDao.getList();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn nhân viên");
                }
                txtMaNV.Text = dgvDanhSach.Rows[rowindex].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvDanhSach.Rows[rowindex].Cells["TenNV"].Value.ToString();
                txtGioiTinh.Text = dgvDanhSach.Rows[rowindex].Cells["GioiTinh"].Value.ToString();
                txtDienThoai.Text = dgvDanhSach.Rows[rowindex].Cells["DienThoai"].Value.ToString();
                txtEmail.Text = dgvDanhSach.Rows[rowindex].Cells["Email"].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    }
}
