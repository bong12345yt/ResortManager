using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class Phong
    {
        public static List<String> SelectLayerRoom(out ResortManagerDTO.DTO.DbAck ack)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayDanhSachTang", out ack, null);
            List<String> lstLayerRoom = new List<String>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                lstLayerRoom.Add(row["TANG"].ToString());
            }
            provider.Disconnect();
            return lstLayerRoom;
        }
    }
}
