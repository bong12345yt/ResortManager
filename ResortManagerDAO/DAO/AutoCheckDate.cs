using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    public class AutoCheckDate
    {
        public static ResortManagerDTO.DTO.DbAck CheckExchage()
        {
            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck result = provider.Connect();
            if (result == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network; // net nhu la networkerror thi nhay den lable network
            }

            result = provider.ExcuteNonQuery(CommandType.StoredProcedure, "CheckGiaoDich", null);
            if (result == ResortManagerDTO.DTO.DbAck.Ok)
            {
                Console.WriteLine("OK!");
            }
            provider.Disconnect();
            //lable network
            Network:
            return result;
        }
    }
}
