using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using MyCare.MyCareDataAccess.DataAcess;
using MyCare.MyCareDataAccess.Utils;

namespace MyCare
{
    public partial class FormMain : XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void bbQlyKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormNhapKho frm = new FormNhapKho();
            frm.ShowDialog();
            this.Show();
        }

            
        private void tabMain_Click(object sender, EventArgs e)
        {
            if(tabMain.SelectedTabPageIndex == 0)
            {
                grdLSHoaDon.DataSource = LichSuNhapXuatKhoDB.DanhSachHoatDongGanDay(Config.IDNhanVien);
            }
            else if(tabMain.SelectedTabPageIndex == 1)
            {
                gridKhoThuoc.DataSource = KhoThuocDB.DanhSachKhoThuoc(Config.IDNhanVien, null);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!Utils.CheckQuyenAdmin(Config.IDNhanVien))
            {
                iQuanly.Enabled = false;
                iThongKe.Enabled = false;
            }

            grdLSHoaDon.DataSource = LichSuNhapXuatKhoDB.DanhSachHoatDongGanDay(Config.IDNhanVien);
        }

        private void iBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormTransaction frmTransaction = new FormTransaction();
            frmTransaction.ShowDialog();
            this.Show();
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaiKhoanDB.LuuLichSuDangNhap(Config.IDNhanVien, Config.DANG_XUAT);
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TaiKhoanDB.LuuLichSuDangNhap(Config.IDNhanVien, Config.DANG_XUAT);
        }

        private void bblsKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormLichSuNhapXuatKho frm = new FormLichSuNhapXuatKho();
            frm.ShowDialog();
            this.Show();
        }

        private void bblsDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormLichSuDangNhap frm = new FormLichSuDangNhap();
            frm.ShowDialog();
            this.Show();
        }

        private void bblsThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Utils.CheckQuyenAdmin(Config.IDNhanVien))
            {
                this.Hide();
                FormLichSuThaoTacThuoc frm = new FormLichSuThaoTacThuoc();
                frm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bblsDanhMuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Utils.CheckQuyenAdmin(Config.IDNhanVien))
            {
                this.Hide();
                FormLichSuThaoTacDanhMuc frm = new FormLichSuThaoTacDanhMuc();
                frm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bbQlyDanhMuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormQuanLyDanhMuc frmQuanLYDanhMuc = new FormQuanLyDanhMuc();
            frmQuanLYDanhMuc.ShowDialog();
            this.Show();
        }

        private void bbQlyThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormQuanLyThuoc frm = new FormQuanLyThuoc();
            frm.ShowDialog();
            this.Show();
        }

        private void bbQlyNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Hide();
            FormQuanLyNhanVien frm = new FormQuanLyNhanVien();
            frm.ShowDialog();
            this.Show();
        }

        private void iKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormQuanLyKhachHang frm = new FormQuanLyKhachHang();
            frm.ShowDialog();
            this.Show();
        }

        private void iLichSu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Utils.CheckQuyenAdmin(Config.IDNhanVien))
            {
                bblsDanhMuc.Enabled = false;
                bblsThuoc.Enabled = false;
            }
        }

        private void iAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/ducthangwru");
            System.Diagnostics.Process.Start("https://www.facebook.com/Luffy.s2.BoaHancock");
            MessageBox.Show("Bạn đang được chuyển hướng sang 2 kỹ thuật viên phần mềm! Liên hệ để hỗ trợ kỹ thuật!", "Chuyển hướng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}