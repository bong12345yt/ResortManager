using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class CTGiaoDich
    {
        public static List<ResortManagerDTO.DTO.CTGiaoDich> SelectByIdRoom(out ResortManagerDTO.DTO.DbAck ack, String IdRoom)
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
                       new SqlParameter("@maphong", IdRoom)

                 };
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayCTGDtheoMaPhong", out ack, para);
            List<ResortManagerDTO.DTO.CTGiaoDich> lstItem = new List<ResortManagerDTO.DTO.CTGiaoDich>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                ResortManagerDTO.DTO.CTGiaoDich item = new ResortManagerDTO.DTO.CTGiaoDich();
                item.MACHITIET = int.Parse(row["MACHITIET"].ToString());
                item.HOTEN = (row["HOTEN"].ToString());
                item.CMND = (row["CMND"].ToString());
                item.GIA = int.Parse(row["GIA"].ToString());
                item.MADOAN = (row["MADOAN"].ToString());
                item.MAPHONG = (row["MAPHONG"].ToString());
                lstItem.Add(item);
            }
            provider.Disconnect();
            return lstItem;
        }
    }
}
