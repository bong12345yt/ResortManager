using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class Phong
    {
        public static List<String> SelectLayerRoom(out ResortManagerDTO.DTO.DbAck ack)
        {
            return ResortManagerDAO.DAO.Phong.SelectLayerRoom(out ack);
        }
    }
}
