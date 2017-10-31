namespace MyCare
{
    partial class FormLichSuGiaoDich
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
            this.gridLSGiaoDich = new DevExpress.XtraGrid.GridControl();
            this.gvLSGiaoDich = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txbTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txbDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txbSDT = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLSGiaoDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSGiaoDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLSGiaoDich
            // 
            this.gridLSGiaoDich.Location = new System.Drawing.Point(12, 172);
            this.gridLSGiaoDich.MainView = this.gvLSGiaoDich;
            this.gridLSGiaoDich.Name = "gridLSGiaoDich";
            this.gridLSGiaoDich.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXem});
            this.gridLSGiaoDich.Size = new System.Drawing.Size(700, 225);
            this.gridLSGiaoDich.TabIndex = 0;
            this.gridLSGiaoDich.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLSGiaoDich});
            // 
            // gvLSGiaoDich
            // 
            this.gvLSGiaoDich.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvLSGiaoDich.GridControl = this.gridLSGiaoDich;
            this.gvLSGiaoDich.Name = "gvLSGiaoDich";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(289, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Lịch sử giao dịch";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(194, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên khách hàng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(194, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(194, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // txbTenKH
            // 
            this.txbTenKH.Location = new System.Drawing.Point(330, 58);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Properties.ReadOnly = true;
            this.txbTenKH.Size = new System.Drawing.Size(196, 20);
            this.txbTenKH.TabIndex = 5;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(330, 87);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Properties.ReadOnly = true;
            this.txbDiaChi.Size = new System.Drawing.Size(196, 20);
            this.txbDiaChi.TabIndex = 6;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(330, 115);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Properties.ReadOnly = true;
            this.txbSDT.Size = new System.Drawing.Size(196, 20);
            this.txbSDT.TabIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID Hóa Đơn";
            this.gridColumn1.FieldName = "ID_HoaDon";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.FieldName = "TenTaiKhoan";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 136;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tổng tiền";
            this.gridColumn3.FieldName = "ThanhTien";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 136;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày giao dịch";
            this.gridColumn4.FieldName = "NgayLap";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 136;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ghi chú";
            this.gridColumn5.FieldName = "GhiChu";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 199;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Xem chi tiết";
            this.gridColumn6.ColumnEdit = this.btnXem;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.AutoHeight = false;
            this.btnXem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::MyCare.Properties.Resources.join16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnXem.Name = "btnXem";
            this.btnXem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXem_ButtonClick);
            // 
            // FormLichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 409);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbTenKH);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridLSGiaoDich);
            this.Name = "FormLichSuGiaoDich";
            this.Text = "FormLichSuGiaoDich";
            ((System.ComponentModel.ISupportInitialize)(this.gridLSGiaoDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSGiaoDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridLSGiaoDich;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLSGiaoDich;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txbTenKH;
        private DevExpress.XtraEditors.TextEdit txbDiaChi;
        private DevExpress.XtraEditors.TextEdit txbSDT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXem;
    }
}