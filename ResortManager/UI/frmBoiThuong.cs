using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortManager.UI
{
    public partial class frmBoiThuong : Form
    {
        public String CMND;
        public int Price;
        public frmBoiThuong()
        {
            InitializeComponent();
        }

        private void frmBoiThuong_Load(object sender, EventArgs e)
        {

        }
        public frmBoiThuong(String txt)
        {
            this.CMND = txt;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Price = int.Parse(this.txtPrice.Text);
            this.Dispose();
            this.Close();
        }
    }
}
