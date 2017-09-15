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

        }

            
        private void tabMain_Click(object sender, EventArgs e)
        {
            if(tabMain.SelectedTabPageIndex == 0)
            {
                gridHoatDongGanDay.DataSource = LichSuNhapXuatKhoDB.DanhSachHoatDongGanDay(Config.IDNhanVien);
            }
            else if(tabMain.SelectedTabPageIndex == 1)
            {
                gridKhoThuoc.DataSource = KhoThuocDB.DanhSachKhoThuoc(Config.IDNhanVien);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            gridHoatDongGanDay.DataSource = LichSuNhapXuatKhoDB.DanhSachHoatDongGanDay(2);
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
            TaiKhoanDB.LuuLichSuDangNhap(Config.IDNhanVien, 2);
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TaiKhoanDB.LuuLichSuDangNhap(Config.IDNhanVien, 2);
        }
    }
}