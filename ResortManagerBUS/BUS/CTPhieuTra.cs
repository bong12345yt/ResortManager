using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class CTPhieuTra
    {
        public static ResortManagerDTO.DTO.DbAck ThemCTPT(ResortManagerDTO.DTO.CTPhieuTra ctpt)
        {
            return ResortManagerDAO.DAO.CTPhieuTra.ThemCTPT(ctpt);
        }
    }
}
