using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện truy vấn liên quan đến màu sản phẩm
    /// </summary>
    public class Mau
    {
        #region Thực hiện xóa một màu theo ID
        /// <summary>
        /// Thực hiện xóa một màu theo ID
        /// </summary>
        /// <param name="mauid"></param>
        public static void Mau_Delete(string mauid)
        {
            OleDbCommand cmd = new OleDbCommand("mau_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mauid", mauid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện Thêm một màu mới
        /// <summary>
        /// Thực hiện Thêm một màu mới
        /// </summary>
        /// <param name="tenmau"></param>
        /// <param name="ret"></param>
        public static void Mau_Inser(string tenmau, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("mau_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenmau", tenmau);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện update một màu theo id
        /// <summary>
        /// Thực hiện update một màu theo id
        /// </summary>
        /// <param name="mauid"></param>
        /// <param name="tenmau"></param>
        public static void Mau_Update(string mauid, string tenmau)
        {
            OleDbCommand cmd = new OleDbCommand("mau_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mauid", mauid);
            cmd.Parameters.AddWithValue("@tenmau", tenmau);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Lấy thông tin tất cả các màu
        /// <summary>
        /// Lấy thông tin tất cả các màu
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Mau()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_mau");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin 1 màu theo id
        /// <summary>
        /// Lấy thông tin tất cả các màu
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Mau_by_id(string MauID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_mau_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MauID", MauID);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}