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
    public partial class frmXemDanhSachDatCho : UserControl
    {
        static ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
        
        DataTable dt;
        public frmXemDanhSachDatCho()
        {
            InitializeComponent();
        }

        #region "chuyen doi list ->datatable"
        private DataTable ConvertToDataTable(List<ResortManagerDTO.DTO.DatChoRecord> lstDatCho)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(String));
            dt.Columns.Add("MADOAN", typeof(String));
            dt.Columns.Add("HOTEN", typeof(String));
            dt.Columns.Add("CMND", typeof(String));
            dt.Columns.Add("MAPHONG", typeof(String));
            dt.Columns.Add("NGAYBATDAU", typeof(String));
            dt.Columns.Add("NGAYKETTHUC", typeof(String));
            dt.Columns.Add("GIA", typeof(String));
            dt.Columns.Add("THANHTIEN", typeof(String));
            dt.Columns.Add("HUY", typeof(String));
            dt.Columns.Add("MACHITIET", typeof(String));

            int i = 0;
            foreach (ResortManagerDTO.DTO.DatChoRecord datcho in lstDatCho)
            {
                i++;
                DataRow r = dt.NewRow();
                r["STT"] = i.ToString();
                r["MADOAN"] = datcho.MaDoan;
                r["HOTEN"] = datcho.HoTen;
                r["CMND"] = datcho.CMND;
                r["MAPHONG"] = datcho.MaPhong;
                r["NGAYBATDAU"] = datcho.NgayBatDau.ToString();
                r["NGAYKETTHUC"] = datcho.NgayKetThuc.ToString();
                r["GIA"] = datcho.Gia.ToString();
                r["THANHTIEN"] = datcho.ThanhTien.ToString();
                r["MACHITIET"] = datcho.MaCT;
                r["HUY"] = "Hủy";
                dt.Rows.Add(r);
            }
            return dt;
        }
        #endregion

        private void frmXemDanhSachDatCho_Load(object sender, EventArgs e)
        {
            if (ack != ResortManagerDTO.DTO.DbAck.Ok)
            {
                MessageBox.Show(ResortManagerDTO.DTO.EnumUtils.stringValueOf(ack), "Error!", MessageBoxButtons.OK);
                return;
            }
            List<ResortManagerDTO.DTO.DatChoRecord> lstDatCho = ResortManagerBUS.BUS.DatChoRecord.SelectDatCho(out ack, frmHome.ActiveAccount);
            if(lstDatCho != null)
            {
                dt = ConvertToDataTable(lstDatCho);

                dgvLst.DataSource = dt;
                dgvLst.Columns[0].CellTemplate.ValueType = typeof(int);
            }
            
        }

        public void LoadGrid()
        {
            List<ResortManagerDTO.DTO.DatChoRecord> lstDatCho = ResortManagerBUS.BUS.DatChoRecord.SelectDatCho(out ack, frmHome.ActiveAccount);
            if (lstDatCho != null)
            {
                dt = ConvertToDataTable(lstDatCho);

                dgvLst.DataSource = dt;
                dgvLst.Columns[0].CellTemplate.ValueType = typeof(int);
            }
        }

        private void dgvLst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataRow row = ((senderGrid.DataSource) as DataTable).Rows[e.RowIndex];
                ResortManagerDTO.DTO.DatChoRecord datcho = new ResortManagerDTO.DTO.DatChoRecord();
                datcho.MaDoan = row["MADOAN"].ToString();
                datcho.HoTen = row["HOTEN"].ToString();
                datcho.CMND = row["CMND"].ToString();
                datcho.MaPhong = row["MAPHONG"].ToString();
                datcho.MaCT = Int32.Parse(row["MACHITIET"].ToString());
                datcho.NgayBatDau = DateTime.Parse(row["NGAYBATDAU"].ToString());
                datcho.NgayKetThuc = DateTime.Parse(row["NGAYKETTHUC"].ToString());
                datcho.Gia = Int32.Parse(row["GIA"].ToString());
                datcho.ThanhTien = Int32.Parse(row["THANHTIEN"].ToString());

                ResortManagerDTO.DTO.DbAck ck = ResortManagerBUS.BUS.DatChoRecord.DeleleteDatCho(datcho);
                if (ck == ResortManagerDTO.DTO.DbAck.Ok)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadGrid();
                }                   
                else if (ck == ResortManagerDTO.DTO.DbAck.NetworkError)
                    MessageBox.Show("Lỗi kết nối", "Thông báo");
                else MessageBox.Show("Lỗi không xác định", "Thông báo");
            }
        }
    }
}
