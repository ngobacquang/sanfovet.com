using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các tác vụ liên quan đến tin tức
    /// </summary>
    public class TinTuc
    {
        #region Delete một tin tức theo ID
        public static void Tintuc_Delete(string TinTucID)
        {
            OleDbCommand cmd = new OleDbCommand("tintuc_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinTucID", TinTucID);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Insert một tin tức
        public static void Tintuc_Inser(
                string TieuDe,
                string AnhDaiDien,
                string MoTa,
                string NgayDang,
                string LuotXem,
                string ChiTiet,
                string ThuTu,
                string MaDM
            )
        {
            OleDbCommand cmd = new OleDbCommand("tintuc_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TieuDe", TieuDe);
            cmd.Parameters.AddWithValue("@AnhDaiDien", AnhDaiDien);
            cmd.Parameters.AddWithValue("@MoTa", MoTa);
            cmd.Parameters.AddWithValue("@NgayDang", NgayDang);
            cmd.Parameters.AddWithValue("@LuotXem", LuotXem);
            cmd.Parameters.AddWithValue("@ChiTiet", ChiTiet);
            cmd.Parameters.AddWithValue("@ThuTu", ThuTu);
            cmd.Parameters.AddWithValue("@MaDM", MaDM);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Update một tin tức theo ID
        public static void Tintuc_Update(
                string TinTucID,
                string TieuDe,
                string AnhDaiDien,
                string MoTa,
                string NgayDang,
                string LuotXem,
                string ChiTiet,
                string ThuTu,
                string MaDM
            )
        {
            OleDbCommand cmd = new OleDbCommand("tintuc_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinTucID", TinTucID);
            cmd.Parameters.AddWithValue("@TieuDe", TieuDe);
            cmd.Parameters.AddWithValue("@AnhDaiDien", AnhDaiDien);
            cmd.Parameters.AddWithValue("@MoTa", MoTa);
            cmd.Parameters.AddWithValue("@NgayDang", NgayDang);
            cmd.Parameters.AddWithValue("@LuotXem", LuotXem);
            cmd.Parameters.AddWithValue("@ChiTiet", ChiTiet);
            cmd.Parameters.AddWithValue("@ThuTu", ThuTu);
            cmd.Parameters.AddWithValue("@MaDM", MaDM);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Lấy thông tin tin tức
        public static DataTable Thongtin_Tintuc()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin tin tức theo ID
        public static DataTable Thongtin_Tintuc_by_id(string TinTucID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinTucID", TinTucID);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin tin tức theo 1 mã danh mục
        public static DataTable Thongtin_Tintuc_by_madm(string MaMD)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_by_madm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMD", MaMD);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin tin tức theo tất cả mã danh mục
        public static DataTable Thongtin_Tintuc_by_madm_tatca(string MaMD)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_by_madm_tatca");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMD", MaMD);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thủ tục cập nhật lượt xem
        public static void CapNhatLuotXemTinTuc(string id)
        {
            OleDbCommand cmd = new OleDbCommand("CapNhatLuotXemTinTuc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion
    }
}