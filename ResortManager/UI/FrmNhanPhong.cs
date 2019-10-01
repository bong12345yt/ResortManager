﻿using System;
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
    public partial class FrmNhanPhong : UserControl
    {
        public FrmNhanPhong()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maGiaoDich = txtMaGiaoDich.Text;
            ResortManagerDTO.DTO.DbAck ack;
            List<ResortManagerDTO.DTO.DanhSachNhanPhong> lstNhanPhong = ResortManagerBUS.BUS.DanhSachNhanPhong.getListNhanPhong(out ack, maGiaoDich);
            foreach (ResortManagerDTO.DTO.DanhSachNhanPhong np in lstNhanPhong) {
                dtbNhanPhong.Rows.Add(new String[6] { np.MaPhong, np.TinhTrang, np.HinhThuc, np.CMND, np.Hang, "Update" });
            }
        }

        private void dgvLst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string maPhong = this.dtbNhanPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine(maPhong);
            }
        }
    }
}
