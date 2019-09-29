using System;
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
            List<DTO.DTOClasses.LoginUser> lstUser = new List<DTO.DTOClasses.LoginUser>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                DTO.DTOClasses.LoginUser user = new DTO.DTOClasses.LoginUser
                {
                    username = row["username"].ToString(),
                    password = row["pass"].ToString()
                };

                lstUser.Add(user);
            }
            provider.Disconnect();
            return lstUser;
        }
    }
}
