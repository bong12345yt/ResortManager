using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class CTGiaoDich
    {
        public static List<ResortManagerDTO.DTO.CTGiaoDich> SelectByIdRoom(out ResortManagerDTO.DTO.DbAck ack, String IdRoom)
        {
            return ResortManagerDAO.DAO.CTGiaoDich.SelectByIdRoom(out ack, IdRoom);
        }
        public static ResortManagerDTO.DTO.DbAck ThemCTGD(ResortManagerDTO.DTO.CTGiaoDich ctgd)
        {
            return ResortManagerDAO.DAO.CTGiaoDich.ThemCTGD(ctgd);
        }
        public static ResortManagerDTO.DTO.DbAck ErrThemChiTietGiaoDich(ResortManagerDTO.DTO.CTGiaoDich ctgd)
        {
            return ResortManagerDAO.DAO.CTGiaoDich.ErrThemChiTietGiaoDich(ctgd);
        }
        public static String LayMaCTDG(out ResortManagerDTO.DTO.DbAck ack, String cmnd)
        {
            return ResortManagerDAO.DAO.CTGiaoDich.LayMaCTDG(out ack, cmnd);
        }
    }
}
