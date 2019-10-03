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
        public static List<ResortManagerDTO.DTO.ThanhVien> LayDanhSachThanhVienTheoMaDoan(out ResortManagerDTO.DTO.DbAck ack, String MaDoan)
        {
            return ResortManagerDAO.DAO.ThanhVien.LayDanhSachThanhVienTheoMaDoan(out ack, MaDoan);
        }
    }
}
