using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class GiaoDich
    {
        public static ResortManagerDTO.DTO.DbAck TaoMaDoan(out String id)
        {
            return ResortManagerDAO.DAO.GiaoDich.TaoMaDoan(out id);
        }
    }
}
