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
using MyCare.MyCareDataAccess.Utils;

namespace MyCare
{
    public partial class FormQuanLyDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public int IDDanhMuc = 0;
        public int TrangThai = 0;

        public FormQuanLyDanhMuc()
        {
            InitializeComponent();
        }

        private void FormQuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            GetDataGridQlyDanhMuc(null);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            GetDataGridQlyDanhMuc(null);
        }

        private void GetDataGridQlyDanhMuc(string timkiem)
        {
            try
            {
                grdQuanLyDanhMuc.DataSource = DanhMucThuocDB.DanhSachDanhMuc(timkiem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txbTimKiemDanhMuc_EditValueChanged(object sender, EventArgs e)
        {
            GetDataGridQlyDanhMuc(txbTimKiemDanhMuc.Text);
        }

        private void gvQuanLyDanhMuc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtTenDanhMuc.Text = gvQuanLyDanhMuc.GetRowCellValue(gvQuanLyDanhMuc.FocusedRowHandle, gvQuanLyDanhMuc.Columns["TenDanhMuc"]).ToString();
            IDDanhMuc = int.Parse(gvQuanLyDanhMuc.GetRowCellValue(gvQuanLyDanhMuc.FocusedRowHandle, gvQuanLyDanhMuc.Columns["ID"]).ToString());
            TrangThai = bool.Parse(gvQuanLyDanhMuc.GetRowCellValue(gvQuanLyDanhMuc.FocusedRowHandle, gvQuanLyDanhMuc.Columns["TrangThaiXoa"]).ToString()) ? 1 : 0;
            if (TrangThai == 1)
                radHetHieuLuc.Checked = true;
            else
                radConHieuLuc.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TrangThai = (radConHieuLuc.Checked) ? 0 : 1;

            if(DanhMucThuocDB.ThemMoiDanhMuc(Config.IDNhanVien, txtTenDanhMuc.Text, TrangThai, txtGhiChu.Text))
            {
                MessageBox.Show("Thêm mới danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm mới danh mục không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetDataGridQlyDanhMuc(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TrangThai = (radConHieuLuc.Checked) ? 0 : 1;

            if (DanhMucThuocDB.CapNhatDanhMuc(Config.IDNhanVien, IDDanhMuc, txtTenDanhMuc.Text, TrangThai, txtGhiChu.Text))
            {
                MessageBox.Show("Cập nhật danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật danh mục không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetDataGridQlyDanhMuc(null);
        }
    }
}