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

        public static List<ResortManagerDTO.DTO.Phong> SelectListRoomByValidate(out ResortManagerDTO.DTO.DbAck ack, String lever, String type, int layer)
        {
            return ResortManagerDAO.DAO.Phong.SelectListRoomByValidate(out ack, lever, type, layer);
        }

        public static void UpdateStatus(out ResortManagerDTO.DTO.DbAck ack, String maphong, string MaDoan)
        {
            ResortManagerDAO.DAO.Phong.UpdateStatus(out ack, maphong, MaDoan);
        }

        public static void CapNhatTinhTrangPhongDangRanh(out ResortManagerDTO.DTO.DbAck ack, String maphong)
        {
            ResortManagerDAO.DAO.Phong.CapNhatTinhTrangPhongDangRanh(out ack, maphong);
        }
    }
}
