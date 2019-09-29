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
            ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
            List<String> lstCatRoon = new List<String>();
            lstCatRoon = ResortManagerBUS.BUS.LoaiPhong.SelectLeverRoom(out ack);

            foreach(String itemCatRoom in lstCatRoon)
            {
                cmbLever.Items.Add(itemCatRoom);
            }
        }
    }
}
