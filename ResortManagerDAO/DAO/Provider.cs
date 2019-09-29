using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAOClasses
{
    class Provider
    {
        static String ConnectionString = @"Data Source=./SQLEXPRESS;Initial Catalog=ResortManager;Integrated Security=True";

        SqlConnection Connection { get; set; }

        public DTO.DTOClasses.DbAck Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(ConnectionString);
                if (Connection.State != ConnectionState.Closed)
                    Connection.Close();
                Connection.Open();
                return DTO.DTOClasses.DbAck.Ok;
            }
            catch (SqlException ex)
            {

                return (DTO.DTOClasses.DbAck)DTO.DTOClasses.EnumUtils.SetstringValueOf(DTO.DTOClasses.DbAck.NetworkError, ex.Message.ToString());//DTO.DTOClasses.DbAck.NetworkError;
            }
        }

        public void Disconnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public DTO.DTOClasses.DbAck ExcuteNonQuery(CommandType _cmdType, String _strSql, params SqlParameter[] _parameters)
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
                return DTO.DTOClasses.DbAck.Ok;
            }
            catch (SqlException e)
            {

                if (e.Procedure == "" && _cmdType != CommandType.Text)
                {
                    //day la loi khong tim thay proce..
                    return (DTO.DTOClasses.DbAck)DTO.DTOClasses.EnumUtils.SetstringValueOf(DTO.DTOClasses.DbAck.MethoodNotFound, e.Message.ToString());

                }
                else
                {
                    // loi khong xac dinh

                    return (DTO.DTOClasses.DbAck)DTO.DTOClasses.EnumUtils.SetstringValueOf(DTO.DTOClasses.DbAck.Unknown, e.Message.ToString());
                }

            }
            catch (SqlTypeException e)
            {
                return (DTO.DTOClasses.DbAck)DTO.DTOClasses.EnumUtils.SetstringValueOf(DTO.DTOClasses.DbAck.TypeDataErro, e.Message.ToString());

            }
        }

        public DataTable Select(CommandType _cmdType, String _strSql, out DTO.DTOClasses.DbAck ack, params SqlParameter[] _parameters)
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
                ack = DTO.DTOClasses.DbAck.Ok;
                return dt;

            }
            catch (SqlException ex)
            {
                if (ex.Procedure == "" && _cmdType != CommandType.Text)
                    //day la loi khong tim thay proce..
                    ack = (DTO.DTOClasses.DbAck)DTO.DTOClasses.EnumUtils.SetstringValueOf(DTO.DTOClasses.DbAck.MethoodNotFound, ex.Message.ToString());
                else
                {
                    // loi khong xac dinh
                    ack = (DTO.DTOClasses.DbAck)DTO.DTOClasses.EnumUtils.SetstringValueOf(DTO.DTOClasses.DbAck.Unknown, ex.Message.ToString());
                }
                return null;
            }
        }
    }
}
