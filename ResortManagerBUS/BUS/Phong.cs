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

        public static ResortManagerDTO.DTO.DbAck UpdateStatus(String maphong, string MaDoan)
        {
            return ResortManagerDAO.DAO.Phong.UpdateStatus(maphong, MaDoan);
        }

        public static void CapNhatTinhTrangPhongDangRanh(out ResortManagerDTO.DTO.DbAck ack, String maphong)
        {
            ResortManagerDAO.DAO.Phong.CapNhatTinhTrangPhongDangRanh(out ack, maphong);
        }

        public static void ErrCapNhatTinhTrangPhongDangRanh(out ResortManagerDTO.DTO.DbAck ack, String maphong)
        {
            ResortManagerDAO.DAO.Phong.ErrCapNhatTinhTrangPhongDangRanh(out ack, maphong);
        }
    }
}
