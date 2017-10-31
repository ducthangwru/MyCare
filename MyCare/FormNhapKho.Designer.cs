namespace MyCare
{
    partial class FormNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapKho));
            this.grdQlyKho = new DevExpress.XtraGrid.GridControl();
            this.gvQLKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txbDanhMuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txbDonVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDHoaDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.txbGiaBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbGiaNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemSoLuong = new DevExpress.XtraEditors.SimpleButton();
            this.txbSoLuongCon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchNhapKho = new DevExpress.XtraEditors.SimpleButton();
            this.txbTimKiemNhapKho = new DevExpress.XtraEditors.TextEdit();
            this.btnLRefreshNhapKho = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdQlyKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTimKiemNhapKho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdQlyKho
            // 
            this.grdQlyKho.Location = new System.Drawing.Point(16, 271);
            this.grdQlyKho.MainView = this.gvQLKho;
            this.grdQlyKho.Name = "grdQlyKho";
            this.grdQlyKho.Size = new System.Drawing.Size(657, 191);
            this.grdQlyKho.TabIndex = 0;
            this.grdQlyKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQLKho});
            // 
            // gvQLKho
            // 
            this.gvQLKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn9});
            this.gvQLKho.GridControl = this.grdQlyKho;
            this.gvQLKho.Name = "gvQLKho";
            this.gvQLKho.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvQLKho_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Danh mục";
            this.gridColumn1.FieldName = "TenDanhMuc";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Thuốc";
            this.gridColumn2.FieldName = "TenThuoc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số lượng còn";
            this.gridColumn3.FieldName = "SoLuongCon";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn vị";
            this.gridColumn4.FieldName = "TenDonVi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Giá nhập";
            this.gridColumn7.FieldName = "GiaNhap";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giá bán";
            this.gridColumn5.FieldName = "Gia";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tác dụng";
            this.gridColumn6.FieldName = "NoiDung";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ID";
            this.gridColumn8.FieldName = "ID";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "IDDonVi";
            this.gridColumn9.FieldName = "ID_DonVi";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh mục";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(456, 81);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.ReadOnly = true;
            this.txtTenThuoc.Size = new System.Drawing.Size(170, 21);
            this.txtTenThuoc.TabIndex = 3;
            this.txtTenThuoc.TabStop = false;
            // 
            // txbDanhMuc
            // 
            this.txbDanhMuc.Location = new System.Drawing.Point(108, 86);
            this.txbDanhMuc.Name = "txbDanhMuc";
            this.txbDanhMuc.ReadOnly = true;
            this.txbDanhMuc.Size = new System.Drawing.Size(170, 21);
            this.txbDanhMuc.TabIndex = 3;
            this.txbDanhMuc.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn vị";
            // 
            // txbSoLuongNhap
            // 
            this.txbSoLuongNhap.Location = new System.Drawing.Point(108, 123);
            this.txbSoLuongNhap.Name = "txbSoLuongNhap";
            this.txbSoLuongNhap.Size = new System.Drawing.Size(170, 21);
            this.txbSoLuongNhap.TabIndex = 1;
            // 
            // txbDonVi
            // 
            this.txbDonVi.Location = new System.Drawing.Point(456, 48);
            this.txbDonVi.Name = "txbDonVi";
            this.txbDonVi.ReadOnly = true;
            this.txbDonVi.Size = new System.Drawing.Size(170, 21);
            this.txbDonVi.TabIndex = 3;
            this.txbDonVi.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã hóa đơn";
            // 
            // txtIDHoaDon
            // 
            this.txtIDHoaDon.Location = new System.Drawing.Point(108, 53);
            this.txtIDHoaDon.Name = "txtIDHoaDon";
            this.txtIDHoaDon.ReadOnly = true;
            this.txtIDHoaDon.Size = new System.Drawing.Size(170, 21);
            this.txtIDHoaDon.TabIndex = 3;
            this.txtIDHoaDon.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ghi chú";
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(108, 157);
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(170, 21);
            this.txbGhiChu.TabIndex = 2;
            // 
            // txbGiaBan
            // 
            this.txbGiaBan.Location = new System.Drawing.Point(456, 123);
            this.txbGiaBan.Name = "txbGiaBan";
            this.txbGiaBan.ReadOnly = true;
            this.txbGiaBan.Size = new System.Drawing.Size(170, 21);
            this.txbGiaBan.TabIndex = 5;
            this.txbGiaBan.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giá bán";
            // 
            // txbGiaNhap
            // 
            this.txbGiaNhap.Location = new System.Drawing.Point(456, 157);
            this.txbGiaNhap.Name = "txbGiaNhap";
            this.txbGiaNhap.ReadOnly = true;
            this.txbGiaNhap.Size = new System.Drawing.Size(170, 21);
            this.txbGiaNhap.TabIndex = 7;
            this.txbGiaNhap.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giá nhập";
            // 
            // btnThemSoLuong
            // 
            this.btnThemSoLuong.Location = new System.Drawing.Point(131, 194);
            this.btnThemSoLuong.Name = "btnThemSoLuong";
            this.btnThemSoLuong.Size = new System.Drawing.Size(106, 23);
            this.btnThemSoLuong.TabIndex = 3;
            this.btnThemSoLuong.Text = "Thêm kho";
            this.btnThemSoLuong.Click += new System.EventHandler(this.btnThemSoLuong_Click);
            // 
            // txbSoLuongCon
            // 
            this.txbSoLuongCon.Location = new System.Drawing.Point(456, 194);
            this.txbSoLuongCon.Name = "txbSoLuongCon";
            this.txbSoLuongCon.ReadOnly = true;
            this.txbSoLuongCon.Size = new System.Drawing.Size(170, 21);
            this.txbSoLuongCon.TabIndex = 10;
            this.txbSoLuongCon.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Số lượng còn";
            // 
            // btnSearchNhapKho
            // 
            this.btnSearchNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchNhapKho.Image")));
            this.btnSearchNhapKho.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearchNhapKho.Location = new System.Drawing.Point(556, 243);
            this.btnSearchNhapKho.Name = "btnSearchNhapKho";
            this.btnSearchNhapKho.Size = new System.Drawing.Size(37, 23);
            this.btnSearchNhapKho.TabIndex = 13;
            this.btnSearchNhapKho.Click += new System.EventHandler(this.btnSearchNhapKho_Click);
            // 
            // txbTimKiemNhapKho
            // 
            this.txbTimKiemNhapKho.Location = new System.Drawing.Point(445, 245);
            this.txbTimKiemNhapKho.Name = "txbTimKiemNhapKho";
            this.txbTimKiemNhapKho.Size = new System.Drawing.Size(100, 20);
            this.txbTimKiemNhapKho.TabIndex = 12;
            this.txbTimKiemNhapKho.EditValueChanged += new System.EventHandler(this.txbTimKiemNhapKho_EditValueChanged);
            // 
            // btnLRefreshNhapKho
            // 
            this.btnLRefreshNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("btnLRefreshNhapKho.Image")));
            this.btnLRefreshNhapKho.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLRefreshNhapKho.Location = new System.Drawing.Point(631, 243);
            this.btnLRefreshNhapKho.Name = "btnLRefreshNhapKho";
            this.btnLRefreshNhapKho.Size = new System.Drawing.Size(42, 23);
            this.btnLRefreshNhapKho.TabIndex = 11;
            this.btnLRefreshNhapKho.Click += new System.EventHandler(this.btnLRefreshNhapKho_Click);
            // 
            // FormNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 474);
            this.Controls.Add(this.btnSearchNhapKho);
            this.Controls.Add(this.txbTimKiemNhapKho);
            this.Controls.Add(this.btnLRefreshNhapKho);
            this.Controls.Add(this.txbSoLuongCon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThemSoLuong);
            this.Controls.Add(this.txbGiaNhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbGiaBan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbDonVi);
            this.Controls.Add(this.txbSoLuongNhap);
            this.Controls.Add(this.txbDanhMuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbGhiChu);
            this.Controls.Add(this.txtIDHoaDon);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdQlyKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kho";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNhapKho_FormClosed);
            this.Load += new System.EventHandler(this.FormNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdQlyKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTimKiemNhapKho.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdQlyKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQLKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txbDanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSoLuongNhap;
        private System.Windows.Forms.TextBox txbDonVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.TextBox txbGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbGiaNhap;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnThemSoLuong;
        private System.Windows.Forms.TextBox txbSoLuongCon;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.SimpleButton btnSearchNhapKho;
        private DevExpress.XtraEditors.TextEdit txbTimKiemNhapKho;
        private DevExpress.XtraEditors.SimpleButton btnLRefreshNhapKho;
    }
}