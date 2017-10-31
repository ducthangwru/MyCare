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
    public partial class FormLichSuNhapXuatKho : DevExpress.XtraEditors.XtraForm
    {
        public FormLichSuNhapXuatKho()
        {
            InitializeComponent();
        }

        private void FormLichSuNhapXuatKho_Load(object sender, EventArgs e)
        {
            GetDataLSKho(null);
        }

        private void btnSearchLSKho_Click(object sender, EventArgs e)
        {
            GetDataLSKho(txbTimKiemLSKho.Text);
        }

        private void btnRefeshLSKho_Click(object sender, EventArgs e)
        {
            GetDataLSKho(null);
        }

        private void GetDataLSKho(string timkiem)
        {
            gridLSNhapXuatKho.DataSource = LichSuNhapXuatKhoDB.DanhSachHoatDongGanDay(Config.IDNhanVien, timkiem);
        }

        private void txbTimKiemLSKho_EditValueChanged(object sender, EventArgs e)
        {
            GetDataLSKho(txbTimKiemLSKho.Text);
        }

        private void btnXemChiTiet_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int idhoadon = int.Parse(gridViewLSNhapXuatKho.GetRowCellValue(gridViewLSNhapXuatKho.FocusedRowHandle, gridViewLSNhapXuatKho.Columns["ID_HoaDon"]).ToString());
                FormChiTietHoaDon frm = new FormChiTietHoaDon(idhoadon);
                frm.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}