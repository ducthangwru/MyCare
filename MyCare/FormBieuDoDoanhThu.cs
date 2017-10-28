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
    public partial class FormBieuDoDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public FormBieuDoDoanhThu()
        {
            InitializeComponent();
        }

        private void FormBieuDoDoanhThu_Load(object sender, EventArgs e)
        {
            deTuNgay.DateTime = DateTime.Now;
            deDenNgay.DateTime = DateTime.Now;

            VeBieuDoThongKeDoanhThu();
        }

        private void VeBieuDoThongKeDoanhThu()
        {
            DataTable dt = BieuDoDB.BieuDoThongKeDoanhThu(deTuNgay.DateTime.ToString("yyyy-MM-dd") + " 00:00:00.000", deDenNgay.DateTime.ToString("yyyy-MM-dd") + " 23:59:59:999");

            // Generate a data table and bind the chart to it.
            chartBieuDoDoanhThu.DataSource = dt;

            // Specify data members to bind the chart's series template.
            chartBieuDoDoanhThu.SeriesDataMember = "NgayTao";
            chartBieuDoDoanhThu.SeriesTemplate.ArgumentDataMember = "NgayTao";
            chartBieuDoDoanhThu.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void btnSearchBieuDoDoanhThu_Click(object sender, EventArgs e)
        {
            VeBieuDoThongKeDoanhThu();
        }
    }
}