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
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "ThemThanhVien", para);
            provider.Disconnect();
            //lable network
            Network:
            return result;
        }

    }
}
