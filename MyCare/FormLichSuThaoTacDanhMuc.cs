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
    public partial class FormLichSuThaoTacDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public FormLichSuThaoTacDanhMuc()
        {
            InitializeComponent();
        }

        private void FormLichSuThaoTacDanhMuc_Load(object sender, EventArgs e)
        {
            luDM.Properties.DataSource = KhoThuocDB.DanhSachChonThuoc(Config.IDNhanVien);
            luThaoTac.Properties.DataSource = ThaoTacDB.DanhSachChonThaoTac();

            grdLSThaoTacDM.DataSource = KhoThuocDB.LichSuThaoTacDanhMuc(Config.IDNhanVien, 0, 0);
        }
    }
}