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
            this.btnRefeshLSDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchLSDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.luNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.luTrangThai = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luTrangThai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLSDangNhap
            // 
            this.grdLSDangNhap.Location = new System.Drawing.Point(12, 75);
            this.grdLSDangNhap.MainView = this.gvLSDangNhap;
            this.grdLSDangNhap.Name = "grdLSDangNhap";
            this.grdLSDangNhap.Size = new System.Drawing.Size(737, 329);
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
            this.gvLSDangNhap.OptionsBehavior.Editable = false;
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
            // btnRefeshLSDangNhap
            // 
            this.btnRefeshLSDangNhap.Image = global::MyCare.Properties.Resources.update;
            this.btnRefeshLSDangNhap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRefeshLSDangNhap.Location = new System.Drawing.Point(701, 46);
            this.btnRefeshLSDangNhap.Name = "btnRefeshLSDangNhap";
            this.btnRefeshLSDangNhap.Size = new System.Drawing.Size(48, 23);
            this.btnRefeshLSDangNhap.TabIndex = 16;
            this.btnRefeshLSDangNhap.Click += new System.EventHandler(this.btnRefeshLSDangNhap_Click);
            // 
            // btnSearchLSDangNhap
            // 
            this.btnSearchLSDangNhap.Image = global::MyCare.Properties.Resources.seach;
            this.btnSearchLSDangNhap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearchLSDangNhap.Location = new System.Drawing.Point(627, 46);
            this.btnSearchLSDangNhap.Name = "btnSearchLSDangNhap";
            this.btnSearchLSDangNhap.Size = new System.Drawing.Size(49, 23);
            this.btnSearchLSDangNhap.TabIndex = 18;
            this.btnSearchLSDangNhap.Click += new System.EventHandler(this.btnSearchLSDangNhap_Click);
            // 
            // luNhanVien
            // 
            this.luNhanVien.Location = new System.Drawing.Point(315, 49);
            this.luNhanVien.Name = "luNhanVien";
            this.luNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luNhanVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTaiKhoan", "Tên nhân viên")});
            this.luNhanVien.Properties.DisplayMember = "TenTaiKhoan";
            this.luNhanVien.Properties.NullText = "";
            this.luNhanVien.Properties.ValueMember = "ID";
            this.luNhanVien.Size = new System.Drawing.Size(100, 20);
            this.luNhanVien.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chọn nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Chọn trạng thái";
            // 
            // luTrangThai
            // 
            this.luTrangThai.Location = new System.Drawing.Point(512, 49);
            this.luTrangThai.Name = "luTrangThai";
            this.luTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luTrangThai.Properties.DisplayMember = "TenTrangThai";
            this.luTrangThai.Properties.NullText = "";
            this.luTrangThai.Properties.ValueMember = "ID";
            this.luTrangThai.Size = new System.Drawing.Size(100, 20);
            this.luTrangThai.TabIndex = 23;
            // 
            // FormLichSuDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 416);
            this.Controls.Add(this.luTrangThai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luNhanVien);
            this.Controls.Add(this.btnSearchLSDangNhap);
            this.Controls.Add(this.btnRefeshLSDangNhap);
            this.Controls.Add(this.grdLSDangNhap);
            this.Name = "FormLichSuDangNhap";
            this.Text = "FormLichSuDangNhap";
            this.Load += new System.EventHandler(this.FormLichSuDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLSDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luTrangThai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLSDangNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLSDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnRefeshLSDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnSearchLSDangNhap;
        private DevExpress.XtraEditors.LookUpEdit luNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit luTrangThai;
    }
}