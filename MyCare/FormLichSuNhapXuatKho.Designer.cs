namespace MyCare
{
    partial class FormLichSuNhapXuatKho
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLichSuNhapXuatKho));
            this.gridLSNhapXuatKho = new DevExpress.XtraGrid.GridControl();
            this.gridViewLSNhapXuatKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXemChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSearchLSKho = new DevExpress.XtraEditors.SimpleButton();
            this.txbTimKiemLSKho = new DevExpress.XtraEditors.TextEdit();
            this.btnRefeshLSKho = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLSNhapXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLSNhapXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXemChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTimKiemLSKho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLSNhapXuatKho
            // 
            this.gridLSNhapXuatKho.Location = new System.Drawing.Point(12, 62);
            this.gridLSNhapXuatKho.MainView = this.gridViewLSNhapXuatKho;
            this.gridLSNhapXuatKho.Name = "gridLSNhapXuatKho";
            this.gridLSNhapXuatKho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXemChiTiet});
            this.gridLSNhapXuatKho.Size = new System.Drawing.Size(789, 315);
            this.gridLSNhapXuatKho.TabIndex = 0;
            this.gridLSNhapXuatKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLSNhapXuatKho});
            // 
            // gridViewLSNhapXuatKho
            // 
            this.gridViewLSNhapXuatKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.gcThoiGian,
            this.gcTenNV,
            this.gcThuoc,
            this.gcSoLuong,
            this.gcGhiChu,
            this.gcThanhTien,
            this.gridColumn1});
            this.gridViewLSNhapXuatKho.GridControl = this.gridLSNhapXuatKho;
            this.gridViewLSNhapXuatKho.Name = "gridViewLSNhapXuatKho";
            // 
            // ID
            // 
            this.ID.Caption = "Mã hóa đơn";
            this.ID.FieldName = "ID_HoaDon";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // gcThoiGian
            // 
            this.gcThoiGian.Caption = "Ngày lập";
            this.gcThoiGian.FieldName = "NgayLap";
            this.gcThoiGian.Name = "gcThoiGian";
            this.gcThoiGian.Visible = true;
            this.gcThoiGian.VisibleIndex = 1;
            // 
            // gcTenNV
            // 
            this.gcTenNV.Caption = "Tên nhân viên";
            this.gcTenNV.FieldName = "TenTaiKhoan";
            this.gcTenNV.Name = "gcTenNV";
            this.gcTenNV.Visible = true;
            this.gcTenNV.VisibleIndex = 2;
            // 
            // gcThuoc
            // 
            this.gcThuoc.Caption = "Tên khách hàng";
            this.gcThuoc.FieldName = "TenKhachHang";
            this.gcThuoc.Name = "gcThuoc";
            this.gcThuoc.Visible = true;
            this.gcThuoc.VisibleIndex = 3;
            // 
            // gcSoLuong
            // 
            this.gcSoLuong.Caption = "Thao tác";
            this.gcSoLuong.FieldName = "TenThaoTac";
            this.gcSoLuong.Name = "gcSoLuong";
            this.gcSoLuong.Visible = true;
            this.gcSoLuong.VisibleIndex = 4;
            // 
            // gcGhiChu
            // 
            this.gcGhiChu.Caption = "Ghi chú";
            this.gcGhiChu.FieldName = "GhiChu";
            this.gcGhiChu.Name = "gcGhiChu";
            this.gcGhiChu.Visible = true;
            this.gcGhiChu.VisibleIndex = 5;
            // 
            // gcThanhTien
            // 
            this.gcThanhTien.Caption = "Thành tiền";
            this.gcThanhTien.FieldName = "ThanhTien";
            this.gcThanhTien.Name = "gcThanhTien";
            this.gcThanhTien.Visible = true;
            this.gcThanhTien.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Xem chi tiết";
            this.gridColumn1.ColumnEdit = this.btnXemChiTiet;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.AutoHeight = false;
            this.btnXemChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::MyCare.Properties.Resources.join, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXemChiTiet.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXemChiTiet_ButtonClick);
            // 
            // btnSearchLSKho
            // 
            this.btnSearchLSKho.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchLSKho.Image")));
            this.btnSearchLSKho.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearchLSKho.Location = new System.Drawing.Point(685, 33);
            this.btnSearchLSKho.Name = "btnSearchLSKho";
            this.btnSearchLSKho.Size = new System.Drawing.Size(29, 23);
            this.btnSearchLSKho.TabIndex = 18;
            this.btnSearchLSKho.Click += new System.EventHandler(this.btnSearchLSKho_Click);
            // 
            // txbTimKiemLSKho
            // 
            this.txbTimKiemLSKho.Location = new System.Drawing.Point(574, 35);
            this.txbTimKiemLSKho.Name = "txbTimKiemLSKho";
            this.txbTimKiemLSKho.Size = new System.Drawing.Size(100, 20);
            this.txbTimKiemLSKho.TabIndex = 17;
            this.txbTimKiemLSKho.EditValueChanged += new System.EventHandler(this.txbTimKiemLSKho_EditValueChanged);
            // 
            // btnRefeshLSKho
            // 
            this.btnRefeshLSKho.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeshLSKho.Image")));
            this.btnRefeshLSKho.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRefeshLSKho.Location = new System.Drawing.Point(762, 33);
            this.btnRefeshLSKho.Name = "btnRefeshLSKho";
            this.btnRefeshLSKho.Size = new System.Drawing.Size(40, 23);
            this.btnRefeshLSKho.TabIndex = 16;
            this.btnRefeshLSKho.Click += new System.EventHandler(this.btnRefeshLSKho_Click);
            // 
            // FormLichSuNhapXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 389);
            this.Controls.Add(this.btnSearchLSKho);
            this.Controls.Add(this.txbTimKiemLSKho);
            this.Controls.Add(this.btnRefeshLSKho);
            this.Controls.Add(this.gridLSNhapXuatKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLichSuNhapXuatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử xuất nhập kho";
            this.Load += new System.EventHandler(this.FormLichSuNhapXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLSNhapXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLSNhapXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXemChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTimKiemLSKho.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridLSNhapXuatKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLSNhapXuatKho;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn gcThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn gcThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gcSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gcGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn gcThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnSearchLSKho;
        private DevExpress.XtraEditors.TextEdit txbTimKiemLSKho;
        private DevExpress.XtraEditors.SimpleButton btnRefeshLSKho;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXemChiTiet;
    }
}