using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class CTPhieuTra
    {
        public static ResortManagerDTO.DTO.DbAck ThemCTPT(ResortManagerDTO.DTO.CTPhieuTra ctpt, int maCTGD)
        {
            return ResortManagerDAO.DAO.CTPhieuTra.ThemCTPT(ctpt, maCTGD);
        }
        public static int LayMaPhieuTraTheoMaCTGD(out ResortManagerDTO.DTO.DbAck ack, int MaCTGD)
        {
            return ResortManagerDAO.DAO.CTPhieuTra.LayMaPhieuTraTheoMaCTGD(out ack, MaCTGD);
        }
        public static List<ResortManagerDTO.DTO.CTPhieuTra> LayCTPTtheoMaCTGD(out ResortManagerDTO.DTO.DbAck ack, int MaCTGD)
        {
            return ResortManagerDAO.DAO.CTPhieuTra.LayCTPTtheoMaCTGD(out ack, MaCTGD);
        }
    }
}
