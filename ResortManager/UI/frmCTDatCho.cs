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
    public partial class frmCTDatCho : Form
    {
        private String MaDoan = "";
        private List<ResortManagerDTO.DTO.ThanhVien> lstUser = new List<ResortManagerDTO.DTO.ThanhVien>();
        private List<String> lstRoom = new List<String>();
        public frmCTDatCho()
        {
            InitializeComponent();
        }

        public frmCTDatCho(List<ResortManagerDTO.DTO.ThanhVien> lstUser, List<String> lstRoom, String MaDoan)
        {
            this.lstUser = lstUser.ToList<ResortManagerDTO.DTO.ThanhVien>();
            this.lstRoom = lstRoom.ToList<String>();
            this.MaDoan = MaDoan;
            InitializeComponent();
        }

        private void frmCTDatCho_Load(object sender, EventArgs e)
        {
            foreach (String item in this.lstRoom)
            {
                cmbRoom.Items.Add(item);
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLst.Rows.Clear();
        }
        
        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
            ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
            String strIdRoom = cmbRoom.SelectedItem.ToString().Split('-')[0];
            ResortManagerDTO.DTO.CTGiaoDich ctgd = new ResortManagerDTO.DTO.CTGiaoDich();
            for(int i = 0; i < dgvLst.Rows.Count; i++)
            {
                ctgd.CMND = dgvLst.Rows[i].Cells[0].Value.ToString().Trim();
                ctgd.MADOAN = this.MaDoan;
                ctgd.MAPHONG = strIdRoom;
                ack = ResortManagerBUS.BUS.CTGiaoDich.ThemCTGD(ctgd);
                if (ack != ResortManagerDTO.DTO.DbAck.Ok)
                {
                    MessageBox.Show("Thêm CTGD thất bại");
                    return;
                }
                String MaCTGD = ResortManagerBUS.BUS.CTGiaoDich.LayMaCTDG(out ack, ctgd.CMND);
                ack = ResortManagerBUS.BUS.PhieuTra.ThemPhieuTra(MaCTGD);
                if (ack != ResortManagerDTO.DTO.DbAck.Ok)
                {
                    MessageBox.Show("Thêm PHIEUTRA thất bại");
                    return;
                }
            }
            txtCMND_TV1.Text = "";
            dgvLst.Rows.Clear();
            cmbRoom.Items.Remove(cmbRoom.SelectedItem);
            cmbRoom.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedItem.ToString().Split('-')[1] == "1_giuong_don" && dgvLst.Rows.Count >= 1){
                MessageBox.Show("Đã đầy");
                return;
            }
            if (cmbRoom.SelectedItem.ToString().Split('-')[1] == "1_giuong_doi" && dgvLst.Rows.Count >= 1)
            {
                MessageBox.Show("Đã đầy");
                return;
            }
            if (cmbRoom.SelectedItem.ToString().Split('-')[1] == "2_giuong_don" && dgvLst.Rows.Count >= 2)
            {
                MessageBox.Show("Đã đầy");
                return;
            }
            if (cmbRoom.SelectedItem.ToString().Split('-')[1] == "2_giuong_doi" && dgvLst.Rows.Count >= 4)
            {
                MessageBox.Show("Đã đầy");
                return;
            }
            String strName = "";
            foreach (ResortManagerDTO.DTO.ThanhVien item in this.lstUser)
            {
                if (item.CMND.Trim() == txtCMND_TV1.Text.Trim())
                {
                    strName = item.HoTen.Trim();
                    this.lstUser.Remove(item);
                    break;
                }
            }
            if (strName == "")
            {
                MessageBox.Show("Thành viên không tồn tại hoặc đã có phòng");
                return;
            }
            dgvLst.Rows.Add(new String[2] { txtCMND_TV1.Text.Trim(), strName });
        }

        private void btnAddErr_Click(object sender, EventArgs e)
        {
            String strName = "";
            foreach (ResortManagerDTO.DTO.ThanhVien item in this.lstUser)
            {
                if (item.CMND.Trim() == txtCMND_TV1.Text.Trim())
                {
                    strName = item.HoTen.Trim();
                    this.lstUser.Remove(item);
                    break;
                }
            }
            dgvLst.Rows.Add(new String[2] { txtCMND_TV1.Text.Trim(), strName });
        }
    }
}
