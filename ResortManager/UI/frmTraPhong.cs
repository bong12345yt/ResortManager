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
        List<ResortManagerDTO.DTO.CTGiaoDich> lstItem = new List<ResortManagerDTO.DTO.CTGiaoDich>();
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
            frmBoiThuong bt;
            if (e.ColumnIndex == 7)
            {
                String str = "txt";
                bt = new frmBoiThuong(str);
                bt.ShowDialog();
                //MessageBox.Show(bt.Price.ToString());
                int priceIndemnify = int.Parse(this.dgvLst.Rows[e.RowIndex].Cells[4].Value.ToString());
                this.dgvLst.Rows[e.RowIndex].Cells[4].Value = (priceIndemnify + bt.Price).ToString();
                this.dgvLst.Rows[e.RowIndex].Cells[5].Value = (int.Parse(this.dgvLst.Rows[e.RowIndex].Cells[4].Value.ToString()) + int.Parse(this.dgvLst.Rows[e.RowIndex].Cells[3].Value.ToString())).ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIdRoom.Text.Trim() != "")
            {
                dgvLst.Rows.Clear();
                ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
                this.lstItem = ResortManagerBUS.BUS.CTGiaoDich.SelectByIdRoom(out ack, txtIdRoom.Text.ToUpper());
                foreach (ResortManagerDTO.DTO.CTGiaoDich item in this.lstItem)
                {
                    dgvLst.Rows.Add(new String[8] {item.HOTEN, item.MADOAN.Trim(), item.CMND.Trim(), item.GIA.ToString(), "0", "0", "Trả phòng", "Thêm BT" });
                }
            }
        }
    }
}
