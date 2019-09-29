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
        public static List<ResortManagerDTO.DTO.LoaiPhong> SelectCatRoon(out DTO.DTOClasses.DbAck ack)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == DTO.DTOClasses.DbAck.NetworkError)
            {
                return null;
            }
            DataTable dt = new DataTable();
            dt = provider.Select(CommandType.StoredProcedure, "SelectLoginUser", out ack, null);
            List<ResortManagerDTO.DTO.LoaiPhong> lstUser = new List<ResortManagerDTO.DTO.LoaiPhong>();
            if (dt == null)
            {
                return null;
            }
            //foreach (DataRow row in dt.Rows)
            //{
            //    ResortManagerDTO.DTO.LoaiPhong user = new ResortManagerDTO.DTO.LoaiPhong
            //    {
            //        TenLoaiPhong = row["TENLoaiPhong"].ToString(),
            //        MatKhau = row["MATKHAU"].ToString(),
            //        MaDoan = row["MADOAN"].ToString()
            //    };

            //    lstUser.Add(user);
            //}
            provider.Disconnect();
            return lstUser;
        }
    }
}
