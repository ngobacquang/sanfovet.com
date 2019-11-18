using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các tác vụ liên quan đến đăng ký
    /// </summary>
    public class DangKy
    {
        #region Thực hiện việc xóa một người dùng theo tên đăng nhập
        /// <summary>
        /// Thực hiện việc xóa một người dùng theo tên đăng nhập
        /// </summary>
        public static void Dangky_Delete(string tendangnhap)
        {
            OleDbCommand cmd = new OleDbCommand("dangky_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện việc Insert một người dùng
        /// <summary>
        /// Thực hiện việc Insert một người dùng
        /// </summary>
        public static void Dangky_Inser(
                string tendangnhap,
                string matkhau,
                string emaildk,
                string diachidk,
                string tendaydu,
                string cauhoibaomat,
                string ngaysinh,
                string gioitinhdk,
                string maquyen,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("dangky_inser");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@emaildk", emaildk);
            cmd.Parameters.AddWithValue("@diachidk", diachidk);
            cmd.Parameters.AddWithValue("@tendaydu", tendaydu);
            cmd.Parameters.AddWithValue("@cauhoibaomat", cauhoibaomat);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinhdk", gioitinhdk);
            cmd.Parameters.AddWithValue("@maquyen", maquyen);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện việc update một người dùng theo tên đăng nhập
        /// <summary>
        /// Thực hiện việc update một người dùng theo tên đăng nhập
        /// </summary>
        public static void Dangky_Update(
                string tendangnhap,
                string matkhau,
                string emaildk,
                string diachidk,
                string tendaydu,
                string cauhoibaomat,
                string ngaysinh,
                string gioitinhdk,
                string maquyen
            )
        {
            OleDbCommand cmd = new OleDbCommand("dangky_update");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@emaildk", emaildk);
            cmd.Parameters.AddWithValue("@diachidk", diachidk);
            cmd.Parameters.AddWithValue("@tendaydu", tendaydu);
            cmd.Parameters.AddWithValue("@cauhoibaomat", cauhoibaomat);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinhdk", gioitinhdk);
            cmd.Parameters.AddWithValue("@maquyen", maquyen);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện việc lấy danh sách thông tin người dùng 
        /// <summary>
        /// Thực hiện việc lấy danh sách thông tin người dùng 
        /// </summary>
        public static DataTable Thongtin_Dangky()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dangky");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện việc lấy danh sách thông tin một người dùng 
        /// <summary>
        /// Thực hiện việc lấy danh sách thông tin một người dùng
        /// </summary>
        public static DataTable Thongtin_Dangky_by_id(string TenDangNhap)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dangky_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện việc lấy danh sách thông tin một người dùng theo id va mat khau
        /// <summary>
        /// Thực hiện việc lấy danh sách thông tin một người dùng
        /// </summary>
        public static DataTable Thongtin_Dangky_by_id_matkhau(string TenDangNhap, string MatKhau)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dangky_by_id_matkhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}