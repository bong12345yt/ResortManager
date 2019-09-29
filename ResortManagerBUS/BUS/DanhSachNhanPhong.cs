using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerBUS.BUS
{
    public class DanhSachNhanPhong
    {
        public static List<ResortManagerDTO.DTO.DanhSachNhanPhong> getListNhanPhong(out ResortManagerDTO.DTO.DbAck ack, string txtMaGiaoDich)
        {
            return ResortManagerDAO.DAO.DanhSachNhanPhong.getListNhanPhong(out ack, txtMaGiaoDich);
        }
    }
}
