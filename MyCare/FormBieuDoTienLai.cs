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
    public partial class FormBieuDoTienLai : DevExpress.XtraEditors.XtraForm
    {
        public FormBieuDoTienLai()
        {
            InitializeComponent();
        }

        private void btnSearchBieuDoDoanhThu_Click(object sender, EventArgs e)
        {
            VeBieuDoTienLai();
        }

        private void VeBieuDoTienLai()
        {
            DataTable dt = BieuDoDB.BieuDoThongKeTienLai(deTuNgay.DateTime.ToString("yyyy-MM-dd") + " 00:00:00.000", deDenNgay.DateTime.ToString("yyyy-MM-dd") + " 23:59:59:999");

            // Generate a data table and bind the chart to it.
            chartTienLai.DataSource = dt;

            // Specify data members to bind the chart's series template.
            chartTienLai.SeriesDataMember = "NgayTao";
            chartTienLai.SeriesTemplate.ArgumentDataMember = "NgayTao";
            chartTienLai.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void FormBieuDoTienLai_Load(object sender, EventArgs e)
        {
            deTuNgay.DateTime = DateTime.Now;
            deDenNgay.DateTime = DateTime.Now;

            VeBieuDoTienLai();
        }
    }
}