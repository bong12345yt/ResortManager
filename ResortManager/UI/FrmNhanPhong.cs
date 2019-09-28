using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortManager.UI
{
    public partial class FrmNhanPhong : UserControl
    {
        public FrmNhanPhong()
        {
            InitializeComponent();
        }

        private void FrmNhanPhong_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.Items.Add("True");
            cmb.Items.Add("False");
            dgvLst.Rows.Add(new String[5] { "1", "Trần văn A", "10101010", "200000", "0"});
            dgvLst.Rows.Add(new String[5] { "1", "Trần văn A", "22222222222", "200000", "0"});
        }
    }
}
