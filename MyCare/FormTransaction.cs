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
        public double tongtien = 0;
        public FormTransaction()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            dtNew.Columns.Add("ID");
            dtNew.Columns.Add("ID_DonVi");
            dtNew.Columns.Add("TenDanhMuc");
            dtNew.Columns.Add("TenThuoc");
            dtNew.Columns.Add("SoLuong");
            dtNew.Columns.Add("TenDonVi");
            dtNew.Columns.Add("Gia");
            dtNew.Columns.Add("ThanhTien");

            gridTatCaMatHang.DataSource = KhoThuocDB.DanhSachKhoThuoc(Config.IDNhanVien, null);
            //luKhachHang.Properties.DataSource = KhachHangDB.DanhSachChonKhachHang(null);

            //luKhachHang.EditValue = 0;
        }

        private void gridViewTatCaMatHang_DoubleClick(object sender, EventArgs e)
        {
            string ID = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "ID").ToString();
            string TenDanhMuc = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "TenDanhMuc").ToString();
            string TenThuoc = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "TenThuoc").ToString();
            string TenDonVi = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "TenDonVi").ToString();
            string Gia = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "Gia").ToString();
            string IDDonVi = gridViewTatCaMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "ID_DonVi").ToString();
            dtNew.Rows.Add(ID, IDDonVi, TenDanhMuc, TenThuoc, "0", TenDonVi, Gia, "0");
            gridDSMatHang.DataSource = dtNew;
        }

        private void TinhTongHoaDon()
        {
            for(int i = 0; i < gridViewDSMatHang.DataRowCount; i++)
            {
                tongtien += double.Parse(gridViewDSMatHang.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txbTongTien.Text = Utils.DinhDangTienTe("" + tongtien) + " VNĐ";
        }

       
        private void gridViewDSMatHang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if(e.Column.FieldName == "SoLuong")
                {
                    int soLuong = int.Parse(gridViewDSMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "SoLuong").ToString());
                    int idthuoc = int.Parse(gridViewDSMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "ID").ToString());

                    if(!KhoThuocDB.KiemTraSoLuongThuoc(idthuoc, soLuong))
                    {
                        MessageBox.Show("Số lượng thuốc vượt quá số lượng còn trong kho, vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gridViewDSMatHang.SetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "SoLuong", 0);
                    }

                    if (soLuong < 0)
                    {
                        gridViewDSMatHang.SetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "SoLuong", 0);
                    }

                    double gia = double.Parse(gridViewDSMatHang.GetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "Gia").ToString());
                    double thanhTien = soLuong * gia;

                    gridViewDSMatHang.SetRowCellValue(gridViewTatCaMatHang.FocusedRowHandle, "ThanhTien", thanhTien);
                    TinhTongHoaDon();
                }
                
            }
            catch (Exception ex)
            { }
        }

        //private void luKhachHang_EditValueChanged(object sender, EventArgs e)
        //{
        //    if(int.Parse(luKhachHang.GetColumnValue("ID_KhachHang").ToString()) == 0)
        //    {
        //        txbTenKhach.ReadOnly = false;
        //        txbSDT.ReadOnly = false;
        //        txbDiaChi.ReadOnly = false;
        //        txbTenKhach.Text = "";
        //        txbDiaChi.Text = "";
        //        txbSDT.Text = "";
        //    }
        //    else
        //    {
        //        txbTenKhach.ReadOnly = true;
        //        txbSDT.ReadOnly = true;
        //        txbDiaChi.ReadOnly = true;
        //        txbTenKhach.Text = luKhachHang.GetColumnValue("TenKhachHang").ToString();
        //        txbDiaChi.Text = luKhachHang.GetColumnValue("DiaChi").ToString();
        //        txbSDT.Text = luKhachHang.GetColumnValue("SDT").ToString();
        //    }
        //}

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int idkhachhang = 0;
                //if (int.Parse(luKhachHang.GetColumnValue("ID_KhachHang").ToString()) == 0)
                //{
                //    idkhachhang = KhachHangDB.ThemMoiKhachHang(txbTenKhach.Text, txbDiaChi.Text, txbSDT.Text);
                //}
                //else
                //{
                //    idkhachhang = int.Parse(luKhachHang.GetColumnValue("ID_KhachHang").ToString());

                //}

                int idhoadon = HoaDonDB.ThemHoaDon(Config.IDNhanVien, idkhachhang, tongtien, txbGhiChu.Text);
                for (int i = 0; i < gridViewDSMatHang.DataRowCount; i++)
                {
                    HoaDonDB.ThemChiTietHoaDonXuatKho(
                        int.Parse(gridViewDSMatHang.GetRowCellValue(i, "ID").ToString()),
                        idhoadon,
                        int.Parse(gridViewDSMatHang.GetRowCellValue(i, "SoLuong").ToString()),
                        double.Parse(gridViewDSMatHang.GetRowCellValue(i, "Gia").ToString()),
                        int.Parse(gridViewDSMatHang.GetRowCellValue(i, "ID_DonVi").ToString()),
                        txbGhiChu.Text);
                }


                MessageBox.Show("Bán hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bán hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}