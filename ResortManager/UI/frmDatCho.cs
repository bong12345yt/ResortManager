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
    public partial class frmDatCho : UserControl
    {
        public frmDatCho()
        {
            InitializeComponent();
        }

        private void frmDatCho_Load(object sender, EventArgs e)
        {
            cmbCatRoom.Items.Add("1");
            cmbCatRoom.Items.Add("2");
        }
    }
}
