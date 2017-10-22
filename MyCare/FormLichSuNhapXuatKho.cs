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
    public partial class FormLichSuNhapXuatKho : DevExpress.XtraEditors.XtraForm
    {
        public FormLichSuNhapXuatKho()
        {
            InitializeComponent();
        }

        private void FormLichSuNhapXuatKho_Load(object sender, EventArgs e)
        {
            gridLSNhapXuatKho.DataSource = LichSuNhapXuatKhoDB.DanhSachHoatDongGanDay(Config.IDNhanVien);
        }
    }
}