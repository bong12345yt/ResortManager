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

        public static ResortManagerDTO.DTO.DbAck ThemCTGD(ResortManagerDTO.DTO.CTGiaoDich ctgd)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@cmnd", ctgd.CMND),
                       new SqlParameter("@maDoan", ctgd.MADOAN),
                       new SqlParameter("@maPhong", ctgd.MAPHONG)
             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_ThemChiTietGiaoDich", para);
            provider.Disconnect();
        //lable network
        Network:
            return result;
        }

        public static ResortManagerDTO.DTO.DbAck ErrThemChiTietGiaoDich(ResortManagerDTO.DTO.CTGiaoDich ctgd)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@cmnd", ctgd.CMND),
                       new SqlParameter("@maDoan", ctgd.MADOAN),
                       new SqlParameter("@maPhong", ctgd.MAPHONG)
             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_ErrThemChiTietGiaoDich", para);
            provider.Disconnect();
        //lable network
        Network:
            return result;
        }

        public static String LayMaCTDG(out ResortManagerDTO.DTO.DbAck ack, String cmnd)
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
                       new SqlParameter("@cmnd", cmnd)
                };
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayMaCTGD", out ack, para);
            if (dt == null)
            {
                return null;
            }
            provider.Disconnect();
            return dt.Rows[0]["MACHITIET"].ToString();
        }
    }
}
