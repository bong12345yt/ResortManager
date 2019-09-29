using System;
using System.Collections.Generic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResortManagerDTO;

namespace ResortManagerDAO.DAO
{
    class TaiKhoan
    {
        public static List<ResortManagerDTO.DTO.TaiKhoan> SelectLoginUser(out DTO.DTOClasses.DbAck ack)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == DTO.DTOClasses.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            dt = provider.Select(CommandType.StoredProcedure, "SelectLoginUser", out ack, null);
            List<ResortManagerDTO.DTO.TaiKhoan> lstUser = new List<ResortManagerDTO.DTO.TaiKhoan>;
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
    }
}
