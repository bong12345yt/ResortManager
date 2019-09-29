using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class DatChoRecord
    {
        public static List<ResortManagerDTO.DTO.DatChoRecord> SelectDatCho(out ResortManagerDTO.DTO.DbAck ack, String MaDoan)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return null;
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@MADOAN", MaDoan)

             };
            DataTable dt = new DataTable();
            dt = provider.Select(CommandType.StoredProcedure, "SelectDatCho", out ack, para);
            List<ResortManagerDTO.DTO.DatChoRecord> lstDatCho = new List<ResortManagerDTO.DTO.DatChoRecord>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                ResortManagerDTO.DTO.DatChoRecord datcho = new ResortManagerDTO.DTO.DatChoRecord
                {
                    MaCT = Int32.Parse(row["MACHITIET"].ToString()),
                    MaDoan = row["MADOAN"].ToString(),
                    HoTen = row["HOTEN"].ToString(),
                    CMND = row["CMND"].ToString(),
                    MaPhong = row["MAPHONG"].ToString(),
                    NgayBatDau = DateTime.Parse(row["NGAYBATDAU"].ToString()),
                    NgayKetThuc = DateTime.Parse(row["NGAYKETTHUC"].ToString()),
                    Gia = Int32.Parse(row["GIA"].ToString()),
                    ThanhTien = Int32.Parse(row["THANHTIEN"].ToString())
                };

                lstDatCho.Add(datcho);
            }
            provider.Disconnect();
            return lstDatCho;
        }

        public static ResortManagerDTO.DTO.DbAck DeleteDatCho(ResortManagerDTO.DTO.DatChoRecord a)
        {
            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network;
            }

            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@MACHITIET", a.MaCT),
                       new SqlParameter("@MADOAN", a.MaDoan)

             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "DeleteDatCho", para);
            provider.Disconnect();
            Network:
            return result;
        }
    }
}
