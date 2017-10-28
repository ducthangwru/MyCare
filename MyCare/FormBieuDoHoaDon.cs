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

namespace MyCare
{
    public partial class FormBieuDoHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public FormBieuDoHoaDon()
        {
            InitializeComponent();
        }

        private void btnSearchBieuDoHoaDon_Click(object sender, EventArgs e)
        {
            VeBieuDoThongKeHoaDon();
        }

        private void FormBieuDoHoaDon_Load(object sender, EventArgs e)
        {
            deTuNgay.DateTime = DateTime.Now;
            deDenNgay.DateTime = DateTime.Now;

            VeBieuDoThongKeHoaDon();
        }

        private void VeBieuDoThongKeHoaDon()
        {
            DataTable dt = BieuDoDB.BieuDoThongKeHoaDon(deTuNgay.DateTime.ToString("yyyy-MM-dd") + " 00:00:00.000", deDenNgay.DateTime.ToString("yyyy-MM-dd") + " 23:59:59:999");

            // Generate a data table and bind the chart to it.
            chartBieuDoHoaDon.DataSource = dt;

            // Specify data members to bind the chart's series template.
            chartBieuDoHoaDon.SeriesDataMember = "TenThaoTac";
            chartBieuDoHoaDon.SeriesTemplate.ArgumentDataMember = "NgayTao";
            chartBieuDoHoaDon.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
        }
    }
}