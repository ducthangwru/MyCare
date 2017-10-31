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
    public partial class FormNhapKho : DevExpress.XtraEditors.XtraForm
    {
        public int idhoadon = 0;
        public FormNhapKho()
        {
            InitializeComponent();
        }

        private void FormNhapKho_Load(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn tạo 1 hóa đơn nhập kho mới?", "Nhập kho", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialog == DialogResult.OK)
            {
                RefreshDataGridQlyKho(null);
                txtIDHoaDon.Text = HoaDonDB.GetIDHoaDon(Config.IDNhanVien);
                idhoadon = int.Parse(txtIDHoaDon.Text);
            }
            else
            {
                this.Close();
            }
        }

        private void gvQLKho_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txbDanhMuc.Text = gvQLKho.GetRowCellValue(gvQLKho.FocusedRowHandle, gvQLKho.Columns["TenDanhMuc"]).ToString();
            txbDonVi.Text = gvQLKho.GetRowCellValue(gvQLKho.FocusedRowHandle, gvQLKho.Columns["TenDonVi"]).ToString();
            txbGiaBan.Text = gvQLKho.GetRowCellValue(gvQLKho.FocusedRowHandle, gvQLKho.Columns["Gia"]).ToString();
            txbGiaNhap.Text = gvQLKho.GetRowCellValue(gvQLKho.FocusedRowHandle, gvQLKho.Columns["GiaNhap"]).ToString();
            txbSoLuongCon.Text = gvQLKho.GetRowCellValue(gvQLKho.FocusedRowHandle, gvQLKho.Columns["SoLuongCon"]).ToString();
            txtTenThuoc.Text = gvQLKho.GetRowCellValue(gvQLKho.FocusedRowHandle, gvQLKho.Columns["TenThuoc"]).ToString();
        }

        private void btnThemSoLuong_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txbDanhMuc.Text))
                {
                    MessageBox.Show("Trường thông tin rỗng không thể thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                idhoadon = int.Parse(txtIDHoaDon.Text);
                int soluongthem = int.Parse(txbSoLuongNhap.Text);
                double giaban = double.Parse(gvQLKho.GetRowCellValue(gvQLKho.FocusedRowHandle, gvQLKho.Columns["Gia"]).ToString());
                int idthuoc = int.Parse(gvQLKho.GetRowCellValue(gvQLKho.FocusedRowHandle, gvQLKho.Columns["ID"]).ToString());
                int donvi = int.Parse(gvQLKho.GetRowCellValue(gvQLKho.FocusedRowHandle, gvQLKho.Columns["ID_DonVi"]).ToString());
                string ghichu = txbGhiChu.Text;
                if (soluongthem >= 0 && HoaDonDB.ThemChiTietHoaDonNhapKho(idthuoc, idhoadon, soluongthem, giaban, donvi, ghichu))
                {
                    MessageBox.Show("Thêm số lượng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grdQlyKho.DataSource = KhoThuocDB.DanhSachKhoThuoc(Config.IDNhanVien, null);

                    DialogResult dialog = MessageBox.Show("Bạn có muốn tạo 1 hóa đơn nhập kho mới?", "Nhập kho", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        RefreshDataGridQlyKho(null);
                        txtIDHoaDon.Text = HoaDonDB.GetIDHoaDon(Config.IDNhanVien);
                        txbSoLuongNhap.Text = "";
                        txbGhiChu.Text = "";
                        idhoadon = int.Parse(txtIDHoaDon.Text);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Thêm số lượng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm số lượng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormNhapKho_FormClosed(object sender, FormClosedEventArgs e)
        {
            HoaDonDB.KiemTraChiTietHoaDon(idhoadon);
        }

        private void btnLRefreshNhapKho_Click(object sender, EventArgs e)
        {
            RefreshDataGridQlyKho(null);
        }

        private void RefreshDataGridQlyKho(string timkiem)
        {
            grdQlyKho.DataSource = KhoThuocDB.DanhSachKhoThuoc(Config.IDNhanVien, timkiem);
        }

        private void btnSearchNhapKho_Click(object sender, EventArgs e)
        {
            RefreshDataGridQlyKho(txbTimKiemNhapKho.Text);
        }

        private void txbTimKiemNhapKho_EditValueChanged(object sender, EventArgs e)
        {
            RefreshDataGridQlyKho(txbTimKiemNhapKho.Text);
        }
    }
}