namespace MyCare
{
    partial class FormQuanLyDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDanhMuc));
            this.txtTenDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdQuanLyDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.gvQuanLyDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.radConHieuLuc = new System.Windows.Forms.RadioButton();
            this.radHetHieuLuc = new System.Windows.Forms.RadioButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txbTimKiemDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuanLyDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTimKiemDanhMuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(119, 30);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(202, 20);
            this.txtTenDanhMuc.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên danh mục";
            // 
            // grdQuanLyDanhMuc
            // 
            this.grdQuanLyDanhMuc.Location = new System.Drawing.Point(12, 182);
            this.grdQuanLyDanhMuc.MainView = this.gvQuanLyDanhMuc;
            this.grdQuanLyDanhMuc.Name = "grdQuanLyDanhMuc";
            this.grdQuanLyDanhMuc.Size = new System.Drawing.Size(661, 280);
            this.grdQuanLyDanhMuc.TabIndex = 2;
            this.grdQuanLyDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuanLyDanhMuc});
            // 
            // gvQuanLyDanhMuc
            // 
            this.gvQuanLyDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn6});
            this.gvQuanLyDanhMuc.GridControl = this.grdQuanLyDanhMuc;
            this.gvQuanLyDanhMuc.Name = "gvQuanLyDanhMuc";
            this.gvQuanLyDanhMuc.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvQuanLyDanhMuc_RowClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID Danh Mục";
            this.gridColumn2.FieldName = "ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 158;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Danh Mục";
            this.gridColumn3.FieldName = "TenDanhMuc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 158;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Trạng Thái";
            this.gridColumn4.FieldName = "TrangThai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 158;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngày Tạo";
            this.gridColumn1.FieldName = "NgayLap";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 162;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Trạng thái Xóa";
            this.gridColumn5.FieldName = "TrangThaiXoa";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ghi chú cuối";
            this.gridColumn6.FieldName = "GhiChu";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 192;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Trạng thái";
            // 
            // radConHieuLuc
            // 
            this.radConHieuLuc.AutoSize = true;
            this.radConHieuLuc.Location = new System.Drawing.Point(118, 79);
            this.radConHieuLuc.Name = "radConHieuLuc";
            this.radConHieuLuc.Size = new System.Drawing.Size(84, 17);
            this.radConHieuLuc.TabIndex = 3;
            this.radConHieuLuc.TabStop = true;
            this.radConHieuLuc.Text = "Còn hiệu lực";
            this.radConHieuLuc.UseVisualStyleBackColor = true;
            // 
            // radHetHieuLuc
            // 
            this.radHetHieuLuc.AutoSize = true;
            this.radHetHieuLuc.Location = new System.Drawing.Point(218, 79);
            this.radHetHieuLuc.Name = "radHetHieuLuc";
            this.radHetHieuLuc.Size = new System.Drawing.Size(82, 17);
            this.radHetHieuLuc.TabIndex = 3;
            this.radHetHieuLuc.TabStop = true;
            this.radHetHieuLuc.Text = "Hết hiệu lực";
            this.radHetHieuLuc.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(109, 121);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(218, 121);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLamMoi.Location = new System.Drawing.Point(637, 152);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(36, 23);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(445, 30);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(202, 20);
            this.txtGhiChu.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(379, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Ghi chú";
            // 
            // txbTimKiemDanhMuc
            // 
            this.txbTimKiemDanhMuc.Location = new System.Drawing.Point(445, 154);
            this.txbTimKiemDanhMuc.Name = "txbTimKiemDanhMuc";
            this.txbTimKiemDanhMuc.Size = new System.Drawing.Size(100, 20);
            this.txbTimKiemDanhMuc.TabIndex = 7;
            this.txbTimKiemDanhMuc.EditValueChanged += new System.EventHandler(this.txbTimKiemDanhMuc_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(556, 152);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(35, 23);
            this.simpleButton1.TabIndex = 8;
            // 
            // FormQuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 474);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txbTimKiemDanhMuc);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.radHetHieuLuc);
            this.Controls.Add(this.radConHieuLuc);
            this.Controls.Add(this.grdQuanLyDanhMuc);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Name = "FormQuanLyDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục";
            this.Load += new System.EventHandler(this.FormQuanLyDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuanLyDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTimKiemDanhMuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTenDanhMuc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdQuanLyDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuanLyDanhMuc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RadioButton radConHieuLuc;
        private System.Windows.Forms.RadioButton radHetHieuLuc;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txbTimKiemDanhMuc;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}