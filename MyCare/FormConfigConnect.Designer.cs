namespace MyCare
{
    partial class FormConfigConnect
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
            this.txbConfig = new DevExpress.XtraEditors.TextEdit();
            this.btnConfig = new DevExpress.XtraEditors.SimpleButton();
            this.lbConnect = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txbConfig.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(57, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(377, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập ConnectionString để sử dụng phần mềm:";
            // 
            // txbConfig
            // 
            this.txbConfig.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbConfig.Location = new System.Drawing.Point(44, 93);
            this.txbConfig.Name = "txbConfig";
            this.txbConfig.Size = new System.Drawing.Size(390, 20);
            this.txbConfig.TabIndex = 2;
            this.txbConfig.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbConfig_KeyDown);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(208, 119);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "OK";
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lbConnect
            // 
            this.lbConnect.Location = new System.Drawing.Point(44, 37);
            this.lbConnect.Name = "lbConnect";
            this.lbConnect.Size = new System.Drawing.Size(435, 13);
            this.lbConnect.TabIndex = 4;
            this.lbConnect.Text = "Ví dụ: Data Source=DESKTOP-TVC0PFL;Initial Catalog=MyCare;Integrated Security=Tru" +
    "e;";
            // 
            // FormConfigConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 300);
            this.Controls.Add(this.lbConnect);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txbConfig);
            this.Name = "FormConfigConnect";
            this.Text = "FormConfigConnect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfigConnect_FormClosing);
            this.Load += new System.EventHandler(this.FormConfigConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbConfig.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txbConfig;
        private DevExpress.XtraEditors.SimpleButton btnConfig;
        private DevExpress.XtraEditors.LabelControl lbConnect;
    }
}