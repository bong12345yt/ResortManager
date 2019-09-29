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
    }
}
