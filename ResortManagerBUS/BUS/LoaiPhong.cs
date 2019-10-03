using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class LoaiPhong
    {

        public static List<String> SelectLeverRoom(out ResortManagerDTO.DTO.DbAck ack)
        {
            return ResortManagerDAO.DAO.LoaiPhong.SelectLeverRoom(out ack);
        }

        public static List<String> SelectTypeRoom(out ResortManagerDTO.DTO.DbAck ack)
        {
            return ResortManagerDAO.DAO.LoaiPhong.SelectTypeRoom(out ack);
        }
        public static String GetPriceByValidate(out ResortManagerDTO.DTO.DbAck ack, String lavel, String type)
        {
            return ResortManagerDAO.DAO.LoaiPhong.GetPriceByValidate(out ack, lavel, type);
        }
    }
}
