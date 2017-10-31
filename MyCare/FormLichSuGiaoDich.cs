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
using MyCare.MyCareDataAccess.Object;
using MyCare.MyCareDataAccess.DataAcess;

namespace MyCare
{
    public partial class FormLichSuGiaoDich : DevExpress.XtraEditors.XtraForm
    {
        public FormLichSuGiaoDich(KhachHangOBJ obj)
        {
            InitializeComponent();

            txbDiaChi.Text = obj.diachi;
            txbSDT.Text = obj.sdt;
            txbTenKH.Text = obj.tenkhachhang;

            gridLSGiaoDich.DataSource = HoaDonDB.XemHoaDonTheoKhachHang(obj.idkhachhang);
        }

        private void btnXem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idhoadon = int.Parse(gvLSGiaoDich.GetRowCellValue(gvLSGiaoDich.FocusedRowHandle, gvLSGiaoDich.Columns["ID_HoaDon"]).ToString());
            FormChiTietHoaDon frm = new FormChiTietHoaDon(idhoadon);
            frm.ShowDialog();
        }
    }
}