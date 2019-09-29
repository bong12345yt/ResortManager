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
            return ResortManagerDAO.DAO.LoaiPhong.SelectCatRoom(out ack);
        }
    }
}
