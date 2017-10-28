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
    public partial class FormLichSuThaoTacThuoc : DevExpress.XtraEditors.XtraForm
    {
        public FormLichSuThaoTacThuoc()
        {
            InitializeComponent();
        }

        private void FormLichSuThaoTacThuoc_Load(object sender, EventArgs e)
        {
            luThaoTac.Properties.DataSource = ThaoTacDB.DanhSachChonThaoTac();
            luThaoTac.EditValue = 0;
            luThuoc.Properties.DataSource = KhoThuocDB.DanhSachChonThuoc(Config.IDNhanVien);
            luThuoc.EditValue = 0;

            GetDataLSThaoTacThuoc(0, 0);
        }

        private void GetDataLSThaoTacThuoc(int loctheothuoc, int loctheothaotac)
        {
            grdLSThaoTacThuoc.DataSource = KhoThuocDB.LichSuThaoTacThuoc(Config.IDNhanVien, loctheothuoc, loctheothaotac);
        }

        private void btnSearchLSThaoTacThuoc_Click(object sender, EventArgs e)
        {
            GetDataLSThaoTacThuoc(int.Parse(luThuoc.GetColumnValue("ID").ToString()), int.Parse(luThaoTac.GetColumnValue("ID").ToString()));
        }
    }
}