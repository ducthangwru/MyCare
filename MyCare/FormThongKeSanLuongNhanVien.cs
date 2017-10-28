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
using DevExpress.XtraCharts;

namespace MyCare
{
    public partial class FormThongKeSanLuongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormThongKeSanLuongNhanVien()
        {
            InitializeComponent();
        }

        private void FormThongKeSanLuongNhanVien_Load(object sender, EventArgs e)
        {
            deTuNgay.DateTime = DateTime.Now;
            deDenNgay.DateTime = DateTime.Now;

            VeBieuDoThongKeSanLuongNhanVien();
        }

        private void VeBieuDoThongKeSanLuongNhanVien()
        {
            try
            {
                DataTable dt = BieuDoDB.BieuDoThongKeSanLuongNV(deTuNgay.DateTime.ToString("yyyy-MM-dd") + " 00:00:00.000", deDenNgay.DateTime.ToString("yyyy-MM-dd") + " 23:59:59:999");

                // Generate a data table and bind the chart to it.
                chartSanLuongNV.DataSource = dt;

                Series series1 = new Series("Tỷ lệ doanh thu của nhân viên", ViewType.Pie);
                series1.DataSource = dt;
                series1.ArgumentDataMember = "TenDangNhap";
                series1.ValueDataMembers.AddRange(new string[] { "Value" });

                // Format the the series labels.
                series1.Label.TextPattern = "{A}: {VP:p0}";

                // Adjust the position of series labels. 
                ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

                // Detect overlapping of series labels.
                ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

                // Access the view-type-specific options of the series.
                PieSeriesView myView = (PieSeriesView)series1.View;

                // Show a title for the series.
                myView.Titles.Add(new SeriesTitle());
                myView.Titles[0].Text = series1.Name;

                // Specify a data filter to explode points.
                myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
                    DataFilterCondition.GreaterThanOrEqual, 9));
                myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                    DataFilterCondition.NotEqual, "Others"));

                chartSanLuongNV.Series.Clear();
                chartSanLuongNV.Series.Add(series1);
            }
            catch{ }
          
        }

        private void btnSearchBieuDoSanLuong_Click(object sender, EventArgs e)
        {
            VeBieuDoThongKeSanLuongNhanVien();
        }
    }
}