using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class LoaiPhong
    {
        public static List<String> SelectCatRoom(out ResortManagerDTO.DTO.DbAck ack)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayDanhSachHangPhong", out ack, null);
            List<String> lstLeverRoom = new List<String>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                lstLeverRoom.Add(row["HANG"].ToString());
            }
            provider.Disconnect();
            return lstLeverRoom;
        }
    }
}
