namespace MyCare
{
    partial class FormQuanLyKhachHang
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
            this.grdQuanLyKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvQuanLyKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.radHetHieuLuc = new System.Windows.Forms.RadioButton();
            this.radConHieuLuc = new System.Windows.Forms.RadioButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgayTao = new DevExpress.XtraEditors.TextEdit();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuanLyKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdQuanLyKhachHang
            // 
            this.grdQuanLyKhachHang.Location = new System.Drawing.Point(12, 184);
            this.grdQuanLyKhachHang.MainView = this.gvQuanLyKhachHang;
            this.grdQuanLyKhachHang.Name = "grdQuanLyKhachHang";
            this.grdQuanLyKhachHang.Size = new System.Drawing.Size(717, 187);
            this.grdQuanLyKhachHang.TabIndex = 0;
            this.grdQuanLyKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuanLyKhachHang});
            // 
            // gvQuanLyKhachHang
            // 
            this.gvQuanLyKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvQuanLyKhachHang.GridControl = this.grdQuanLyKhachHang;
            this.gvQuanLyKhachHang.Name = "gvQuanLyKhachHang";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IDKhachHang";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên khách hàng";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Trạng thái";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày tạo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Số điện thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(134, 107);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(202, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(134, 65);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(202, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(134, 23);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(202, 20);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // radHetHieuLuc
            // 
            this.radHetHieuLuc.AutoSize = true;
            this.radHetHieuLuc.Location = new System.Drawing.Point(632, 24);
            this.radHetHieuLuc.Name = "radHetHieuLuc";
            this.radHetHieuLuc.Size = new System.Drawing.Size(82, 17);
            this.radHetHieuLuc.TabIndex = 5;
            this.radHetHieuLuc.TabStop = true;
            this.radHetHieuLuc.Text = "Hết hiệu lực";
            this.radHetHieuLuc.UseVisualStyleBackColor = true;
            // 
            // radConHieuLuc
            // 
            this.radConHieuLuc.AutoSize = true;
            this.radConHieuLuc.Location = new System.Drawing.Point(512, 24);
            this.radConHieuLuc.Name = "radConHieuLuc";
            this.radConHieuLuc.Size = new System.Drawing.Size(84, 17);
            this.radConHieuLuc.TabIndex = 4;
            this.radConHieuLuc.TabStop = true;
            this.radConHieuLuc.Text = "Còn hiệu lực";
            this.radConHieuLuc.UseVisualStyleBackColor = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(423, 108);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(35, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Ghi chú";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(423, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Trạng thái";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(512, 105);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(202, 20);
            this.txtGhiChu.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(423, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Ngày tạo";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(512, 63);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(202, 20);
            this.txtNgayTao.TabIndex = 6;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(13, 142);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Cập nhật";
            // 
            // FormQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 383);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNgayTao);
            this.Controls.Add(this.radHetHieuLuc);
            this.Controls.Add(this.radConHieuLuc);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.grdQuanLyKhachHang);
            this.Name = "FormQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.grdQuanLyKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdQuanLyKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuanLyKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTenKhachHang;
        private System.Windows.Forms.RadioButton radHetHieuLuc;
        private System.Windows.Forms.RadioButton radConHieuLuc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnSua;
    }
}