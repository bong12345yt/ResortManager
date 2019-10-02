using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class LoaiPhong
    {
        public static List<String> SelectLeverRoom(out ResortManagerDTO.DTO.DbAck ack)
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

        public static List<String> SelectTypeRoom(out ResortManagerDTO.DTO.DbAck ack)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayDanhSachLoaiPhong", out ack, null);
            List<String> lstTypeRoom = new List<String>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                lstTypeRoom.Add(row["HINHTHUC"].ToString());
            }
            provider.Disconnect();
            return lstTypeRoom;
        }
        public static String GetPriceByValidate(out ResortManagerDTO.DTO.DbAck ack, String lavel, String type)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[]
                {
                       new SqlParameter("@hang", lavel),
                       new SqlParameter("@hinhthuc", type)
                };
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayGiaPhong", out ack, para);
            List<String> lstTypeRoom = new List<String>();
            if (dt == null)
            {
                return null;
            }
            provider.Disconnect();
            return dt.Rows[0]["GIA"].ToString();
        }
    }
}
