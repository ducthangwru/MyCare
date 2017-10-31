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
    public partial class FormChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public FormChiTietHoaDon(int idhoadon)
        {
            InitializeComponent();
            XemHoaDon(idhoadon);
        }

        private void XemHoaDon(int idhoadon)
        {
            try
            {
                DataTable XemHoaDon = HoaDonDB.XemHoaDon(idhoadon);
                foreach (DataRow dr in XemHoaDon.Rows)
                {
                    txbMaHoaDon.Text = dr["ID_HoaDon"].ToString();
                    txbGhiChu.Text = dr["GhiChu"].ToString();
                    txbNgayTao.Text = DateTime.Parse(dr["NgayTao"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                    txbTenKH.Text = (!string.IsNullOrEmpty(dr["TenKhachHang"].ToString())) ? dr["TenKhachHang"].ToString() : "Không có dữ liệu khách hàng";
                    txbTenNV.Text = dr["TenTaiKhoan"].ToString();
                    txbTongTien.Text = Utils.DinhDangTienTe(dr["TongTien"].ToString()) + " VNĐ";
                }

                gridChiTietHoaDon.DataSource = HoaDonDB.XemChiTietHoaDon(idhoadon);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}