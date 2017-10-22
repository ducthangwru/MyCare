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
    public partial class FormTransaction : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtNew = new DataTable();
        public FormTransaction()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            dtNew.Columns.Add("TenDanhMuc");
            dtNew.Columns.Add("TenThuoc");
            dtNew.Columns.Add("SoLuong");
            dtNew.Columns.Add("TenDonVi");
            dtNew.Columns.Add("Gia");
            dtNew.Columns.Add("ThanhTien");

            gridTatCaMatHang.DataSource = KhoThuocDB.DanhSachKhoThuoc(Config.IDNhanVien);
        }

        private void gridViewTatCaMatHang_DoubleClick(object sender, EventArgs e)
        {
            string TenDanhMuc = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "TenDanhMuc").ToString();
            string TenThuoc = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "TenThuoc").ToString();
            string TenDonVi = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "TenDonVi").ToString();
            string Gia = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "Gia").ToString();

            //int RowSelect = gridViewTatCaMatHang.FocusedRowHandle;
            //dt.Rows.Add(gridViewTatCaMatHang.GetRow(RowSelect));

            dtNew.Rows.Add(TenDanhMuc, TenThuoc, "0", TenDonVi, Gia, "0");
            gridDSMatHang.DataSource = dtNew;
        }

        private void gridViewDSMatHang_ColumnChanged(object sender, EventArgs e)
        {
            try
            {
                int soLuong = int.Parse(gridViewDSMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "SoLuong").ToString());
                double gia = double.Parse(gridViewDSMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "Gia").ToString());
                double thanhTien = soLuong * gia;
                gridViewDSMatHang.SetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "ThanhTien", thanhTien);
            }
            catch(Exception ex)
            { }
        }

        //private void gridViewDSMatHang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    string a = gridViewDSMatHang.GetRowCellValue(gridViewDSMatHang.FocusedRowHandle, gridViewDSMatHang.Columns[""]).ToString();
        //}
    }
}