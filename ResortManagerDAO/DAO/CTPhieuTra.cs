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
        public static ResortManagerDTO.DTO.DbAck ThemCTPT(ResortManagerDTO.DTO.CTPhieuTra ctpt)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@maBT", ctpt.MABOITHUONG),
                       new SqlParameter("@soluong", ctpt.SOLUONG)
             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_ThemChiTietPhieuTra", para);
            provider.Disconnect();
        //lable network
        Network:
            return result;
        }
    }
}
