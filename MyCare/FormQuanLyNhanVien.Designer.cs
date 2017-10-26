namespace MyCare
{
    partial class FormQuanLyNhanVien
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtXacNhanMK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbXacNhanMK = new DevExpress.XtraEditors.LabelControl();
            this.luQuyen = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.radConHieuLuc = new System.Windows.Forms.RadioButton();
            this.radHetHieuLuc = new System.Windows.Forms.RadioButton();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.grdQuanLyNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvQuanLyNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnResetPass = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuanLyNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(155, 22);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(202, 20);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(155, 64);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(202, 20);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên đăng nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(155, 106);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(202, 20);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Location = new System.Drawing.Point(155, 144);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Properties.UseSystemPasswordChar = true;
            this.txtXacNhanMK.Size = new System.Drawing.Size(202, 20);
            this.txtXacNhanMK.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(38, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Xác nhận mật khẩu";
            // 
            // lbXacNhanMK
            // 
            this.lbXacNhanMK.Location = new System.Drawing.Point(363, 147);
            this.lbXacNhanMK.Name = "lbXacNhanMK";
            this.lbXacNhanMK.Size = new System.Drawing.Size(63, 13);
            this.lbXacNhanMK.TabIndex = 4;
            this.lbXacNhanMK.Text = "labelControl5";
            // 
            // luQuyen
            // 
            this.luQuyen.Location = new System.Drawing.Point(507, 26);
            this.luQuyen.Name = "luQuyen";
            this.luQuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luQuyen.Size = new System.Drawing.Size(202, 20);
            this.luQuyen.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(417, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Chọn quyền";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(418, 67);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Trạng thái";
            // 
            // radConHieuLuc
            // 
            this.radConHieuLuc.AutoSize = true;
            this.radConHieuLuc.Location = new System.Drawing.Point(507, 67);
            this.radConHieuLuc.Name = "radConHieuLuc";
            this.radConHieuLuc.Size = new System.Drawing.Size(84, 17);
            this.radConHieuLuc.TabIndex = 6;
            this.radConHieuLuc.TabStop = true;
            this.radConHieuLuc.Text = "Còn hiệu lực";
            this.radConHieuLuc.UseVisualStyleBackColor = true;
            // 
            // radHetHieuLuc
            // 
            this.radHetHieuLuc.AutoSize = true;
            this.radHetHieuLuc.Location = new System.Drawing.Point(627, 67);
            this.radHetHieuLuc.Name = "radHetHieuLuc";
            this.radHetHieuLuc.Size = new System.Drawing.Size(82, 17);
            this.radHetHieuLuc.TabIndex = 7;
            this.radHetHieuLuc.TabStop = true;
            this.radHetHieuLuc.Text = "Hết hiệu lực";
            this.radHetHieuLuc.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(507, 106);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(202, 20);
            this.txtGhiChu.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(418, 109);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(35, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Ghi chú";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 186);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(155, 186);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(687, 186);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // grdQuanLyNhanVien
            // 
            this.grdQuanLyNhanVien.Location = new System.Drawing.Point(12, 224);
            this.grdQuanLyNhanVien.MainView = this.gvQuanLyNhanVien;
            this.grdQuanLyNhanVien.Name = "grdQuanLyNhanVien";
            this.grdQuanLyNhanVien.Size = new System.Drawing.Size(750, 244);
            this.grdQuanLyNhanVien.TabIndex = 8;
            this.grdQuanLyNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuanLyNhanVien});
            // 
            // gvQuanLyNhanVien
            // 
            this.gvQuanLyNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvQuanLyNhanVien.GridControl = this.grdQuanLyNhanVien;
            this.gvQuanLyNhanVien.Name = "gvQuanLyNhanVien";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 139;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên đăng nhập";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 139;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Quyền";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 102;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Trạng thái";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 108;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = " Ngày tạo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 208;
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(282, 186);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(108, 23);
            this.btnResetPass.TabIndex = 11;
            this.btnResetPass.Text = "Đặt lại mật khẩu";
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 480);
            this.Controls.Add(this.grdQuanLyNhanVien);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.radHetHieuLuc);
            this.Controls.Add(this.radConHieuLuc);
            this.Controls.Add(this.luQuyen);
            this.Controls.Add(this.lbXacNhanMK);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtTenNhanVien);
            this.Name = "FormQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuanLyNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenNhanVien;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtXacNhanMK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lbXacNhanMK;
        private DevExpress.XtraEditors.LookUpEdit luQuyen;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.RadioButton radConHieuLuc;
        private System.Windows.Forms.RadioButton radHetHieuLuc;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraGrid.GridControl grdQuanLyNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuanLyNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnResetPass;
    }
}