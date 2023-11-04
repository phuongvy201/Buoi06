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
    public partial class LoaiSP : Form

    {
        LoaiSPDAO spDAO = new LoaiSPDAO();
        string insertupdate = "";
        public LoaiSP()
        {
            InitializeComponent();
        }

        private void LoaiSP_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSP.Enabled = false;
            btnXoa.Enabled = false;
            loadDSSanPham();

        }
        private void loadDSSanPham()
        {
            dgvDanhSach.DataSource = spDAO.getList();
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
                try
                {
                    if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
                    {
                        throw new Exception("Vui lòng điền đầy đủ thông tin sản phẩm.");
                    }

                    // Kiểm tra xem txtTenLoai.Text có phải là một số nguyên hợp lệ không
                    if (!int.TryParse(txtMaSP.Text, out int maLoai))
                    {
                        throw new Exception("Mã loại sản phẩm phải là một số nguyên hợp lệ.");
                    }

                    string tenLoai = txtTenLoai.Text; // Lưu ý: Đây nên thay bằng nguồn dữ liệu phù hợp
                    string chiTiet = txtChiTiet.Text; // Lưu ý: Đây nên thay bằng nguồn dữ liệu phù hợp

                    LoaiSanPham sp = new LoaiSanPham(maLoai, tenLoai, chiTiet);

                    switch (insertupdate)
                    {
                        case "insert":
                            {
                                spDAO.InsertOne(sp);
                                loadDSSanPham();
                                MessageBox.Show("Thêm loại sản phẩm thành công.", "Thông báo");
                                break;
                            }
                        case "update":
                            {
                                spDAO.UpdateOne(sp);
                                loadDSSanPham();
                                MessageBox.Show("Cập nhật loại sản phẩm thành công.", "Thông báo");
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
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
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0 && rowIndex < dgvDanhSach.Rows.Count - 1)
                {
                    txtMaSP.Text = dgvDanhSach.Rows[rowIndex].Cells["MaLoai"].Value.ToString();
                    txtTenLoai.Text = dgvDanhSach.Rows[rowIndex].Cells["TenLoai"].Value.ToString();
                    txtChiTiet.Text = dgvDanhSach.Rows[rowIndex].Cells["ChiTiet"].Value.ToString();
                    btnXoa.Enabled = true;
                }
                else
                {
                    throw new Exception("Chưa chọn loại sản phẩm");
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
