﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public static List<ResortManagerDTO.DTO.Phong> SelectListRoomByValidate(out ResortManagerDTO.DTO.DbAck ack, String lever, String type, int layer)
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
                       new SqlParameter("@hang", lever),
                       new SqlParameter("@hinhthuc", type),
                       new SqlParameter("@tang", layer)

                 };
            dt = provider.Select(CommandType.StoredProcedure, "usp_LayDanhSachPhongTheoDieuKien", out ack, para);
            List<ResortManagerDTO.DTO.Phong> lstRoom = new List<ResortManagerDTO.DTO.Phong>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                ResortManagerDTO.DTO.Phong room = new ResortManagerDTO.DTO.Phong();
                room.MAPHONG = row["MAPHONG"].ToString();
                room.TANG = int.Parse(row["TANG"].ToString());
                room.TINHTRANG = row["TINHTRANG"].ToString();
                room.MALOAI = row["MALOAI"].ToString();
                room.GIA = int.Parse(row["GIA"].ToString());
                lstRoom.Add(room);
            }
            provider.Disconnect();
            return lstRoom;
        }

        public static ResortManagerDTO.DTO.DbAck UpdateStatus(String maphong, string MaDoan)
        {
            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck ack = provider.Connect();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network;
            }
            DataTable dt = new DataTable();
            SqlParameter x = new SqlParameter("@kq", SqlDbType.Int);
            x.Direction = ParameterDirection.Output;
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong", maphong),
                new SqlParameter("@maDoan", MaDoan),
                x
            };
            ack = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_CapNhatTinhTrangPhong", para);
            if (Convert.ToInt32(x.Value) == -1)
            {
                ack = ResortManagerDTO.DTO.DbAck.LostUpdate;
            }
        Network:
            return ack;
        }
        public static ResortManagerDTO.DTO.DbAck Err10SCapNhatTinhTrangPhong(String maphong, string MaDoan)
        {
            Provider provider = new Provider();
            ResortManagerDTO.DTO.DbAck ack = provider.Connect();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                goto Network;
            }
            DataTable dt = new DataTable();
            SqlParameter x = new SqlParameter("@kq", SqlDbType.Int);
            x.Direction = ParameterDirection.Output;
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong", maphong),
                new SqlParameter("@maDoan", MaDoan),
                x
            };
            ack = provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_Err10SCapNhatTinhTrangPhong", para);
            if (Convert.ToInt32(x.Value) == -1)
            {
                ack = ResortManagerDTO.DTO.DbAck.LostUpdate;
            }
        Network:
            return ack;
        }

        public static void CapNhatTinhTrangPhongDangRanh(out ResortManagerDTO.DTO.DbAck ack, String maphong)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return;
            }
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[]
                {
                       new SqlParameter("@maphong", maphong)
                };
            provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_CapNhatTinhTrangPhongDangRanh", para);
        }

        public static void ErrCapNhatTinhTrangPhongDangRanh(out ResortManagerDTO.DTO.DbAck ack, String maphong)
        {
            Provider provider = new Provider();
            ack = provider.Connect();
            if (ack == ResortManagerDTO.DTO.DbAck.NetworkError)
            {
                return;
            }
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[]
                {
                       new SqlParameter("@maphong", maphong)
                };
            provider.ExcuteNonQuery(CommandType.StoredProcedure, "usp_ErrCapNhatTinhTrangPhongDangRanh", para);
        }

        public static List<ResortManagerDTO.DTO.Phong> ErrLayDanhSachPhongTheoDieuKien(out ResortManagerDTO.DTO.DbAck ack, String lever, String type, int layer)
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
                       new SqlParameter("@hang", lever),
                       new SqlParameter("@hinhthuc", type),
                       new SqlParameter("@tang", layer)

                 };
            dt = provider.Select(CommandType.StoredProcedure, "usp_ErrLayDanhSachPhongTheoDieuKien", out ack, para);
            List<ResortManagerDTO.DTO.Phong> lstRoom = new List<ResortManagerDTO.DTO.Phong>();
            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                ResortManagerDTO.DTO.Phong room = new ResortManagerDTO.DTO.Phong();
                room.MAPHONG = row["MAPHONG"].ToString();
                room.TANG = int.Parse(row["TANG"].ToString());
                room.TINHTRANG = row["TINHTRANG"].ToString();
                room.MALOAI = row["MALOAI"].ToString();
                room.GIA = int.Parse(row["GIA"].ToString());
                lstRoom.Add(room);
            }
            provider.Disconnect();
            return lstRoom;
        }

    }
}
