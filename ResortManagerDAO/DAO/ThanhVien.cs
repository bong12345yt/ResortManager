using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ResortManagerDAO.DAO
{
    public class ThanhVien
    {
        public static ResortManagerDTO.DTO.DbAck ThemThanhVien(ResortManagerDTO.DTO.ThanhVien tv)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@CMND", tv.CMND),
                       new SqlParameter("@HoTen", tv.HoTen),
                       new SqlParameter("@MaDoan", tv.MaDoan)
             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_ThemThanhVien", para);
            provider.Disconnect();
            //lable network
            Network:
            return result;
        }

        public static ResortManagerDTO.DTO.DbAck XoaThanhVienTheoMaDoan(String MaDoan)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@MaDoan",MaDoan)
             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_XoaThanhVienTheoMaDoan", para);
            provider.Disconnect();
        //lable network
        Network:
            return result;
        }

        public static List<ResortManagerDTO.DTO.ThanhVien> LayDanhSachThanhVienTheoMaDoan(out ResortManagerDTO.DTO.DbAck ack, String MaDoan)
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
                       new SqlParameter("@maDoan", MaDoan)

                 };
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayDSTVtheoMaDoan", out ack, para);
            List<ResortManagerDTO.DTO.ThanhVien> lstItem = new List<ResortManagerDTO.DTO.ThanhVien>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                ResortManagerDTO.DTO.ThanhVien item = new ResortManagerDTO.DTO.ThanhVien();
                item.CMND = row["CMND"].ToString();
                item.HoTen = row["HOTEN"].ToString();
                item.MaDoan = row["MADOAN"].ToString();
                lstItem.Add(item);
            }
            provider.Disconnect();
            return lstItem;
        }

    }
}
