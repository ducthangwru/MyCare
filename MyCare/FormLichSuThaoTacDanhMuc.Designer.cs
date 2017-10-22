namespace MyCare
{
    partial class FormLichSuThaoTacDanhMuc
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
            this.grdLSThaoTacDM = new DevExpress.XtraGrid.GridControl();
            this.gvLSThaoTacDM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSThaoTacDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSThaoTacDM)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLSThaoTacDM
            // 
            this.grdLSThaoTacDM.Location = new System.Drawing.Point(12, 13);
            this.grdLSThaoTacDM.MainView = this.gvLSThaoTacDM;
            this.grdLSThaoTacDM.Name = "grdLSThaoTacDM";
            this.grdLSThaoTacDM.Size = new System.Drawing.Size(752, 418);
            this.grdLSThaoTacDM.TabIndex = 0;
            this.grdLSThaoTacDM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLSThaoTacDM});
            // 
            // gvLSThaoTacDM
            // 
            this.gvLSThaoTacDM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvLSThaoTacDM.GridControl = this.grdLSThaoTacDM;
            this.gvLSThaoTacDM.Name = "gvLSThaoTacDM";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thời gian";
            this.gridColumn1.FieldName = "NgayThaoTac";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.FieldName = "TenTaiKhoan";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên danh mục";
            this.gridColumn3.FieldName = "TenDanhMuc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thao tác";
            this.gridColumn4.FieldName = "TenThaoTac";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ghi chú";
            this.gridColumn5.FieldName = "GhiChu";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // FormLichSuThaoTacDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 443);
            this.Controls.Add(this.grdLSThaoTacDM);
            this.Name = "FormLichSuThaoTacDanhMuc";
            this.Text = "FormLichSuThaoTacDanhMuc";
            this.Load += new System.EventHandler(this.FormLichSuThaoTacDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLSThaoTacDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSThaoTacDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLSThaoTacDM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLSThaoTacDM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}