using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Viết thủ tục cho chi tiết đơn đặt hàng
    /// </summary>
    public class ChiTietDonDatHang
    {
        #region Thực hiện xóa chi tiết đơn đặt hàng theo ID truyền vào
            /// <summary>
            /// Thực hiện xóa chi tiết đơn đặt hàng theo ID truyền vào
            /// </summary>
            /// <param name="masp"></param>
            /// <param name="madondathang"></param>
            public static void Chitietdondathang_Delete(string masp, string madondathang)
            {
                OleDbCommand cmd = new OleDbCommand("chitietdondathang_delete");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@madondathang", madondathang);

                SQLDatabase.ExecuteNoneQuery(cmd);
            }
        #endregion

        #region Thực hiện thêm mới một chi tiết đơn đặt hàng
            /// <summary>
            /// Thực hiện thêm mới một chi tiết đơn đặt hàng
            /// </summary>
            /// <param name="masp"></param>
            /// <param name="madondathang"></param>
            /// <param name="soluongdat"></param>
            /// <param name="dongiadat"></param>
            /// <param name="ret"></param>
            public static void Chitietdondathang_Inser(
                                                        string masp,
                                                        string madondathang,
                                                        string soluongdat,
                                                        string dongiadat,
                                                        string ret
                                                    )
            {
                OleDbCommand cmd = new OleDbCommand("chitietdondathang_inser");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@madondathang", madondathang);
                cmd.Parameters.AddWithValue("@soluongdat", soluongdat);
                cmd.Parameters.AddWithValue("@dongiadat", dongiadat);
                cmd.Parameters.AddWithValue("@ret", ret);

                SQLDatabase.ExecuteNoneQuery(cmd);
            }
        #endregion

        #region Thực hiện update chi tiết đơn đặt hàng
            /// <summary>
            /// Thực hiện update chi tiết đơn đặt hàng
            /// </summary>
            /// <param name="masp"></param>
            /// <param name="madondathang"></param>
            /// <param name="soluongdat"></param>
            /// <param name="dongiadat"></param>
            public static void Chitietdondathang_Update(
                                                        string masp,
                                                        string madondathang,
                                                        string soluongdat,
                                                        string dongiadat
                                                    )
            {
                OleDbCommand cmd = new OleDbCommand("chitietdondathang_update");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@madondathang", madondathang);
                cmd.Parameters.AddWithValue("@soluongdat", soluongdat);
                cmd.Parameters.AddWithValue("@dongiadat", dongiadat);

                SQLDatabase.ExecuteNoneQuery(cmd);
            }
        #endregion

        #region Thực hiện lấy tất cả thông tin của bảng chi tiết đơn đặt hàng
        /// <summary>
        /// Thực hiện lấy tất cả thông tin của bảng chi tiết đơn đặt hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Chitietdondathang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_chitietdondathang");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

    }
}