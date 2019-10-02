using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class PhieuTra
    {
        public static ResortManagerDTO.DTO.DbAck ThemPhieuTra(String MaCTGD)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@maCTGD", MaCTGD)
             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_ThemPhieuTra", para);
            provider.Disconnect();
        //lable network
        Network:
            return result;
        }
    }
}
