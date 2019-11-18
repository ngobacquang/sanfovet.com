using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Summary description for NhanVien
    /// </summary>
    public class NhanVien
    {
        #region Delete nhân viên theo mã nhân viên
        /// <summary>
        /// Delete nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="manv"></param>
        public static void Nhanvien_Delete(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("nhanvien_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Insert nhân viên
        /// <summary>
        /// Insert nhân viên
        /// </summary>
        public static void Nhanvien_Inser(
                string tennv,
                string gioitinhnv,
                string diachinv,
                string sdtnv,
                string ngayvaolam,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("nhanvien_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@gioitinhnv", gioitinhnv);
            cmd.Parameters.AddWithValue("@diachinv", diachinv);
            cmd.Parameters.AddWithValue("@sdtnv", sdtnv);
            cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Update nhân viên
        /// <summary>
        /// Update nhân viên
        /// </summary>
        public static void Nhanvien_Update(
                string manv,
                string tennv,
                string gioitinhnv,
                string diachinv,
                string sdtnv,
                string ngayvaolam
            )
        {
            OleDbCommand cmd = new OleDbCommand("nhanvien_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@gioitinhnv", gioitinhnv);
            cmd.Parameters.AddWithValue("@diachinv", diachinv);
            cmd.Parameters.AddWithValue("@sdtnv", sdtnv);
            cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Update nhân viên
        /// <summary>
        /// Update nhân viên
        /// </summary>
        public static DataTable Thongtin_Nhanvien()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhanvien");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}