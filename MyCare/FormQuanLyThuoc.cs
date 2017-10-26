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
    public partial class FormQuanLyThuoc : DevExpress.XtraEditors.XtraForm
    {
        public FormQuanLyThuoc()
        {
            InitializeComponent();
        }

        private void FormQuanLyThuoc_Load(object sender, EventArgs e)
        {
            GetDataGridQlyThuoc(null);
        }

        private void GetDataGridQlyThuoc(string timkiem)
        {
            grdQuanLyThuoc.DataSource = KhoThuocDB.DanhSachKhoThuoc(Config.IDNhanVien, timkiem);
        }

        private void btnLRefreshThuoc_Click(object sender, EventArgs e)
        {
            GetDataGridQlyThuoc(null);
        }

        private void txbTimKiemQlyThuoc_EditValueChanged(object sender, EventArgs e)
        {
            GetDataGridQlyThuoc(txbTimKiemQlyThuoc.Text);
        }

        private void btnSearchThuoc_Click(object sender, EventArgs e)
        {
            GetDataGridQlyThuoc(txbTimKiemQlyThuoc.Text);
        }
    }
}