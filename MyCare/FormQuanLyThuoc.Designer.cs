namespace MyCare
{
    partial class FormQuanLyThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyThuoc));
            this.radHetHieuLuc = new System.Windows.Forms.RadioButton();
            this.radConHieuLuc = new System.Windows.Forms.RadioButton();
            this.luDanhMuc = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaXuat = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaNhap = new DevExpress.XtraEditors.TextEdit();
            this.txtTenThuoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.luDonVi = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNgayTao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.grdQuanLyThuoc = new DevExpress.XtraGrid.GridControl();
            this.gvQuanLyThuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.txbTimKiemQlyThuoc = new DevExpress.XtraEditors.TextEdit();
            this.btnLRefreshThuoc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.luDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuanLyThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTimKiemQlyThuoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // radHetHieuLuc
            // 
            this.radHetHieuLuc.AutoSize = true;
            this.radHetHieuLuc.Location = new System.Drawing.Point(594, 88);
            this.radHetHieuLuc.Name = "radHetHieuLuc";
            this.radHetHieuLuc.Size = new System.Drawing.Size(82, 17);
            this.radHetHieuLuc.TabIndex = 8;
            this.radHetHieuLuc.TabStop = true;
            this.radHetHieuLuc.Text = "Hết hiệu lực";
            this.radHetHieuLuc.UseVisualStyleBackColor = true;
            // 
            // radConHieuLuc
            // 
            this.radConHieuLuc.AutoSize = true;
            this.radConHieuLuc.Location = new System.Drawing.Point(474, 88);
            this.radConHieuLuc.Name = "radConHieuLuc";
            this.radConHieuLuc.Size = new System.Drawing.Size(84, 17);
            this.radConHieuLuc.TabIndex = 7;
            this.radConHieuLuc.TabStop = true;
            this.radConHieuLuc.Text = "Còn hiệu lực";
            this.radConHieuLuc.UseVisualStyleBackColor = true;
            // 
            // luDanhMuc
            // 
            this.luDanhMuc.Location = new System.Drawing.Point(113, 21);
            this.luDanhMuc.Name = "luDanhMuc";
            this.luDanhMuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luDanhMuc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDanhMuc", "Tên danh mục")});
            this.luDanhMuc.Properties.DisplayMember = "TenDanhMuc";
            this.luDanhMuc.Properties.NullText = "";
            this.luDanhMuc.Properties.ValueMember = "ID";
            this.luDanhMuc.Size = new System.Drawing.Size(202, 20);
            this.luDanhMuc.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Nội dung";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Giá xuất";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(395, 150);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(35, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Ghi chú";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(395, 89);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Trạng thái";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Giá nhập";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Danh mục";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Tên thuốc";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(473, 145);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(202, 20);
            this.txtGhiChu.TabIndex = 10;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(113, 147);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(202, 20);
            this.txtNoiDung.TabIndex = 5;
            // 
            // txtGiaXuat
            // 
            this.txtGiaXuat.Location = new System.Drawing.Point(113, 118);
            this.txtGiaXuat.Name = "txtGiaXuat";
            this.txtGiaXuat.Size = new System.Drawing.Size(202, 20);
            this.txtGiaXuat.TabIndex = 4;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(113, 86);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(202, 20);
            this.txtGiaNhap.TabIndex = 3;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(113, 55);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(202, 20);
            this.txtTenThuoc.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(399, 58);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Đơn vị";
            // 
            // luDonVi
            // 
            this.luDonVi.Location = new System.Drawing.Point(473, 55);
            this.luDonVi.Name = "luDonVi";
            this.luDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luDonVi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonVi", "Tên đơn vị")});
            this.luDonVi.Properties.DisplayMember = "TenDonVi";
            this.luDonVi.Properties.NullText = "";
            this.luDonVi.Properties.ValueMember = "ID";
            this.luDonVi.Size = new System.Drawing.Size(202, 20);
            this.luDonVi.TabIndex = 6;
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(473, 116);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Properties.ReadOnly = true;
            this.txtNgayTao.Size = new System.Drawing.Size(202, 20);
            this.txtNgayTao.TabIndex = 9;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(393, 121);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Ngày tạo";
            // 
            // grdQuanLyThuoc
            // 
            this.grdQuanLyThuoc.Location = new System.Drawing.Point(22, 224);
            this.grdQuanLyThuoc.MainView = this.gvQuanLyThuoc;
            this.grdQuanLyThuoc.Name = "grdQuanLyThuoc";
            this.grdQuanLyThuoc.Size = new System.Drawing.Size(664, 221);
            this.grdQuanLyThuoc.TabIndex = 23;
            this.grdQuanLyThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuanLyThuoc});
            // 
            // gvQuanLyThuoc
            // 
            this.gvQuanLyThuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gvQuanLyThuoc.GridControl = this.grdQuanLyThuoc;
            this.gvQuanLyThuoc.Name = "gvQuanLyThuoc";
            this.gvQuanLyThuoc.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvQuanLyThuoc_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IDThuoc";
            this.gridColumn1.FieldName = "IDThuoc";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên thuốc";
            this.gridColumn2.FieldName = "TenThuoc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 113;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên danh mục";
            this.gridColumn3.FieldName = "TenDanhMuc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 108;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn vị";
            this.gridColumn4.FieldName = "TenDonVi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 78;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nội dung";
            this.gridColumn5.FieldName = "NoiDung";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 78;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Trạng thái";
            this.gridColumn6.FieldName = "TrangThai";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 85;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày tạo";
            this.gridColumn7.FieldName = "NgayLap";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 78;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Giá nhập";
            this.gridColumn8.FieldName = "GiaNhap";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 78;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Giá xuất";
            this.gridColumn9.FieldName = "Gia";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 78;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "ID_DanhMuc";
            this.gridColumn10.FieldName = "ID_DanhMuc";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "ID_DonVi";
            this.gridColumn11.FieldName = "ID_DonVi";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Trạng thái xóa";
            this.gridColumn12.FieldName = "TrangThaiXoa";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(138, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSearchThuoc
            // 
            this.btnSearchThuoc.Image = global::MyCare.Properties.Resources.seach;
            this.btnSearchThuoc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearchThuoc.Location = new System.Drawing.Point(569, 196);
            this.btnSearchThuoc.Name = "btnSearchThuoc";
            this.btnSearchThuoc.Size = new System.Drawing.Size(49, 23);
            this.btnSearchThuoc.TabIndex = 26;
            this.btnSearchThuoc.Click += new System.EventHandler(this.btnSearchThuoc_Click);
            // 
            // txbTimKiemQlyThuoc
            // 
            this.txbTimKiemQlyThuoc.Location = new System.Drawing.Point(458, 198);
            this.txbTimKiemQlyThuoc.Name = "txbTimKiemQlyThuoc";
            this.txbTimKiemQlyThuoc.Size = new System.Drawing.Size(100, 20);
            this.txbTimKiemQlyThuoc.TabIndex = 25;
            this.txbTimKiemQlyThuoc.EditValueChanged += new System.EventHandler(this.txbTimKiemQlyThuoc_EditValueChanged);
            // 
            // btnLRefreshThuoc
            // 
            this.btnLRefreshThuoc.Image = global::MyCare.Properties.Resources.update;
            this.btnLRefreshThuoc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLRefreshThuoc.Location = new System.Drawing.Point(638, 196);
            this.btnLRefreshThuoc.Name = "btnLRefreshThuoc";
            this.btnLRefreshThuoc.Size = new System.Drawing.Size(48, 23);
            this.btnLRefreshThuoc.TabIndex = 24;
            this.btnLRefreshThuoc.Click += new System.EventHandler(this.btnLRefreshThuoc_Click);
            // 
            // FormQuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 457);
            this.Controls.Add(this.btnSearchThuoc);
            this.Controls.Add(this.txbTimKiemQlyThuoc);
            this.Controls.Add(this.btnLRefreshThuoc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grdQuanLyThuoc);
            this.Controls.Add(this.radHetHieuLuc);
            this.Controls.Add(this.radConHieuLuc);
            this.Controls.Add(this.luDonVi);
            this.Controls.Add(this.luDanhMuc);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtNgayTao);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtGiaXuat);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtTenThuoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormQuanLyThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thuốc";
            this.Load += new System.EventHandler(this.FormQuanLyThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuanLyThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTimKiemQlyThuoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radHetHieuLuc;
        private System.Windows.Forms.RadioButton radConHieuLuc;
        private DevExpress.XtraEditors.LookUpEdit luDanhMuc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DevExpress.XtraEditors.TextEdit txtGiaXuat;
        private DevExpress.XtraEditors.TextEdit txtGiaNhap;
        private DevExpress.XtraEditors.TextEdit txtTenThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit luDonVi;
        private DevExpress.XtraEditors.TextEdit txtNgayTao;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.GridControl grdQuanLyThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuanLyThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSearchThuoc;
        private DevExpress.XtraEditors.TextEdit txbTimKiemQlyThuoc;
        private DevExpress.XtraEditors.SimpleButton btnLRefreshThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}