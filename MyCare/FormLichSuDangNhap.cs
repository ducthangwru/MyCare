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
            grdLSDangNhap.DataSource = TaiKhoanDB.LichSuDangNhap(Config.IDNhanVien, 0, 0);
        }
    }
}