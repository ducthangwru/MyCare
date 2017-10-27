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

namespace MyCare
{
    public partial class FormQuanLyKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public KhachHangOBJ obj = new KhachHangOBJ();
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            radConHieuLuc.Checked = true;
            GetDataGridQlyKH(null);
        }

        private void btnSearchQlyKH_Click(object sender, EventArgs e)
        {
            GetDataGridQlyKH(txbTimKiemKH.Text);
        }

        private void btnRefeshQlyKH_Click(object sender, EventArgs e)
        {
            GetDataGridQlyKH(null);
        }

        private void txbTimKiemKH_EditValueChanged(object sender, EventArgs e)
        {
            GetDataGridQlyKH(txbTimKiemKH.Text);
        }

        private void GetDataGridQlyKH(string timkiem)
        {
            grdQuanLyKhachHang.DataSource = KhachHangDB.DanhSachKhachHang(timkiem);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                obj.diachi = txtDiaChi.Text;
                obj.sdt = txtSDT.Text;
                obj.tenkhachhang = txtTenKhachHang.Text;
                obj.trangthai = (radConHieuLuc.Checked) ? 0 : 1;

                if (KhachHangDB.CapNhatKhachHang(obj) > 0)
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thông tin khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetDataGridQlyKH(null);
        }

        private void gvQuanLyKhachHang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtDiaChi.Text = gvQuanLyKhachHang.GetRowCellValue(gvQuanLyKhachHang.FocusedRowHandle, gvQuanLyKhachHang.Columns["DiaChi"]).ToString();
            txtNgayTao.Text = gvQuanLyKhachHang.GetRowCellValue(gvQuanLyKhachHang.FocusedRowHandle, gvQuanLyKhachHang.Columns["NgayLap"]).ToString();
            txtSDT.Text = gvQuanLyKhachHang.GetRowCellValue(gvQuanLyKhachHang.FocusedRowHandle, gvQuanLyKhachHang.Columns["SDT"]).ToString();
            txtTenKhachHang.Text = gvQuanLyKhachHang.GetRowCellValue(gvQuanLyKhachHang.FocusedRowHandle, gvQuanLyKhachHang.Columns["TenKhachHang"]).ToString();
            obj.idkhachhang = int.Parse(gvQuanLyKhachHang.GetRowCellValue(gvQuanLyKhachHang.FocusedRowHandle, gvQuanLyKhachHang.Columns["ID_KhachHang"]).ToString());
            obj.trangthai = bool.Parse(gvQuanLyKhachHang.GetRowCellValue(gvQuanLyKhachHang.FocusedRowHandle, gvQuanLyKhachHang.Columns["TrangThaiXoa"]).ToString()) ? 1 : 0;
            if (obj.trangthai == 1)
                radHetHieuLuc.Checked = true;
            else
                radConHieuLuc.Checked = true;
        }
    }
}