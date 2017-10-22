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
            grdLSThaoTacThuoc.DataSource = KhoThuocDB.LichSuThaoTacThuoc(Config.IDNhanVien, 0, 0);
        }
    }
}