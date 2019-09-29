using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDAO.DAO
{
    class Provider
    {
        static String ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ResortManager;Integrated Security=True";

        SqlConnection Connection { get; set; }

        public ResortManagerDTO.DTO.DbAck Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(ConnectionString);
                if (Connection.State != ConnectionState.Closed)
                    Connection.Close();
                Connection.Open();
                return ResortManagerDTO.DTO.DbAck.Ok;
            }
            catch (SqlException ex)
            {

                return (ResortManagerDTO.DTO.DbAck)ResortManagerDTO.DTO.EnumUtils.SetstringValueOf( ResortManagerDTO.DTO.DbAck.NetworkError, ex.Message.ToString());// ResortManagerDTO.DTO.DbAck.NetworkError;
            }
        }

        public void Disconnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public ResortManagerDTO.DTO.DbAck ExcuteNonQuery(CommandType _cmdType, String _strSql, params SqlParameter[] _parameters)
        {
            try
            {
                SqlCommand _command = Connection.CreateCommand();
                _command.CommandText = _strSql;
                _command.CommandType = _cmdType;
                if (_parameters != null && _parameters.Length > 0)
                {
                    _command.Parameters.AddRange(_parameters);
                }

                _command.ExecuteNonQuery();
                return ResortManagerDTO.DTO.DbAck.Ok;
            }
            catch (SqlException e)
            {

                if (e.Procedure == "" && _cmdType != CommandType.Text)
                {
                    //day la loi khong tim thay proce..
                    return (ResortManagerDTO.DTO.DbAck)ResortManagerDTO.DTO.EnumUtils.SetstringValueOf( ResortManagerDTO.DTO.DbAck.MethoodNotFound, e.Message.ToString());

                }
                else
                {
                    // loi khong xac dinh

                    return (ResortManagerDTO.DTO.DbAck)ResortManagerDTO.DTO.EnumUtils.SetstringValueOf( ResortManagerDTO.DTO.DbAck.Unknown, e.Message.ToString());
                }

            }
            catch (SqlTypeException e)
            {
                return (ResortManagerDTO.DTO.DbAck)ResortManagerDTO.DTO.EnumUtils.SetstringValueOf( ResortManagerDTO.DTO.DbAck.TypeDataErro, e.Message.ToString());

            }
        }

        public DataTable Select(CommandType _cmdType, String _strSql, out ResortManagerDTO.DTO.DbAck ack, params SqlParameter[] _parameters)
        {
            try
            {
                SqlCommand _command = Connection.CreateCommand();
                _command.CommandText = _strSql;
                _command.CommandType = _cmdType;
                if (_parameters != null && _parameters.Length > 0)
                {
                    _command.Parameters.AddRange(_parameters);
                }
                SqlDataAdapter da = new SqlDataAdapter(_command);
                DataTable dt = new DataTable();

                da.Fill(dt);
                ack =  ResortManagerDTO.DTO.DbAck.Ok;
                return dt;

            }
            catch (SqlException ex)
            {
                if (ex.Procedure == "" && _cmdType != CommandType.Text)
                    //day la loi khong tim thay proce..
                    ack = ( ResortManagerDTO.DTO.DbAck) ResortManagerDTO.DTO.EnumUtils.SetstringValueOf( ResortManagerDTO.DTO.DbAck.MethoodNotFound, ex.Message.ToString());
                else
                {
                    // loi khong xac dinh
                    ack = ( ResortManagerDTO.DTO.DbAck) ResortManagerDTO.DTO.EnumUtils.SetstringValueOf( ResortManagerDTO.DTO.DbAck.Unknown, ex.Message.ToString());
                }
                return null;
            }
        }
    }
}
