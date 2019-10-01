using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class TaiKhoan
    {
        public static List<ResortManagerDTO.DTO.TaiKhoan> SelectLoginUser(out  ResortManagerDTO.DTO.DbAck ack)
        {
            return ResortManagerDAO.DAO.TaiKhoan.SelectLoginUser(out ack);
        }

        public static bool CheckLog(string user, string pass)
        {

             ResortManagerDTO.DTO.DbAck ack = new  ResortManagerDTO.DTO.DbAck();
            List<ResortManagerDTO.DTO.TaiKhoan> lstLogin = ResortManagerBUS.BUS.TaiKhoan.SelectLoginUser(out ack);
            if (ack ==  ResortManagerDTO.DTO.DbAck.NetworkError || lstLogin == null)// chỗ này tài khoản chưa được tạo..
            {
                return false;
            }
            for (int i = 0; i < lstLogin.Count; i++)
            {
                if (lstLogin[i].TenTaiKhoan.Trim() == user)
                    if (lstLogin[i].MatKhau.Trim() == pass)
                        return true;
            }
            return false;
        }

        public static ResortManagerDTO.DTO.DbAck ThemTaiKhoan(ResortManagerDTO.DTO.TaiKhoan tk)
        {
            return ResortManagerDAO.DAO.TaiKhoan.ThemTaiKhoan(tk);
        }
    }
}
