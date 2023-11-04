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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SachDao sDao = new SachDao();
        string insertupdate = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            loadDSSach();
        }
        private void loadDSSach()
        {
            dgvDanhSach.DataSource = sDao.getList();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sách");
                }
                txtMaSach.Text = dgvDanhSach.Rows[rowindex].Cells["MaSach"].Value.ToString();
                txtTenSach.Text = dgvDanhSach.Rows[rowindex].Cells["TenSach"].Value.ToString();
                txtTacGia.Text = dgvDanhSach.Rows[rowindex].Cells["TacGia"].Value.ToString();
                txtGiaSach.Text = dgvDanhSach.Rows[rowindex].Cells["GiaSach"].Value.ToString();
                cbMaLoai.Text = dgvDanhSach.Rows[rowindex].Cells["MaLoai"].Value.ToString();
                cbMaNXB.Text = dgvDanhSach.Rows[rowindex].Cells["MaNXB"].Value.ToString();
                txtNamXB.Text = dgvDanhSach.Rows[rowindex].Cells["NamXB"].Value.ToString();
                txtMaNV.Text = dgvDanhSach.Rows[rowindex].Cells["MaNV"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaSach.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSach.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double giaSach = 0;
                if (string.IsNullOrEmpty(txtMaSach.Text) || txtMaSach.Text.Length > 10)
                {
                    throw new Exception("Mã sách không được để trống và tối đa 10 ký tự.");
                }

                if (!double.TryParse(txtGiaSach.Text, out giaSach) || giaSach <= 0)
                {
                    throw new Exception("Giá sách phải là một số dương.");
                }

                int maSach = Convert.ToInt32(txtMaSach.Text);
                string tenSach = txtTenSach.Text;
                string tacGia = txtTacGia.Text;
                int maLoai = Convert.ToInt32(cbMaLoai.SelectedValue);
                int maNXB = Convert.ToInt32(cbMaNXB.SelectedValue);
                int namXB = Convert.ToInt32(txtNamXB.Text);
                int maNV = Convert.ToInt32(txtMaNV.Text);

                Sach book = new Sach(maSach, tenSach, tacGia, giaSach, maLoai, maNXB, namXB, maNV);

                switch (insertupdate)
                {
                    case "insert":
                        sDao.InsertOne(book);
                        loadDSSach();

                        MessageBox.Show("Thêm sách thành công!", "Thông báo");
                        break;
                    case "update":
                        sDao.UpdateOne(book);
                        loadDSSach();

                        MessageBox.Show("Cập nhật sách thành công!", "Thông báo");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSach.Text.Length != 10)
                {
                    throw new Exception("Mã sách không đúng");
                }
                string masach = txtMaSach.Text;
                sDao.DeleteOne(masach);
                loadDSSach();

                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
