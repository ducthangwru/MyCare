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
using MyCare.MyCareDataAccess.Object;

namespace MyCare
{
    public partial class FormQuanLyThuoc : DevExpress.XtraEditors.XtraForm
    {
        ThuocOBJ obj = new ThuocOBJ();
        public FormQuanLyThuoc()
        {
            InitializeComponent();
        }

        private void FormQuanLyThuoc_Load(object sender, EventArgs e)
        {
            GetDataGridQlyThuoc(null);
            luDonVi.Properties.DataSource = DonViDB.DanhSachDonVi();
            luDanhMuc.Properties.DataSource = DanhMucThuocDB.DanhSachChonDanhMuc();
            radConHieuLuc.Checked = true;
        }

        private void GetDataGridQlyThuoc(string timkiem)
        {
            grdQuanLyThuoc.DataSource = KhoThuocDB.DanhSachKhoThuoc(Config.IDNhanVien, timkiem);
        }

        private void btnLRefreshThuoc_Click(object sender, EventArgs e)
        {
            GetDataGridQlyThuoc(null);
        }

        private void txbTimKiemQlyThuoc_EditValueChanged(object sender, EventArgs e)
        {
            GetDataGridQlyThuoc(txbTimKiemQlyThuoc.Text);
        }

        private void btnSearchThuoc_Click(object sender, EventArgs e)
        {
            GetDataGridQlyThuoc(txbTimKiemQlyThuoc.Text);
        }

        private void gvQuanLyThuoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //luDanhMuc.EditValue = luDanhMuc.Properties.GetKeyValueByDisplayText(gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["TenDanhMuc"]).ToString());
            //luDanhMuc.Properties.ValueMember = gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["ID_DanhMuc"]).ToString();
            //luDonVi.Properties.DisplayMember = gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["TenDonVi"]).ToString();
            //luDonVi.Properties.ValueMember = gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["ID_DonVi"]).ToString();
            txtGiaNhap.Text = gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["GiaNhap"]).ToString();
            txtGiaXuat.Text = gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["Gia"]).ToString();
            txtNgayTao.Text = gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["NgayLap"]).ToString();
            txtNoiDung.Text = gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["NoiDung"]).ToString();
            txtTenThuoc.Text = gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["TenThuoc"]).ToString();

            if (obj.TrangThai == 1)
                radHetHieuLuc.Checked = true;
            else
                radConHieuLuc.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                obj.TrangThai = (radConHieuLuc.Checked) ? 0 : 1;
                obj.IDDanhMuc = int.Parse(luDanhMuc.Properties.ValueMember);
                obj.IDDonVi = int.Parse(luDonVi.Properties.ValueMember);
                obj.GhiChu = txtGhiChu.Text;
                obj.GiaNhap = double.Parse(txtGiaNhap.Text);
                obj.GiaXuat = double.Parse(txtGiaXuat.Text);
                obj.NoiDung = txtNoiDung.Text;
                obj.TenThuoc = txtTenThuoc.Text;
                //obj.IDThuoc = int.Parse(gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["IDThuoc"]).ToString());

                int result = KhoThuocDB.ThemMoiThuoc(Config.IDNhanVien, obj);
                if (result == -1)
                {
                    MessageBox.Show("Tên thuốc đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (result == 1)
                {
                    MessageBox.Show("Thêm mới thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi thêm mới thuốc! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mới thuốc! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetDataGridQlyThuoc(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                obj.TrangThai = (radConHieuLuc.Checked) ? 0 : 1;
                obj.IDDanhMuc = int.Parse(gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["ID_DanhMuc"]).ToString());
                obj.IDDonVi = int.Parse(gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["ID_DonVi"]).ToString());
                obj.GhiChu = txtGhiChu.Text;
                obj.GiaNhap = double.Parse(txtGiaNhap.Text);
                obj.GiaXuat = double.Parse(txtGiaXuat.Text);
                obj.NoiDung = txtNoiDung.Text;
                obj.TenThuoc = txtTenThuoc.Text;
                obj.IDThuoc = int.Parse(gvQuanLyThuoc.GetRowCellValue(gvQuanLyThuoc.FocusedRowHandle, gvQuanLyThuoc.Columns["IDThuoc"]).ToString());

                int result = KhoThuocDB.CapNhatThuoc(Config.IDNhanVien, obj);

                if(result > 0)
                {
                    MessageBox.Show("Cập nhật thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                GetDataGridQlyThuoc(null);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}