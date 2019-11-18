using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Summary description for DanhMucTin
    /// </summary>
    public class DanhMucTin
    {
        #region Thực hiện delete một danh mục tin theo ID
        /// <summary>
        /// Thực hiện xóa một danh mục tin theo ID
        /// </summary>
        public static void Danhmuctin_Delete(string madm)
        {
            OleDbCommand cmd = new OleDbCommand("danhmuctin_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện insert một danh mục tin theo ID
        /// <summary>
        /// Thực hiện insert một danh mục tin theo ID
        /// </summary>
        public static void Danhmuctin_Inser(
                string madm,
                string anhdaidien,
                string thutu,
                string maDMcha,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("danhmuctin_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện update một danh mục tin theo ID
        /// <summary>
        /// Thực hiện update một danh mục tin theo ID
        /// </summary>
        public static void Danhmuctin_Update(
                string madm,
                string tendm,
                string anhdaidien,
                string thutu,
                string maDMcha
            )
        {
            OleDbCommand cmd = new OleDbCommand("danhmuctin_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@tendm", tendm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện Lấy danh mục tin
        /// <summary>
        /// Thực hiện Lấy danh mục tin
        /// </summary>
        public static DataTable thongtin_danhmuctin()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctin");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện Lấy danh mục tin theo ID
        /// <summary>
        /// Thực hiện Lấy danh mục tin theo ID
        /// <summary>
        /// </summary>
        public static DataTable thongtin_danhmuctin_by_id(string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctin_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện Lấy danh mục tin theo mã danh mục cha
        /// <summary>
        /// Thực hiện Lấy danh mục tin theo ID
        /// <summary>
        /// </summary>
        public static DataTable thongtin_danhmuctin_by_MaDMCha(string MaDMCha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctin_by_MaDMCha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDMCha", MaDMCha);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}