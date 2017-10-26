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
            ((System.ComponentModel.ISupportInitialize)(this.gridLSNhapXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLSNhapXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLSNhapXuatKho
            // 
            this.gridLSNhapXuatKho.Location = new System.Drawing.Point(12, 12);
            this.gridLSNhapXuatKho.MainView = this.gridViewLSNhapXuatKho;
            this.gridLSNhapXuatKho.Name = "gridLSNhapXuatKho";
            this.gridLSNhapXuatKho.Size = new System.Drawing.Size(789, 365);
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
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // FormLichSuNhapXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 389);
            this.Controls.Add(this.gridLSNhapXuatKho);
            this.Name = "FormLichSuNhapXuatKho";
            this.Text = "FormLichSuNhapXuatKho";
            this.Load += new System.EventHandler(this.FormLichSuNhapXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLSNhapXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLSNhapXuatKho)).EndInit();
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
    }
}