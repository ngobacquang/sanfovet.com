using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các thao tác với khách hàng
    /// </summary>
    public class KhachHang
    {
        #region Thực hiện delete một khách hàng theo mã KH
        /// <summary>
        /// Thực hiện delete một khách hàng theo mã KH
        /// </summary>
        public static void Khachang_Delete(string makh)
        {
            OleDbCommand cmd = new OleDbCommand("khachang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện Insert một khách hàng
        /// <summary>
        /// Thực hiện Insert một khách hàng
        /// </summary>
        public static void Khachang_Inser(
                string tenkh,
                string diachikh,
                string sdtkh,
                string emailkh,
                string matkhau,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("khachang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@diachikh", diachikh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện Update một khách hàng
        /// <summary>
        /// Thực hiện Update một khách hàng
        /// </summary>
        public static void Khachang_Update(
                string makh,
                string tenkh,
                string diachikh,
                string sdtkh,
                string emailkh,
                string matkhau
            )
        {
            OleDbCommand cmd = new OleDbCommand("khachang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh); 
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@diachikh", diachikh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin khách hàng
        /// <summary>
        /// Thực hiện lấy thông tin khách hàng
        /// </summary>
        public static DataTable Thongtin_Khachhang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhang");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin khách hàng theo Email
        /// <summary>
        /// Thực hiện lấy thông tin khách hàng theo Email
        /// </summary>
        public static DataTable Thongtin_Khachhang_by_emailkh(string emailkh)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhang_by_emailkh");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailkh", emailkh);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin khách hàng theo Email và Mật khẩu
        /// <summary>
        /// Thực hiện lấy thông tin khách hàng theo Email và Mật khẩu
        /// </summary>
        public static DataTable Thongtin_Khachhang_by_emailkh_matkhau(string emailkh, string matkhau)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhang_by_emailkh_matkhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin khách hàng theo mã khách hàng
        /// <summary>
        /// Thực hiện lấy thông tin khách hàng theo mã khách hàng
        /// </summary>
        public static DataTable Thongtin_Khachhang_by_makh(string makh)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhang_by_makh");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}