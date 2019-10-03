using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class BoiThuong
    {
        public static List<ResortManagerDTO.DTO.BoiThuong> SelectListItem(out ResortManagerDTO.DTO.DbAck ack)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayDachSachVatDung", out ack, null);
            List<ResortManagerDTO.DTO.BoiThuong> lstItem = new List<ResortManagerDTO.DTO.BoiThuong>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                ResortManagerDTO.DTO.BoiThuong item = new ResortManagerDTO.DTO.BoiThuong();
                item.MABOITHUONG = row["MABOITHUONG"].ToString();
                item.MOTA = row["MOTA"].ToString();
                item.SOTIEN = int.Parse(row["SOTIEN"].ToString());
                lstItem.Add(item);
            }
            provider.Disconnect();
            return lstItem;
        }

        public static String SelectPriceByID(out ResortManagerDTO.DTO.DbAck ack, String Id)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@ma", Id)
             };
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayGiaTienTheoTen", out ack, para);
            if (dt == null)
            {
                return null;
            }
            provider.Disconnect();
            return dt.Rows[0]["SOTIEN"].ToString();
        }
    }
}
