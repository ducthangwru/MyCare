using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyCare.MyCareDataAccess.DataAcess;
using MyCare.MyCareDataAccess.Object;
using MyCare.MyCareDataAccess.Utils;

namespace MyCare
{
    public partial class FormQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public NhanVienOBJ obj = new NhanVienOBJ();
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            luQuyen.Properties.DataSource = TaiKhoanDB.DanhSachQuyen();
            GetDataGridQlyNhanVien(null);
        }

        private void GetDataGridQlyNhanVien(string timkiem)
        {
            grdQuanLyNhanVien.DataSource = TaiKhoanDB.DanhSachNhanVien(timkiem);
        }

        private void btnRefeshQlyNV_Click(object sender, EventArgs e)
        {
            GetDataGridQlyNhanVien(null);
        }

        private void btnSearchQlyNV_Click(object sender, EventArgs e)
        {
            GetDataGridQlyNhanVien(txbTimKiemNV.Text);
        }

        private void txbTimKiemNV_EditValueChanged(object sender, EventArgs e)
        {
            GetDataGridQlyNhanVien(txbTimKiemNV.Text);
        }

        private void gvQuanLyNhanVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //luQuyen
            txtTenDangNhap.Text = gvQuanLyNhanVien.GetRowCellValue(gvQuanLyNhanVien.FocusedRowHandle, gvQuanLyNhanVien.Columns["TenDangNhap"]).ToString();
            txtTenNhanVien.Text = gvQuanLyNhanVien.GetRowCellValue(gvQuanLyNhanVien.FocusedRowHandle, gvQuanLyNhanVien.Columns["TenTaiKhoan"]).ToString();
            txtMatKhau.Text = gvQuanLyNhanVien.GetRowCellValue(gvQuanLyNhanVien.FocusedRowHandle, gvQuanLyNhanVien.Columns["MatKhau"]).ToString();
            txtXacNhanMK.Text = txtMatKhau.Text;
            int TrangThai = bool.Parse(gvQuanLyNhanVien.GetRowCellValue(gvQuanLyNhanVien.FocusedRowHandle, gvQuanLyNhanVien.Columns["TrangThaiXoa"]).ToString()) ? 1 : 0;

            if (TrangThai == 1)
                radHetHieuLuc.Checked = true;
            else
                radConHieuLuc.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckOMatKhau())
                {
                    MessageBox.Show("Mật khẩu không trùng khớp! Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                obj.trangthai = (radConHieuLuc.Checked) ? 0 : 1;
                obj.idnhomtk = 2;//int.Parse(luQuyen.Properties.ValueMember);
                obj.tendangnhap = txtTenDangNhap.Text;
                obj.tennhanvien = txtTenNhanVien.Text;
                obj.matkhau = Utils.md5(txtMatKhau.Text);
                obj.idtaikhoan = int.Parse(gvQuanLyNhanVien.GetRowCellValue(gvQuanLyNhanVien.FocusedRowHandle, gvQuanLyNhanVien.Columns["IDTaiKhoan"]).ToString());

                int result = TaiKhoanDB.ThemMoiTaiKhoan(Config.IDNhanVien, obj);
                if (result == -1)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (result == 1)
                {
                    MessageBox.Show("Thêm thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi thêm mới tài khoản! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mới tài khoản! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetDataGridQlyNhanVien(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckOMatKhau())
                {
                    MessageBox.Show("Mật khẩu không trùng khớp! Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                    

                obj.trangthai = (radConHieuLuc.Checked) ? 0 : 1;
                obj.idnhomtk = 2;//int.Parse(luQuyen.Properties.ValueMember);
                obj.tendangnhap = txtTenDangNhap.Text;
                obj.tennhanvien = txtTenNhanVien.Text;
                obj.matkhau = Utils.md5(txtMatKhau.Text);
                obj.idtaikhoan = int.Parse(gvQuanLyNhanVien.GetRowCellValue(gvQuanLyNhanVien.FocusedRowHandle, gvQuanLyNhanVien.Columns["IDTaiKhoan"]).ToString());

                int result = TaiKhoanDB.CapNhatTaiKhoan(Config.IDNhanVien, obj);
                if (result == -1)
                {
                    MessageBox.Show("Tên đăng nhập không được thay đổi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật tài khoản! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật tài khoản! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetDataGridQlyNhanVien(null);
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMK_EditValueChanged(object sender, EventArgs e)
        {
            CheckOMatKhau();
        }

        private bool CheckOMatKhau()
        {
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                peXacNhanMK.Visible = false;
                return false;
            }
            else if (string.Compare(txtMatKhau.Text, txtXacNhanMK.Text) != 0)
            {
                peXacNhanMK.Visible = true;
                peXacNhanMK.Image = MyCare.Properties.Resources.cancel;
                return false;
            }
            else
            {
                peXacNhanMK.Visible = true;
                peXacNhanMK.Image = MyCare.Properties.Resources.accept;
                return true;
            }
        }

        private void txtMatKhau_EditValueChanged(object sender, EventArgs e)
        {
            CheckOMatKhau();
        }
    }
}