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
    public partial class FormDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void txbMatKhauMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                DoiMatKhau();
        }

        private void txbXacNhanMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoiMatKhau();
        }

        private void txbMatKhauCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoiMatKhau();
        }

        private void txbMatKhauMoi_EditValueChanged(object sender, EventArgs e)
        {
            CheckOMatKhau();
        }

        private void txbXacNhanMK_EditValueChanged(object sender, EventArgs e)
        {
            CheckOMatKhau();
        }

        private bool  CheckOMatKhau()
        {
            if (string.IsNullOrEmpty(txbMatKhauMoi.Text))
            {
                peXacNhanMK.Visible = false;
                return false;
            }
            else if (string.Compare(txbMatKhauMoi.Text, txbXacNhanMK.Text) != 0)
            {
                peXacNhanMK.Visible = true;
                peXacNhanMK.Image = MyCare.Properties.Resources.cancel;
                return false;
            }
            else
            {
                peXacNhanMK.Visible = true;
                peXacNhanMK.Image = MyCare.Properties.Resources.accept;
                return true;
            }
        }

        private void DoiMatKhau()
        {
            try
            {
                if(string.IsNullOrEmpty(txbMatKhauCu.Text) || string.IsNullOrEmpty(txbMatKhauMoi.Text) || string.IsNullOrEmpty(txbXacNhanMK.Text))
                {
                    MessageBox.Show("Có trường đang trống! Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!CheckOMatKhau())
                {
                    MessageBox.Show("Mật khẩu không trùng khớp! Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if(TaiKhoanDB.DoiMatKhau(Config.IDNhanVien, Utils.md5(txbMatKhauCu.Text), Utils.md5(txbMatKhauMoi.Text)) == 1)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi mật khẩu! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
        }
    }
}