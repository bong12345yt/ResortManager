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
    public partial class frmTraPhong : UserControl
    {
        List<ResortManagerDTO.DTO.CTGiaoDich> DS_CTGD = new List<ResortManagerDTO.DTO.CTGiaoDich>();
        List<ResortManagerDTO.DTO.BoiThuong> lstBoiThuong = new List<ResortManagerDTO.DTO.BoiThuong>();
        private String MADOAN;
        public frmTraPhong()
        {
            InitializeComponent();
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {

        }

        private void dgvLst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                frmBoiThuong bt;
                bt = new frmBoiThuong(this.DS_CTGD[e.RowIndex].MACHITIET);
                bt.ShowDialog();
                //MessageBox.Show(bt.Price.ToString());
                this.dgvLst.Rows[e.RowIndex].Cells[4].Value = "0";
                this.dgvLst.Rows[e.RowIndex].Cells[5].Value = "0";
                int tienPhong = int.Parse(this.dgvLst.Rows[e.RowIndex].Cells[4].Value.ToString());
                this.dgvLst.Rows[e.RowIndex].Cells[4].Value = (tienPhong + bt.PhiBoiThuong).ToString();
                this.dgvLst.Rows[e.RowIndex].Cells[5].Value = (int.Parse(this.dgvLst.Rows[e.RowIndex].Cells[4].Value.ToString()) + int.Parse(this.dgvLst.Rows[e.RowIndex].Cells[3].Value.ToString())).ToString();
            }
            if (e.ColumnIndex == 6)
            {
                ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
                int maCTGD = this.DS_CTGD[e.RowIndex].MACHITIET;
                int tongTien = int.Parse(this.dgvLst.Rows[e.RowIndex].Cells[5].Value.ToString());
                ack = ResortManagerBUS.BUS.PhieuTra.CapNhatPhieuTraTheoMaCTGD(maCTGD, tongTien);
                if (ack != ResortManagerDTO.DTO.DbAck.Ok)
                {
                    MessageBox.Show("Trả phòng lỗi");
                    return;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIdRoom.Text.Trim() != "")
            {
                dgvLst.Rows.Clear();
                ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
                this.DS_CTGD = ResortManagerBUS.BUS.CTGiaoDich.SelectByIdRoom(out ack, txtIdRoom.Text.ToUpper());
                foreach (ResortManagerDTO.DTO.CTGiaoDich item in this.DS_CTGD)
                {
                    dgvLst.Rows.Add(new String[8] {item.HOTEN, item.MADOAN.Trim(), item.CMND.Trim(), item.GIA.ToString(), "0", "0", "Trả phòng", "Thêm BT" });
                }
            }
        }
        
    }
}
