using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class CTPhieuTra
    {
        public static ResortManagerDTO.DTO.DbAck ThemCTPT(ResortManagerDTO.DTO.CTPhieuTra ctpt, int maCTGD)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCTGD", maCTGD),
                new SqlParameter("@maBT", ctpt.MABOITHUONG),
                new SqlParameter("@soluong", ctpt.SOLUONG)
            };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_ThemCTPT", para);
            provider.Disconnect();
        //lable network
        Network:
            return result;
        }

        public static int LayMaPhieuTraTheoMaCTGD(out ResortManagerDTO.DTO.DbAck ack, int MaCTGD)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return -1;
            }
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[]
                {
                       new SqlParameter("@maGD", MaCTGD)
                };
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayPhieuTraTheoMaCTGD", out ack, para);
            if (dt == null)
            {
                return -1;
            }
            provider.Disconnect();
            return int.Parse (dt.Rows[0]["MAPHIEU"].ToString());
        }

        public static List<ResortManagerDTO.DTO.CTPhieuTra> LayCTPTtheoMaCTGD(out ResortManagerDTO.DTO.DbAck ack, int MaCTGD)
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
                       new SqlParameter("@maCTGD", MaCTGD)
                };
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayCTPTtheoMaCTGD", out ack, para);
            List<ResortManagerDTO.DTO.CTPhieuTra> lstItem = new List<ResortManagerDTO.DTO.CTPhieuTra>();
            if (dt == null)
            {
                return null;
            }
            foreach(DataRow row in dt.Rows)
            {
                ResortManagerDTO.DTO.CTPhieuTra item = new ResortManagerDTO.DTO.CTPhieuTra();
                item.MACHITIET = int.Parse(row["MACHITIET"].ToString());
                item.MABOITHUONG = row["MABOITHUONG"].ToString();
                item.SOLUONG = int.Parse(row["SOLUONG"].ToString());
                item.MAPHIEUTRA = int.Parse(row["MAPHIEUTRA"].ToString());
                lstItem.Add(item);
            }
            provider.Disconnect();
            return lstItem;
        }
    }
}
