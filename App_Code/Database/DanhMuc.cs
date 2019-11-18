using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Summary description for DanhMuc
    /// </summary>
    public class DanhMuc
    {
        #region Thực hiện xóa một danh mục sản phẩm theo ID truyền  vào
        /// <summary>
        /// Thực hiện xóa một danh mục sản phẩm theo ID truyền  vào
        /// </summary>
        /// <param name="madm"></param>
        public static void Danhmuc_Delete(string madm)
        {
            OleDbCommand cmd = new OleDbCommand("danhmuc_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện thêm mới một danh mục
        /// <summary>
        /// Thực hiện thêm mới một danh mục
        /// </summary>
        /// <param name="tendm"></param>
        /// <param name="anhdaidien"></param>
        /// <param name="thutu"></param>
        /// <param name="maDMcha"></param>
        /// <param name="ret"></param>
        public static void Danhmuc_Inser(
                string tendm,
                string anhdaidien,
                string thutu,
                string maDMcha,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("danhmuc_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendm", tendm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện update một danh mục sản phẩm
        /// <summary>
        /// Thực hiện update một danh mục sản phẩm
        /// </summary>
        /// <param name="madm"></param>
        /// <param name="tendm"></param>
        /// <param name="anhdaidien"></param>
        /// <param name="thutu"></param>
        /// <param name="maDMcha"></param>
        public static void Danhmuc_Update(
                string madm,
                string tendm,
                string anhdaidien,
                string thutu,
                string maDMcha
            )
        {
            OleDbCommand cmd = new OleDbCommand("danhmuc_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@tendm", tendm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }

        public static DataTable Thongtin_Danhmuc_by_MaDMCha(object maDMCha)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Thực hiện lấy toàn bộ thông tin danh mục
        /// <summary>
        /// Thực hiện lấy toàn bộ thông tin danh mục
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Danhmuc()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuc");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin của 1 danh mục theo id
        /// <summary>
        /// Thực hiện lấy toàn bộ thông tin danh mục
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Danhmuc_by_id(string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuc_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin của danh mục theo mã danh mục cha
        /// <summary>
        /// Thực hiện lấy thông tin của danh mục theo mã danh mục cha
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Danhmuc_by_MaDMCha(string MaDMCha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuc_by_MaDMCha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDMCha", MaDMCha);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}