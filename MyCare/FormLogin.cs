using DevExpress;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Win.Templates;
using System.Collections.Generic;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Win.Core;
using DevExpress.ExpressApp.Win.Layout;
using DevExpress.ExpressApp.Win.Templates.ActionContainers;
using DevExpress.XtraEditors;
using MyCare.MyCareDataAccess.DataAcess;
using System.Windows.Forms;
using MyCare.MyCareDataAccess.Utils;

namespace MyCare
{
    public partial class FormLogin : XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, System.EventArgs e)
        {
            DangNhap();
        }

        private void teUsername_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void DangNhap()
        {
            if (string.IsNullOrEmpty(teUsername.Text) || string.IsNullOrEmpty(tePassword.Text))
            {
                XtraMessageBox.Show("Tên tài khoản hoặc mật khẩu đang trống! Vui lòng kiểm tra lại!", "Đăng nhập");
            }
            else
            {
                if (TaiKhoanDB.DangNhap(teUsername.Text, tePassword.Text))
                {
                    TaiKhoanDB.LuuLichSuDangNhap(Config.IDNhanVien, 1);

                    FormMain frmMain = new FormMain();
                    this.Hide();
                    frmMain.ShowDialog();
                    this.Show();
                }
                else
                {
                    XtraMessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Đăng nhập thất bại");
                }
            }

        }

        private void tePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát khỏi chương trình?","Xác nhận thoát", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
