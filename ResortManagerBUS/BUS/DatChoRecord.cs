using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class DatChoRecord
    {
        public static List<ResortManagerDTO.DTO.DatChoRecord> SelectDatCho(out ResortManagerDTO.DTO.DbAck ack, String MaDoan)
        {
            return ResortManagerDAO.DAO.DatChoRecord.SelectDatCho(out ack, MaDoan);
        }

        public static ResortManagerDTO.DTO.DbAck DeleleteDatCho(ResortManagerDTO.DTO.DatChoRecord a)
        {
            return ResortManagerDAO.DAO.DatChoRecord.DeleteDatCho(a);
        }
    }
}
