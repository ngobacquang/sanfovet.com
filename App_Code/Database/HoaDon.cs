using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Summary description for HoaDon
    /// </summary>
    public class HoaDon
    {
        #region Thực hiện delete hóa đơn theo mã hóa đơn
        /// <summary>
        /// Thực hiện delete hóa đơn theo mã hóa đơn
        /// </summary>
        public static void Hoadon_Delete(string mahoadon)
        {
            OleDbCommand cmd = new OleDbCommand("hoadon_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện Insert hóa đơn
        /// <summary>
        /// Thực hiện Insert hóa đơn
        /// </summary>
        public static void Hoadon_Inser(
                string ngaylap,
                string thanhtien,
                string manv,
                string tennv,
                string makh,
                string tenkh,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("hoadon_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện update hóa đơn
        /// <summary>
        /// Thực hiện update hóa đơn
        /// </summary>
        public static void Hoadon_Update(
                string mahoadon,
                string ngaylap,
                string thanhtien,
                string manv,
                string tennv,
                string makh,
                string tenkh
            )
        {
            OleDbCommand cmd = new OleDbCommand("hoadon_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin hóa đơn
        /// <summary>
        /// Thực hiện lấy thông tin hóa đơn
        /// </summary>
        public static DataTable Thongtin_Hoadon()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_hoadon");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}