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
    public partial class frmRegister : UserControl
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ResortManagerDTO.DTO.ThanhVien tv = new ResortManagerDTO.DTO.ThanhVien();
            tv.CMND = txt_CardID.Text;
            tv.HoTen = txt_Name.Text;

            tv.MaDoan = "123";

            ResortManagerDTO.DTO.DbAck ack = ResortManagerBUS.BUS.ThanhVien.ThemThanhVien(tv);

            if (ack != ResortManagerDTO.DTO.DbAck.Ok)
            {
                MessageBox.Show(ResortManagerDTO.DTO.EnumUtils.stringValueOf(ack), "Error!", MessageBoxButtons.OK);
                return;
            }

            else if (ack == ResortManagerDTO.DTO.DbAck.Ok)
            {
                MessageBox.Show("Đã lưu thành công");
                if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
                {
                    MessageBox.Show(ResortManagerDTO.DTO.DbAck.NetworkError.ToString(), "Error!", MessageBoxButtons.OK);

                }
            }
        }
    }
}
