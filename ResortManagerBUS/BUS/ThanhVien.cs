using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class ThanhVien
    {
        public static ResortManagerDTO.DTO.DbAck ThemThanhVien(ResortManagerDTO.DTO.ThanhVien tv)
        {
            return ResortManagerDAO.DAO.ThanhVien.ThemThanhVien(tv);
        }

        public static ResortManagerDTO.DTO.DbAck XoaThanhVienTheoMaDoan(String MaDoan)
        {
            return ResortManagerDAO.DAO.ThanhVien.XoaThanhVienTheoMaDoan(MaDoan);
        }
    }
}
