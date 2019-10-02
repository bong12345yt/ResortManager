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
        public long PhiBoiThuong = 0;
        private List<ResortManagerDTO.DTO.BoiThuong> lstItem = new List<ResortManagerDTO.DTO.BoiThuong>();
        private List<ResortManagerDTO.DTO.CTPhieuTra> lstCTPT = new List<ResortManagerDTO.DTO.CTPhieuTra>();
        private int MaCTGD;
        public frmBoiThuong()
        {
            InitializeComponent();
        }
        public frmBoiThuong(int MaCTGD)
        {
            this.MaCTGD = MaCTGD;
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

            List<ResortManagerDTO.DTO.CTPhieuTra> CTPTcuaKH = new List<ResortManagerDTO.DTO.CTPhieuTra>();
            CTPTcuaKH = ResortManagerBUS.BUS.CTPhieuTra.LayCTPTtheoMaCTGD(out ack, this.MaCTGD);
            if (CTPTcuaKH.Count > 0)
            {
                foreach(ResortManagerDTO.DTO.CTPhieuTra ct in CTPTcuaKH)
                {
                    foreach (ResortManagerDTO.DTO.BoiThuong item in this.lstItem)
                    {
                        if (ct.MABOITHUONG.Trim() == item.MABOITHUONG.Trim())
                        {
                            dgvLst.Rows.Add(new String[4] { item.MABOITHUONG.Trim(), item.MOTA.Trim(), item.SOTIEN.ToString(), ct.SOLUONG.ToString() });
                            this.PhiBoiThuong += (item.SOTIEN * ct.SOLUONG);
                            break;
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.lstCTPT.Count; i++)
            {
                ResortManagerDTO.DTO.DbAck ack = ResortManagerBUS.BUS.CTPhieuTra.ThemCTPT(this.lstCTPT[i], this.MaCTGD);
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
                    ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
                    dgvLst.Rows.Add(new String[4] { item.MABOITHUONG.Trim(), item.MOTA.Trim(), item.SOTIEN.ToString(), txtNum.Text.Trim() });
                    ResortManagerDTO.DTO.CTPhieuTra ctpt = new ResortManagerDTO.DTO.CTPhieuTra();
                    ctpt.MABOITHUONG = item.MABOITHUONG;
                    ctpt.SOLUONG = int.Parse(txtNum.Text);
                    ctpt.MAPHIEUTRA = ResortManagerBUS.BUS.CTPhieuTra.LayMaPhieuTraTheoMaCTGD(out ack, this.MaCTGD);
                    this.lstCTPT.Add(ctpt);
                    this.PhiBoiThuong += (item.SOTIEN * int.Parse(txtNum.Text.Trim()));
                    break;
                }
            }
        }
    }
}
