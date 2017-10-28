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
    public partial class FormLichSuDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormLichSuDangNhap()
        {
            InitializeComponent();
        }

        private void FormLichSuDangNhap_Load(object sender, EventArgs e)
        {
            luNhanVien.Properties.DataSource = TaiKhoanDB.DanhSachChonNhanVien();
            luTrangThai.Properties.DataSource = TaiKhoanDB.DanhSachChonTrangThaiNhanVien();
            luNhanVien.EditValue = 0;
            luTrangThai.EditValue = "0";
            GetDataGridLSDangNhap(0, 0);
        }

        private void btnSearchLSDangNhap_Click(object sender, EventArgs e)
        {
            GetDataGridLSDangNhap(int.Parse(luNhanVien.GetColumnValue("ID").ToString()), int.Parse(luTrangThai.GetColumnValue("ID").ToString()));
        }

        private void btnRefeshLSDangNhap_Click(object sender, EventArgs e)
        {
            GetDataGridLSDangNhap(0, 0);
        }

        private void GetDataGridLSDangNhap(int loctheonhanvien, int loctheotrangthai)
        {
            grdLSDangNhap.DataSource = TaiKhoanDB.LichSuDangNhap(Config.IDNhanVien, loctheonhanvien, loctheotrangthai);
        }
    }
}