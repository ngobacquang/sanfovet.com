using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{

    /// <summary>
    /// Viết thủ tục cho bảng Chi tiết đơn hàng
    /// </summary>
    public class ChiTietDonHang
    {
        #region Thực hiện xóa một đơn đặt hàng theo ID truyền vào
        /// <summary>
        /// Thực hiện xóa một đơn đặt hàng theo ID truyền vào
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="mahoadon"></param>
        public static void Chitietdonhang_Delete(string masp, string mahoadon)
        {
            OleDbCommand cmd = new OleDbCommand("chitietdonhang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện thêm một đơn hàng chi tiết
        /// <summary>
        /// Thực hiện thêm một đơn hàng chi tiết
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="mahoadon"></param>
        /// <param name="soluong"></param>
        /// <param name="dongia"></param>
        /// <param name="ret"></param>
        public static void Chitietdonhang_Inser(
                                                string masp,
                                                string mahoadon,
                                                string soluong,
                                                string dongia,
                                                string ret
                                            )
        {
            OleDbCommand cmd = new OleDbCommand("chitietdonhang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện update một đơn hàng chi tiết
        /// <summary>
        /// Thực hiện update một đơn hàng chi tiết
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="mahoadon"></param>
        /// <param name="soluong"></param>
        /// <param name="dongia"></param>
        public static void Chitietdonhang_Update(string masp, string mahoadon, string soluong, string dongia)
        {
            OleDbCommand cmd = new OleDbCommand("chitietdonhang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongia", dongia);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện lấy tất cả thông tin của một chi tiết đơn hàng
        /// <summary>
        /// Thực hiện lấy tất cả thông tin của một chi tiết đơn hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Chitietdonhang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_chitietdonhang");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}