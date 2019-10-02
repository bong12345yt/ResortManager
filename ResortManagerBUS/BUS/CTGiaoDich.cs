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
    }
}
