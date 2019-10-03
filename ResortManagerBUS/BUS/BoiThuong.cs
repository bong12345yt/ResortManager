using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class BoiThuong
    {
        public static List<ResortManagerDTO.DTO.BoiThuong> SelectListItem(out ResortManagerDTO.DTO.DbAck ack)
        {
            return ResortManagerDAO.DAO.BoiThuong.SelectListItem(out ack);
        }

        public static String SelectPriceByID(out ResortManagerDTO.DTO.DbAck ack, String Id)
        {
            return ResortManagerDAO.DAO.BoiThuong.SelectPriceByID(out ack, Id);
        }
    }
}
