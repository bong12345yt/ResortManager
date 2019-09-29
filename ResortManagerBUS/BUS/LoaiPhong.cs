using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    class LoaiPhong
    {
        public static List<ResortManagerDTO.DTO.LoaiPhong> SelectAuthor(out DTO.DTOClasses.DbAck ack)
        {
            return ResortManagerDAO.DAO.LoaiPhong.SelectCatRoon(out ack);
        }
    }
}
