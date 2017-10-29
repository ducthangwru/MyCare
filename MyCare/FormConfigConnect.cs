using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using MyCare.MyCareDataAccess.Utils;

namespace MyCare
{
    public partial class FormConfigConnect : DevExpress.XtraEditors.XtraForm
    {
        public FormConfigConnect()
        {
            InitializeComponent();
        }

        private void txbConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DocGhiFileConfig();
            }
        }

        private void GhiFileConfig()
        {
            using (StreamWriter sw = new StreamWriter("config.txt"))
            {
                sw.Write(txbConfig.Text);
            }
        }

        private void FormConfigConnect_Load(object sender, EventArgs e)
        {
            DocGhiFileConfig();
        }

        private void FormConfigConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            GhiFileConfig();
            DocGhiFileConfig();
        }

        private void DocGhiFileConfig()
        {
            int result = Utils.DocFileConfig();

            if (result == -1)
            {
                MessageBox.Show("ConnectString rỗng! Vui lòng nhập lại ConnectionString!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (result == 0)
            {
                MessageBox.Show("ConnectionString có thể bị sai! Vui lòng nhập lại ConnectionString!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormLogin frm = new FormLogin();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}