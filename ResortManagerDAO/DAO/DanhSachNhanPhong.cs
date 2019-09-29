using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class DanhSachNhanPhong
    {
        public static List<ResortManagerDTO.DTO.DanhSachNhanPhong> getListNhanPhong(out ResortManagerDTO.DTO.DbAck ack, string txtMaGiaoDich) {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaDoan", txtMaGiaoDich)
            };
            dt = provider.Select(CommandType.StoredProcedure, "usp_DanhSachNhanPhongTheoMaDoan", out ack, para);
            List<ResortManagerDTO.DTO.DanhSachNhanPhong> lstNhanPhong = new List<ResortManagerDTO.DTO.DanhSachNhanPhong>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                ResortManagerDTO.DTO.DanhSachNhanPhong np = new ResortManagerDTO.DTO.DanhSachNhanPhong
                {
                    MaPhong = row["MAPHONG"].ToString(),
                    TinhTrang = row["TINHTRANG"].ToString(),
                    HinhThuc = row["HINHTHUC"].ToString(),
                    Hang = row["HANG"].ToString(),
                    CMND = row["CMND"].ToString()
                };

                lstNhanPhong.Add(np);
            }
            provider.Disconnect();
            return lstNhanPhong;
        }
    }
}
