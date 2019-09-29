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
            List<String> lstLeverRoon = new List<String>();
            lstLeverRoon = ResortManagerBUS.BUS.LoaiPhong.SelectLeverRoom(out ack);

            foreach(String itemLeverRoom in lstLeverRoon)
            {
                cmbLever.Items.Add(itemLeverRoom);
            }

            //set list type for cmb
            List<String> lstTypeRoon = new List<String>();
            lstTypeRoon = ResortManagerBUS.BUS.LoaiPhong.SelectTypeRoom(out ack);

            foreach (String itemCatRoom in lstTypeRoon)
            {
                cmbCatRoom.Items.Add(itemCatRoom);
            }

            //set list layer for cmb
            List<String> lstLayerRoom = new List<String>();
            lstLayerRoom = ResortManagerBUS.BUS.Phong.SelectLayerRoom(out ack);

            foreach (String itemLayerRoom in lstLayerRoom)
            {
                cmbLayer.Items.Add("Tầng " + itemLayerRoom);
            }
        }
    }
}
