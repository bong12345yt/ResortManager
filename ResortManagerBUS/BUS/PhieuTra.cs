using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class PhieuTra
    {
        public static ResortManagerDTO.DTO.DbAck ThemPhieuTra(String MaCTGD)
        {
            return ResortManagerDAO.DAO.PhieuTra.ThemPhieuTra(MaCTGD);
        }
        public static ResortManagerDTO.DTO.DbAck CapNhatPhieuTraTheoMaCTGD(int MaCTGD, int TongTien)
        {

            return ResortManagerDAO.DAO.PhieuTra.CapNhatPhieuTraTheoMaCTGD(MaCTGD, TongTien);
        }
    }
}
