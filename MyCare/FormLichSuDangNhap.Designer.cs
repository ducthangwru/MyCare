namespace MyCare
{
    partial class FormLichSuDangNhap
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
            this.grdLSDangNhap = new DevExpress.XtraGrid.GridControl();
            this.gvLSDangNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLSDangNhap
            // 
            this.grdLSDangNhap.Location = new System.Drawing.Point(12, 12);
            this.grdLSDangNhap.MainView = this.gvLSDangNhap;
            this.grdLSDangNhap.Name = "grdLSDangNhap";
            this.grdLSDangNhap.Size = new System.Drawing.Size(737, 392);
            this.grdLSDangNhap.TabIndex = 0;
            this.grdLSDangNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLSDangNhap});
            // 
            // gvLSDangNhap
            // 
            this.gvLSDangNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvLSDangNhap.GridControl = this.grdLSDangNhap;
            this.gvLSDangNhap.Name = "gvLSDangNhap";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Nhân Viên";
            this.gridColumn1.FieldName = "TenTaiKhoan";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Trạng Thái";
            this.gridColumn2.FieldName = "TrangThai";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thời gian";
            this.gridColumn3.FieldName = "ThoiGian";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // FormLichSuDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 416);
            this.Controls.Add(this.grdLSDangNhap);
            this.Name = "FormLichSuDangNhap";
            this.Text = "FormLichSuDangNhap";
            this.Load += new System.EventHandler(this.FormLichSuDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLSDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSDangNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLSDangNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLSDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}