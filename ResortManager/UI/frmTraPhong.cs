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
        public frmTraPhong()
        {
            InitializeComponent();
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            dgvLst.Columns[3].DefaultCellStyle.Format = "n3";
            dgvLst.Columns[4].DefaultCellStyle.Format = "n3";
            dgvLst.Columns[5].DefaultCellStyle.Format = "n3";
            dgvLst.Rows.Add(new String[8] { "1", "Trần văn A", "10101010", "200000", "0", "200000", "Trả", "Thêm BT" });
            dgvLst.Rows.Add(new String[8] { "1", "Trần văn A", "22222222222", "200000", "0", "200000", "Trả", "Thêm BT" });

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
    }
}
