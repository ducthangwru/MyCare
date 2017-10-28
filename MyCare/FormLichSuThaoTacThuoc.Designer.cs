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
            this.luThuoc = new DevExpress.XtraEditors.LookUpEdit();
            this.luThaoTac = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbControl = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchLSThaoTacThuoc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSThaoTacThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSThaoTacThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luThaoTac.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLSThaoTacThuoc
            // 
            this.grdLSThaoTacThuoc.Location = new System.Drawing.Point(13, 61);
            this.grdLSThaoTacThuoc.MainView = this.gvLSThaoTacThuoc;
            this.grdLSThaoTacThuoc.Name = "grdLSThaoTacThuoc";
            this.grdLSThaoTacThuoc.Size = new System.Drawing.Size(610, 335);
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
            // luThuoc
            // 
            this.luThuoc.EditValue = "0";
            this.luThuoc.Location = new System.Drawing.Point(172, 23);
            this.luThuoc.Name = "luThuoc";
            this.luThuoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luThuoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Mã thuốc"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenThuoc", "Tên thuốc")});
            this.luThuoc.Properties.DisplayMember = "TenThuoc";
            this.luThuoc.Properties.NullText = "Tất cả";
            this.luThuoc.Properties.NullValuePrompt = "0";
            this.luThuoc.Properties.ValueMember = "ID";
            this.luThuoc.Size = new System.Drawing.Size(100, 20);
            this.luThuoc.TabIndex = 12;
            // 
            // luThaoTac
            // 
            this.luThaoTac.Location = new System.Drawing.Point(388, 23);
            this.luThaoTac.Name = "luThaoTac";
            this.luThaoTac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luThaoTac.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Mã thao tác"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenThaoTac", "Tên thao tác")});
            this.luThaoTac.Properties.DisplayMember = "TenThaoTac";
            this.luThaoTac.Properties.NullText = "Tất cả";
            this.luThaoTac.Properties.NullValuePrompt = "0";
            this.luThaoTac.Properties.ValueMember = "ID";
            this.luThaoTac.Size = new System.Drawing.Size(100, 20);
            this.luThaoTac.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(314, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Chọn thao tác";
            // 
            // lbControl
            // 
            this.lbControl.Location = new System.Drawing.Point(111, 26);
            this.lbControl.Name = "lbControl";
            this.lbControl.Size = new System.Drawing.Size(55, 13);
            this.lbControl.TabIndex = 9;
            this.lbControl.Text = "Chọn thuốc";
            // 
            // btnSearchLSThaoTacThuoc
            // 
            this.btnSearchLSThaoTacThuoc.Location = new System.Drawing.Point(516, 21);
            this.btnSearchLSThaoTacThuoc.Name = "btnSearchLSThaoTacThuoc";
            this.btnSearchLSThaoTacThuoc.Size = new System.Drawing.Size(75, 23);
            this.btnSearchLSThaoTacThuoc.TabIndex = 13;
            this.btnSearchLSThaoTacThuoc.Text = "Tìm kiếm";
            this.btnSearchLSThaoTacThuoc.Click += new System.EventHandler(this.btnSearchLSThaoTacThuoc_Click);
            // 
            // FormLichSuThaoTacThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 408);
            this.Controls.Add(this.btnSearchLSThaoTacThuoc);
            this.Controls.Add(this.luThuoc);
            this.Controls.Add(this.luThaoTac);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbControl);
            this.Controls.Add(this.grdLSThaoTacThuoc);
            this.Name = "FormLichSuThaoTacThuoc";
            this.Text = "FormLichSuThaoTacThuoc";
            this.Load += new System.EventHandler(this.FormLichSuThaoTacThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLSThaoTacThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSThaoTacThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luThaoTac.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLSThaoTacThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLSThaoTacThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LookUpEdit luThuoc;
        private DevExpress.XtraEditors.LookUpEdit luThaoTac;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbControl;
        private DevExpress.XtraEditors.SimpleButton btnSearchLSThaoTacThuoc;
    }
}