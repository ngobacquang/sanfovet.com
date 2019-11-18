using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các công việc liên quan đến Đơn đặt hàng
    /// </summary>
    public class DonDatHang
    {
        #region Thực hiện Delete một đơn đặt hàng
        /// <summary>
        /// Thực hiện Delete một đơn đặt hàng
        /// </summary>
        /// <param name="madondathang"></param>
        public static void Dondathang_Delete(string madondathang)
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madondathang", madondathang);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện Insert một đơn đặt hàng
        /// <summary>
        /// Thực hiện Insert một đơn đặt hàng
        /// </summary>
        public static void Dondathang_Inser(
                string ngaytao,
                string thanhtienhd,
                string tinhtrangdonhang,
                string makh,
                string tenkh,
                string sdtkh,
                string emailkh,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@thanhtienhd", thanhtienhd);
            cmd.Parameters.AddWithValue("@tinhtrangdonhang", tinhtrangdonhang);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện update một đơn đặt hàng
        /// <summary>
        /// Thực hiện Insert một đơn đặt hàng
        /// </summary>
        public static void Dondathang_Update(
                string madondathang,
                string ngaytao,
                string thanhtienhd,
                string tinhtrangdonhang,
                string makh,
                string tenkh,
                string sdtkh,
                string emailkh
            )
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@thanhtienhd", thanhtienhd);
            cmd.Parameters.AddWithValue("@tinhtrangdonhang", tinhtrangdonhang);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin đơn đặt hàng
        /// <summary>
        /// Thực hiện lấy thông tin đơn đặt hàng
        /// </summary>
        public static DataTable Thongtin_Dondathang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin đơn đặt hàng theo ID
        /// <summary>
        /// Thực hiện lấy thông tin đơn đặt hàng theo ID
        /// </summary>
        public static DataTable Thongtin_Dondathang_by_id(string MaDonDatHang)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDonDatHang", MaDonDatHang);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin đơn đặt hàng theo Mã Thanh Toán
        /// <summary>
        /// Thực hiện lấy thông tin đơn đặt hàng theo Mã Thanh Toán
        /// </summary>
        public static DataTable Thongtin_Dondathang_by_mathanhtoan(string mathanhtoan)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_by_mathanhtoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mathanhtoan", mathanhtoan);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin đơn đặt hàng và sắp xếp theo desc
        /// <summary>
        /// Thực hiện lấy thông tin đơn đặt hàng và sắp xếp theo desc
        /// </summary>
        public static DataTable thongtin_dondathang_desc()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_desc");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}