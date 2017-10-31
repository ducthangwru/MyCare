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
            this.lbControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchLSThaoTacThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.luThaoTac = new DevExpress.XtraEditors.LookUpEdit();
            this.luDM = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSThaoTacDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSThaoTacDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luThaoTac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luDM.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLSThaoTacDM
            // 
            this.grdLSThaoTacDM.Location = new System.Drawing.Point(12, 64);
            this.grdLSThaoTacDM.MainView = this.gvLSThaoTacDM;
            this.grdLSThaoTacDM.Name = "grdLSThaoTacDM";
            this.grdLSThaoTacDM.Size = new System.Drawing.Size(752, 367);
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
            // lbControl
            // 
            this.lbControl.Location = new System.Drawing.Point(63, 29);
            this.lbControl.Name = "lbControl";
            this.lbControl.Size = new System.Drawing.Size(55, 13);
            this.lbControl.TabIndex = 3;
            this.lbControl.Text = "Chọn thuốc";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(312, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Chọn thao tác";
            // 
            // btnSearchLSThaoTacThuoc
            // 
            this.btnSearchLSThaoTacThuoc.Location = new System.Drawing.Point(577, 24);
            this.btnSearchLSThaoTacThuoc.Name = "btnSearchLSThaoTacThuoc";
            this.btnSearchLSThaoTacThuoc.Size = new System.Drawing.Size(75, 23);
            this.btnSearchLSThaoTacThuoc.TabIndex = 5;
            this.btnSearchLSThaoTacThuoc.Text = "Tìm kiếm";
            // 
            // luThaoTac
            // 
            this.luThaoTac.Location = new System.Drawing.Point(400, 26);
            this.luThaoTac.Name = "luThaoTac";
            this.luThaoTac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luThaoTac.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Mã thao tác"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenThaoTac", "Tên thao tác")});
            this.luThaoTac.Properties.DisplayMember = "ID";
            this.luThaoTac.Properties.NullText = "Tất cả";
            this.luThaoTac.Properties.NullValuePrompt = "0";
            this.luThaoTac.Properties.ValueMember = "TenThaoTac";
            this.luThaoTac.Size = new System.Drawing.Size(100, 20);
            this.luThaoTac.TabIndex = 7;
            // 
            // luDM
            // 
            this.luDM.EditValue = "0";
            this.luDM.Location = new System.Drawing.Point(137, 26);
            this.luDM.Name = "luDM";
            this.luDM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luDM.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Mã thuốc"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenThuoc", "Tên thuốc")});
            this.luDM.Properties.DisplayMember = "TenThuoc";
            this.luDM.Properties.NullText = "Tất cả";
            this.luDM.Properties.NullValuePrompt = "0";
            this.luDM.Properties.ValueMember = "ID";
            this.luDM.Size = new System.Drawing.Size(100, 20);
            this.luDM.TabIndex = 8;
            // 
            // FormLichSuThaoTacDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 443);
            this.Controls.Add(this.luDM);
            this.Controls.Add(this.luThaoTac);
            this.Controls.Add(this.btnSearchLSThaoTacThuoc);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbControl);
            this.Controls.Add(this.grdLSThaoTacDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLichSuThaoTacDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử thao tác danh mục";
            this.Load += new System.EventHandler(this.FormLichSuThaoTacDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLSThaoTacDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSThaoTacDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luThaoTac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luDM.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLSThaoTacDM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLSThaoTacDM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl lbControl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearchLSThaoTacThuoc;
        private DevExpress.XtraEditors.LookUpEdit luThaoTac;
        private DevExpress.XtraEditors.LookUpEdit luDM;
    }
}