using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các truy vấn liên quan đến nhóm sản phẩm
    /// </summary>
    public class Nhom
    {
        #region Thực hiện xóa một nhóm sản phẩm theo id
        /// <summary>
        /// Thực hiện xóa một nhóm sản phẩm theo id
        /// </summary>
        /// <param name="nhomid"></param>
        public static void Nhomsanpham_Delete(string nhomid)
        {
            OleDbCommand cmd = new OleDbCommand("nhomsanpham_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nhomid", nhomid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện Insert một nhóm sản phẩm
        /// <summary>
        /// Thực hiện Insert một nhóm sản phẩm
        /// </summary>
        public static void Nhomsanpham_Inser(
                string tennhom, 
                string anhdaidien, 
                string thutu, 
                string soSPhienthi, 
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("nhomsanpham_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennhom", tennhom);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@soSPhienthi", soSPhienthi);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện Update một nhóm sản phẩm
        /// <summary>
        /// Thực hiện Update một nhóm sản phẩm
        /// </summary>
        public static void Nhomsanpham_Update(
                string nhomid,
                string tennhom,
                string anhdadien,
                string thutu,
                string solanhienthi
            )
        {
            OleDbCommand cmd = new OleDbCommand("nhomsanpham_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nhomid", nhomid);
            cmd.Parameters.AddWithValue("@tennhom", tennhom);
            cmd.Parameters.AddWithValue("@anhdadien", anhdadien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@solanhienthi", solanhienthi);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin tất cả các nhóm sản phẩm
        /// <summary>
        /// Thực hiện lấy thông tin tất cả các nhóm sản phẩm
        /// </summary>
        public static DataTable Thongtin_Nhomsp()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomsp");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin một nhóm sản phẩm theo id
        /// <summary>
        /// Thực hiện lấy thông tin một nhóm sản phẩm theo id
        /// </summary>
        public static DataTable Thongtin_Nhomsp_by_id(string NhomID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomsp_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomID", NhomID);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}