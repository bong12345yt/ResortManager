using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResortManagerDTO;
using System.Data.SqlClient;
using System.Data;

namespace ResortManagerDAO.DAO
{
    public class TaiKhoan
    {
        public static List<ResortManagerDTO.DTO.TaiKhoan> SelectLoginUser(out  ResortManagerDTO.DTO.DbAck ack)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack ==  ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            dt = provider.Select(CommandType.StoredProcedure, "SelectLoginUser", out ack, null);
            List<ResortManagerDTO.DTO.TaiKhoan> lstUser = new List<ResortManagerDTO.DTO.TaiKhoan>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                ResortManagerDTO.DTO.TaiKhoan user = new ResortManagerDTO.DTO.TaiKhoan
                {
                    TenTaiKhoan = row["TENTAIKHOAN"].ToString(),
                    MatKhau = row["MATKHAU"].ToString(),
                    MaDoan = row["MADOAN"].ToString()
                };

                lstUser.Add(user);
            }
            provider.Disconnect();
            return lstUser;
        }

        public static ResortManagerDTO.DTO.DbAck ThemTaiKhoan(ResortManagerDTO.DTO.TaiKhoan tk)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@TenTK", tk.TenTaiKhoan),
                       new SqlParameter("@MatKhau", tk.MatKhau),
                       new SqlParameter("@MaDoan", tk.MaDoan)
             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_ThemTaiKhoan", para);
            provider.Disconnect();
        //lable network
        Network:
            return result;
        }
    }
}
