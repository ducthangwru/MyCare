namespace MyCare
{
    partial class FormChiTietHoaDon
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
            this.gridChiTietHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.txbTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txbTongTien = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTenKH = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txbNgayTao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaHoaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNgayTao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridChiTietHoaDon
            // 
            this.gridChiTietHoaDon.Location = new System.Drawing.Point(12, 159);
            this.gridChiTietHoaDon.MainView = this.gvChiTietHoaDon;
            this.gridChiTietHoaDon.Name = "gridChiTietHoaDon";
            this.gridChiTietHoaDon.Size = new System.Drawing.Size(677, 234);
            this.gridChiTietHoaDon.TabIndex = 0;
            this.gridChiTietHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietHoaDon});
            // 
            // gvChiTietHoaDon
            // 
            this.gvChiTietHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvChiTietHoaDon.GridControl = this.gridChiTietHoaDon;
            this.gvChiTietHoaDon.Name = "gvChiTietHoaDon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txbMaHoaDon
            // 
            this.txbMaHoaDon.Location = new System.Drawing.Point(117, 60);
            this.txbMaHoaDon.Name = "txbMaHoaDon";
            this.txbMaHoaDon.Properties.ReadOnly = true;
            this.txbMaHoaDon.Size = new System.Drawing.Size(146, 20);
            this.txbMaHoaDon.TabIndex = 2;
            // 
            // txbTenNV
            // 
            this.txbTenNV.Location = new System.Drawing.Point(116, 90);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Properties.ReadOnly = true;
            this.txbTenNV.Size = new System.Drawing.Size(147, 20);
            this.txbTenNV.TabIndex = 3;
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(469, 60);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.Properties.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(175, 20);
            this.txbTongTien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên khách hàng";
            // 
            // txbTenKH
            // 
            this.txbTenKH.Location = new System.Drawing.Point(117, 121);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Properties.ReadOnly = true;
            this.txbTenKH.Size = new System.Drawing.Size(146, 20);
            this.txbTenKH.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày tạo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ghi chú";
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(469, 90);
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Properties.ReadOnly = true;
            this.txbGhiChu.Size = new System.Drawing.Size(175, 20);
            this.txbGhiChu.TabIndex = 11;
            // 
            // txbNgayTao
            // 
            this.txbNgayTao.Location = new System.Drawing.Point(469, 121);
            this.txbNgayTao.Name = "txbNgayTao";
            this.txbNgayTao.Properties.ReadOnly = true;
            this.txbNgayTao.Size = new System.Drawing.Size(175, 20);
            this.txbNgayTao.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(280, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(153, 23);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Chi tiết hóa đơn";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Thuốc";
            this.gridColumn1.FieldName = "TenThuoc";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số lượng";
            this.gridColumn2.FieldName = "SoLuong";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tổng tiền";
            this.gridColumn3.FieldName = "ThanhTien";
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
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 405);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txbNgayTao);
            this.Controls.Add(this.txbGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTenKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.txbTenNV);
            this.Controls.Add(this.txbMaHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridChiTietHoaDon);
            this.Name = "FormChiTietHoaDon";
            this.Text = "FormChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaHoaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNgayTao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridChiTietHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietHoaDon;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txbMaHoaDon;
        private DevExpress.XtraEditors.TextEdit txbTenNV;
        private DevExpress.XtraEditors.TextEdit txbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txbTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txbGhiChu;
        private DevExpress.XtraEditors.TextEdit txbNgayTao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}