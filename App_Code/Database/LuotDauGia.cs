using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các công việc liên quan đến Đấu giá
    /// </summary>
    public class LuotDauGia
    {
        #region Thực hiện delete 
        /// <summary>
        /// Thực hiện delete 
        /// </summary>
        public static void Luotdaugia_Delete(string MaLuotDG)
        {
            OleDbCommand cmd = new OleDbCommand("luotdaugia_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLuotDG", MaLuotDG);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện insert 
        /// <summary>
        /// Thực hiện insert 
        /// </summary>
        public static void Luotdaugia_Inser(
                string ThoiGianDG,
                string GiaDuaRa,
                string MaXacNhan,
                string MaKH,
                string MaPhienDG,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("luotdaugia_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ThoiGianDG", ThoiGianDG);
            cmd.Parameters.AddWithValue("@GiaDuaRa", GiaDuaRa);
            cmd.Parameters.AddWithValue("@MaXacNhan", MaXacNhan);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện update 
        /// <summary>
        /// Thực hiện update 
        /// </summary>
        public static void luotdaugia_update(
                string MaLuotDG,
                string ThoiGianDG,
                string GiaDuaRa,
                string MaXacNhan,
                string MaKH,
                string MaPhienDG
            )
        {
            OleDbCommand cmd = new OleDbCommand("luotdaugia_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLuotDG", MaLuotDG);
            cmd.Parameters.AddWithValue("@ThoiGianDG", ThoiGianDG);
            cmd.Parameters.AddWithValue("@GiaDuaRa", GiaDuaRa);
            cmd.Parameters.AddWithValue("@MaXacNhan", MaXacNhan);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin 
        /// <summary>
        /// Thực hiện lấy thông tin  
        /// </summary>
        public static DataTable Thongtin_Luotdaugia()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_luotdaugia");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin theo ID
        /// <summary>
        /// Thực hiện lấy thông tin  
        /// </summary>
        public static DataTable Thongtin_Luotdaugia_by_id(string MaLuotDG)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_luotdaugia_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLuotDG", MaLuotDG);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin theo makh
        /// <summary>
        /// Thực hiện lấy thông tin  
        /// </summary>
        public static DataTable Thongtin_Luotdaugia_by_makh_maphiendg(string MaKH, string MaPhienDG)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_luotdaugia_by_makh_maphiendg");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin theo maphiendg
        /// <summary>
        /// Thực hiện lấy thông tin  
        /// </summary>
        public static DataTable Thongtin_Luotdaugia_by_maphiendg(string MaPhienDG)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_luotdaugia_by_maphiendg");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}