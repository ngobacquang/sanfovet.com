using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các tác vụ liên quan đến quyền
    /// </summary>
    public class QuyenDangNhap
    {
        #region Xóa quyền đăng nhập
        /// <summary>
        /// Xóa quyền đăng nhập
        /// </summary>
        public static void Quyendangnhap_Delete(string quyenid)
        {
            OleDbCommand cmd = new OleDbCommand("quyendangnhap_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@quyenid", quyenid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region insert quyền đăng nhập
        /// <summary>
        /// Xóa quyền đăng nhập
        /// </summary>
        public static void Quyendangnhap_Inser(string tenquyen, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("quyendangnhap_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenquyen", tenquyen);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region update quyền đăng nhập
        /// <summary>
        /// Xóa quyền đăng nhập
        /// </summary>
        public static void Quyendangnhap_Update(string maquyen, string tenquyen)
        {
            OleDbCommand cmd = new OleDbCommand("quyendangnhap_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maquyen", maquyen);
            cmd.Parameters.AddWithValue("@tenquyen", tenquyen);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region lấy thông tin quyền đăng nhập
        /// <summary>
        /// Xóa quyền đăng nhập
        /// </summary>
        public static DataTable Thongtin_Quyendangnhap()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quyendangnhap");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region lấy thông tin quyền đăng nhập theo ten dang nhap
        /// <summary>
        /// Xóa quyền đăng nhập
        /// </summary>
        public static DataTable Thongtin_Quyendangnhap_by_id(string MaQuyen)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quyendangnhap_by_id");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}