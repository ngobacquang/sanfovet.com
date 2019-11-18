using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các truy vấn liên quan đến Size sản phẩm 
    /// </summary>
    public class Size
    {
        #region Thực hiện xóa một size theo ID
        /// <summary>
        /// Thực hiện xóa một size theo ID
        /// </summary>
        /// <param name="sizeid"></param>
        public static void Size_Delete(string sizeid)
        {
            OleDbCommand cmd = new OleDbCommand("size_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sizeid", sizeid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện thêm một size theo ID
        /// <summary>
        /// Thực hiện thêm một size theo ID
        /// </summary>
        public static void Size_Inser(string tensize, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("size_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensize", tensize);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện update một size
        /// <summary>
        /// Thực hiện update một size theo ID
        /// </summary>
        public static void Size_Update(string sizeid, string tensize)
        {
            OleDbCommand cmd = new OleDbCommand("size_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sizeid", sizeid);
            cmd.Parameters.AddWithValue("@tensize", tensize);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin tất size
        /// <summary>
        /// Thực hiện lấy thông tin tất size
        /// </summary>
        public static DataTable thongtin_size()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_size");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin một size theo id
        /// <summary>
        /// Thực hiện lấy thông tin một size theo id
        /// </summary>
        public static DataTable Thongtin_Size_by_id(string SizeID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_size_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SizeID", SizeID);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}