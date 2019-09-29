using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ResortManagerDAO.DAO
{
    public class GiaoDich
    {
        public static ResortManagerDTO.DTO.DbAck TaoMaDoan(out String id)
        {
            Provider pr = new Provider();
            ResortManagerDTO.DTO.DbAck ack = pr.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                id = null;
                return ack;
            }
            SqlParameter p = new SqlParameter("@MaDoan", SqlDbType.NChar, 30);
            p.Direction = ParameterDirection.Output;
            ack = pr.ExcuteNonQuery(CommandType.StoredProcedure, "usp_PhatSinhMaDoan", p);
            id = Convert.ToString(p.Value);
            pr.Disconnect();
            return ack;
        }

        public static ResortManagerDTO.DTO.DbAck ThemGiaoDich(ResortManagerDTO.DTO.GiaoDich gd)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@MaDoan", gd.MaDoan),
                       new SqlParameter("@SoNguoi", gd.SoNguoi),
                       new SqlParameter("@SoPhong", gd.SoPhong),
                       new SqlParameter("@NgayBatDau", gd.NgayBatDau),
                       new SqlParameter("@NgayKetThuc", gd.NgayKetThuc),
                       new SqlParameter("@TongTien", gd.TongTien),
                       new SqlParameter("@CMND", gd.CMND),
                       new SqlParameter("@TrangThai", gd.TrangThai)
             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_ThemGiaoDich", para);
            provider.Disconnect();
            //lable network
            Network:
            return result;
        }

        public static ResortManagerDTO.DTO.DbAck XoaGiaoDich(String MaDoan)
        {

            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@MaDoan",MaDoan)
             };
            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_XoaGiaoDich", para);
            provider.Disconnect();
        //lable network
        Network:
            return result;
        }
    }
}
