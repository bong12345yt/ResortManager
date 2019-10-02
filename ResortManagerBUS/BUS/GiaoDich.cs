using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class GiaoDich
    {
        public static ResortManagerDTO.DTO.DbAck TaoMaDoan(out String id)
        {
            return ResortManagerDAO.DAO.GiaoDich.TaoMaDoan(out id);
        }

        public static ResortManagerDTO.DTO.DbAck ThemGiaoDich(ResortManagerDTO.DTO.GiaoDich gd)
        {
            return ResortManagerDAO.DAO.GiaoDich.ThemGiaoDich(gd);
        }

        public static ResortManagerDTO.DTO.DbAck XoaGiaoDich(String MaDoan)
        {
            return ResortManagerDAO.DAO.GiaoDich.XoaGiaoDich(MaDoan);
        }
    }
}
