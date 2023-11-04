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

namespace Buoi6_02
{
    public partial class Form1 : Form
    {

        SanPhamDAO spDAO = new SanPhamDAO();
        string insertupdate = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTongSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSP.Enabled = false;
            btnXoa.Enabled = false;
            loadDSSanPham();
            loadLoaiSP();
        }
        private void loadDSSanPham()
        {
            dgvDanhSach.DataSource = spDAO.getList();
        }
        private void loadLoaiSP()
        {
            cbLoaiSP.DataSource = spDAO.getList();
            cbLoaiSP.DisplayMember = "TenLoai";
            cbLoaiSP.ValueMember = "MaSanPham";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaSP.Enabled = true;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSP.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double giaMua = 0;
                double giaBan = 0;

                if (string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                    string.IsNullOrWhiteSpace(txtDonViTinh.Text) || !double.TryParse(txtGiaMua.Text, out giaMua) ||
                    !double.TryParse(txtGiaBan.Text, out giaBan))
                {
                    throw new Exception("Vui lòng điền đầy đủ thông tin sản phẩm và đảm bảo giá mua và giá bán là số.");
                }

                int maLoai = int.Parse(cbLoaiSP.SelectedValue.ToString());
                int maSanPham = int.Parse(txtMaSP.Text);
                string tenSanPham = txtTenSP.Text;
                string donViTinh = txtDonViTinh.Text;

                SanPham sp = new SanPham(maSanPham, maLoai, tenSanPham, donViTinh, giaMua, giaBan);

                switch (insertupdate)
                {
                    case "insert":
                        {
                            spDAO.InsertOne(sp);
                            loadDSSanPham();
                            MessageBox.Show("Thêm sản phẩm thành công.", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            spDAO.UpdateOne(sp);
                            loadDSSanPham();
                            MessageBox.Show("Cập nhật sản phẩm thành công.", "Thông báo");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }


        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm");
                }
                txtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSanPham"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenSanPham"].Value.ToString();
                txtDonViTinh.Text = dgvDanhSach.Rows[rowindex].Cells["DonViTinh"].Value.ToString();
                txtGiaMua.Text = dgvDanhSach.Rows[rowindex].Cells["GiaMua"].Value.ToString();
                txtGiaBan.Text = dgvDanhSach.Rows[rowindex].Cells["GiaBan"].Value.ToString();
                btnXoa.Enabled = true;

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
                int masp = int.Parse(txtMaSP.Text);
                spDAO.DeleteOne(masp);
                loadDSSanPham();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(cbLoaiSP.Text);
            dgvDanhSach.DataSource = spDAO.getList(masp);

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
