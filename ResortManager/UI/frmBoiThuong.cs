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
        private List<ResortManagerDTO.DTO.BoiThuong> lstItem = new List<ResortManagerDTO.DTO.BoiThuong>();
        private List<ResortManagerDTO.DTO.CTPhieuTra> lstCTPT = new List<ResortManagerDTO.DTO.CTPhieuTra>();
        public frmBoiThuong()
        {
            InitializeComponent();
        }

        private void frmBoiThuong_Load(object sender, EventArgs e)
        {
            txtNum.Text = "1";
            ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
            this.lstItem = ResortManagerBUS.BUS.BoiThuong.SelectListItem(out ack).ToList<ResortManagerDTO.DTO.BoiThuong>();
            foreach(ResortManagerDTO.DTO.BoiThuong item in lstItem)
            {
                cmbItem.Items.Add(item.MOTA);
            }
        }
        public frmBoiThuong(String txt)
        {
            this.CMND = txt;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.lstCTPT.Count; i++)
            {
                ResortManagerDTO.DTO.DbAck ack = ResortManagerBUS.BUS.CTPhieuTra.ThemCTPT(this.lstCTPT[0]);
            }
            this.Dispose();
            this.Close();
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
            foreach(ResortManagerDTO.DTO.BoiThuong item in this.lstItem)
            {
                if (item.MOTA == cmbItem.SelectedItem.ToString())
                {
                    txtPrice.Text = item.SOTIEN.ToString();
                    break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (ResortManagerDTO.DTO.BoiThuong item in this.lstItem)
            {
                if (item.MOTA == cmbItem.SelectedItem.ToString())
                {
                    dgvLst.Rows.Add(new String[3] { item.MABOITHUONG.Trim(), item.MOTA.Trim(), item.SOTIEN.ToString() });
                    ResortManagerDTO.DTO.CTPhieuTra ctpt = new ResortManagerDTO.DTO.CTPhieuTra();
                    ctpt.MABOITHUONG = item.MABOITHUONG;
                    ctpt.SOLUONG = int.Parse(txtNum.Text);
                    this.lstCTPT.Add(ctpt);
                    break;
                }
            }
        }
    }
}
