using HuynhDucDat_6551071021_VP104_LTTQ.Models;

namespace HuynhDucDat_6551071021_VP104_LTTQ
{
    public partial class Form1 : Form
    {
        // Database first
        // Scaffold-DbContext "Data Source=.\SQLEXPRESS;Initial Catalog=DuLieu_NhanSu;Integrated Security=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context "DuLieuNhanSuContext" -Force
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            txtLuongCoBan.KeyPress += txtLuongCoBan_KeyPress;
            btnThem.Click += btnThem_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
        }

        // Tải lại dữ liệu từ cơ sở dữ liệu lên datagrid
        private void HienThiDanhSach()
        {
            using (var db = new DuLieuNhanSuContext())
            {
                dataGridView1.DataSource = db.Nhanviens.ToList();   
            }
            dataGridView1.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dataGridView1.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dataGridView1.Columns["LuongCoBan"].HeaderText = "Lương cơ bản";
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            chuyenDoiHienThiLuong();
        }
        // Chuyển đổi từ dạng 8000000 sang 8,000,000
        private void chuyenDoiHienThiLuong()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["LuongCoBan"].Value != null)
                {
                    if (long.TryParse(row.Cells["LuongCoBan"].Value.ToString(), out long luong))
                    {
                        row.Cells["LuongCoBan"].Value = luong.ToString("N0");
                    }
                }
            }       
        }

        // Bắt sự kiện phím esc để tắt chọn đối tượng
        private void cacPhimTatChoGridViews(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DatLaiTrangThai();
            }
            if(e.KeyCode == Keys.Delete)
            {
                if (btnXoa.Enabled)
                {
                    btnXoa_Click(sender, e);
                }
            }
        }
        // Đặt lại trạng thái gốc (không chọn gì)
        private void DatLaiTrangThai()
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtLuongCoBan.Clear();
            txtMaNhanVien.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dataGridView1.ClearSelection();
            txtMaNhanVien.Focus();
        }

        // Kiểm tra dữ liệu nhập vào
        private bool KiemTraNhap()
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return false;
            }
            if(txtTenNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return false;
            }
            if(txtLuongCoBan.Text.Trim() == "")
            {
                MessageBox.Show("Lương cơ bản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongCoBan.Focus();
                return false;
            }
            if (txtMaNhanVien.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã nhân viên không được vượt quá 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return false;
            }
            if (txtLuongCoBan.Text.Trim().Replace(",", "").Length > 12)
            {
                MessageBox.Show("Lương cơ bản không được vượt quá 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongCoBan.Focus();
                return false;
            }
            return true;
        }


        // Câu 1
        private void Form1_Load(object? sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            try
            {
                HienThiDanhSach();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Câu 2
        private void txtLuongCoBan_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và một dấu thập phân
            if (char.IsDigit(e.KeyChar))
                return;

            // Cho phép một dấu thập phân duy nhất
            //if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtLuongCoBan.Text.Contains('.') && !txtLuongCoBan.Text.Contains(','))
            //    return;

            e.Handled = true;
        }

        // Câu 3
        private void btnThoat_Click(object? sender, EventArgs e)
        {
            var sure = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sure == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
        // Câu 4
        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!KiemTraNhap())
                return;

            try
            {
                using (var db = new DuLieuNhanSuContext())
                {
                    string ma = txtMaNhanVien.Text.Trim();
                    if (db.Nhanviens.Any(nv => nv.MaNhanVien == ma))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNhanVien.Focus();
                        return;
                    }

                    db.Nhanviens.Add(new Nhanvien
                    {
                        MaNhanVien = ma,
                        TenNhanVien = txtTenNhanVien.Text.Trim(),
                        LuongCoBan = txtLuongCoBan.Text.Trim()
                    });
                    db.SaveChanges();
                }

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach();
                DatLaiTrangThai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Câu 5
        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value?.ToString();
            txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value?.ToString();
            txtLuongCoBan.Text = row.Cells["LuongCoBan"].Value?.ToString().Replace(",", "");
            txtMaNhanVien.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        // Câu 6
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa nhân viên " + txtMaNhanVien.Text + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes)
                return;

            try
            {
                using (var db = new DuLieuNhanSuContext())
                {
                    Nhanvien? nv = db.Nhanviens.Find(txtMaNhanVien.Text.Trim());
                    if (nv != null)
                    {
                        db.Nhanviens.Remove(nv);
                        db.SaveChanges();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                HienThiDanhSach();
                DatLaiTrangThai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Câu 7
        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (!KiemTraNhap())
                return;

            try
            {
                using (var db = new DuLieuNhanSuContext())
                {
                    Nhanvien? nv = db.Nhanviens.Find(txtMaNhanVien.Text.Trim());
                    if (nv != null)
                    {
                        nv.TenNhanVien = txtTenNhanVien.Text.Trim();
                        nv.LuongCoBan = txtLuongCoBan.Text.Trim().Replace(",", "");
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach();
                DatLaiTrangThai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
