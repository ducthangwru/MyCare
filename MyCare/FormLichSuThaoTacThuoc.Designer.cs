namespace MyCare
{
    partial class FormLichSuThaoTacThuoc
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
            this.grdLSThaoTacThuoc = new DevExpress.XtraGrid.GridControl();
            this.gvLSThaoTacThuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSThaoTacThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSThaoTacThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLSThaoTacThuoc
            // 
            this.grdLSThaoTacThuoc.Location = new System.Drawing.Point(13, 13);
            this.grdLSThaoTacThuoc.MainView = this.gvLSThaoTacThuoc;
            this.grdLSThaoTacThuoc.Name = "grdLSThaoTacThuoc";
            this.grdLSThaoTacThuoc.Size = new System.Drawing.Size(610, 383);
            this.grdLSThaoTacThuoc.TabIndex = 0;
            this.grdLSThaoTacThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLSThaoTacThuoc});
            // 
            // gvLSThaoTacThuoc
            // 
            this.gvLSThaoTacThuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvLSThaoTacThuoc.GridControl = this.grdLSThaoTacThuoc;
            this.gvLSThaoTacThuoc.Name = "gvLSThaoTacThuoc";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thời gian";
            this.gridColumn1.FieldName = "NgayThaoTac";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.FieldName = "TenTaiKhoan";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên thuốc";
            this.gridColumn3.FieldName = "TenThuoc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thao tác";
            this.gridColumn4.FieldName = "TenThaoTac";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ghi chú";
            this.gridColumn5.FieldName = "GhiChu";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // FormLichSuThaoTacThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 408);
            this.Controls.Add(this.grdLSThaoTacThuoc);
            this.Name = "FormLichSuThaoTacThuoc";
            this.Text = "FormLichSuThaoTacThuoc";
            this.Load += new System.EventHandler(this.FormLichSuThaoTacThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLSThaoTacThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSThaoTacThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLSThaoTacThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLSThaoTacThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}