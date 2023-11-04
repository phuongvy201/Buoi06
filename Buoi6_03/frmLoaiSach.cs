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
    public partial class frmLoaiSach : Form
    {
        public frmLoaiSach()
        {
            InitializeComponent();
        }
        LoaiSachDao lsDao = new LoaiSachDao();
        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            loadLoaiSach();
        }
        private void loadLoaiSach()
        {
            dgvDanhSach.DataSource = lsDao.getList();
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn loại sách");
                }
                txtTenLoai.Text = dgvDanhSach.Rows[rowindex].Cells["TenSach"].Value.ToString();
                cbMaLoai.Text = dgvDanhSach.Rows[rowindex].Cells["MaLoai"].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }
    }
}
