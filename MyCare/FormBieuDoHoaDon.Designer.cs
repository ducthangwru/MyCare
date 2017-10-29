namespace MyCare
{
    partial class FormBieuDoHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartBieuDoHoaDon = new DevExpress.XtraCharts.ChartControl();
            this.deTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.deDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnSearchBieuDoHoaDon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartBieuDoHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDenNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBieuDoHoaDon
            // 
            this.chartBieuDoHoaDon.Location = new System.Drawing.Point(3, 90);
            this.chartBieuDoHoaDon.Name = "chartBieuDoHoaDon";
            this.chartBieuDoHoaDon.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartBieuDoHoaDon.Size = new System.Drawing.Size(695, 439);
            this.chartBieuDoHoaDon.TabIndex = 0;
            // 
            // deTuNgay
            // 
            this.deTuNgay.EditValue = null;
            this.deTuNgay.Location = new System.Drawing.Point(150, 34);
            this.deTuNgay.Name = "deTuNgay";
            this.deTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTuNgay.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deTuNgay.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTuNgay.Properties.CalendarTimeProperties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deTuNgay.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTuNgay.Size = new System.Drawing.Size(100, 20);
            this.deTuNgay.TabIndex = 1;
            // 
            // deDenNgay
            // 
            this.deDenNgay.EditValue = null;
            this.deDenNgay.Location = new System.Drawing.Point(350, 34);
            this.deDenNgay.Name = "deDenNgay";
            this.deDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDenNgay.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deDenNgay.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deDenNgay.Properties.CalendarTimeProperties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deDenNgay.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deDenNgay.Size = new System.Drawing.Size(100, 20);
            this.deDenNgay.TabIndex = 2;
            // 
            // btnSearchBieuDoHoaDon
            // 
            this.btnSearchBieuDoHoaDon.Location = new System.Drawing.Point(520, 31);
            this.btnSearchBieuDoHoaDon.Name = "btnSearchBieuDoHoaDon";
            this.btnSearchBieuDoHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBieuDoHoaDon.TabIndex = 3;
            this.btnSearchBieuDoHoaDon.Text = "Tìm kiếm";
            this.btnSearchBieuDoHoaDon.Click += new System.EventHandler(this.btnSearchBieuDoHoaDon_Click);
            // 
            // FormBieuDoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 532);
            this.Controls.Add(this.btnSearchBieuDoHoaDon);
            this.Controls.Add(this.deDenNgay);
            this.Controls.Add(this.deTuNgay);
            this.Controls.Add(this.chartBieuDoHoaDon);
            this.Name = "FormBieuDoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê theo số hóa đơn";
            this.Load += new System.EventHandler(this.FormBieuDoHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBieuDoHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDenNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartBieuDoHoaDon;
        private DevExpress.XtraEditors.DateEdit deTuNgay;
        private DevExpress.XtraEditors.DateEdit deDenNgay;
        private DevExpress.XtraEditors.SimpleButton btnSearchBieuDoHoaDon;
    }
}