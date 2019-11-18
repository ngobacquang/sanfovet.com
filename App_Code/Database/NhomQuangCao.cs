using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class Thực hiện các tác vụ liên quan đén Nhóm quảng cáo
    /// </summary>
    public class NhomQuangCao
    {
        #region Delete nhóm quảng cáo theo ID
        /// <summary>
        /// Delete nhóm quảng cáo theo ID
        /// </summary>
        /// <param name="nhomquangcaoid"></param>
        public static void Nhomquangcao_Delete(string nhomquangcaoid)
        {
            OleDbCommand cmd = new OleDbCommand("nhomquangcao_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nhomquangcaoid", nhomquangcaoid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Insert nhóm quảng cáo
        /// <summary>
        /// Insert nhóm quảng cáo theo ID
        /// </summary>
        public static void Nhomquangcao_Inser(
                string tennhomqc,
                string vitriqc,
                string thutunhomqc,
                string anhdaidienqc,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("nhomquangcao_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennhomqc", tennhomqc);
            cmd.Parameters.AddWithValue("@vitriqc", vitriqc);
            cmd.Parameters.AddWithValue("@thutunhomqc", thutunhomqc);
            cmd.Parameters.AddWithValue("@anhdaidienqc", anhdaidienqc);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Update nhóm quảng cáo theo ID
        /// <summary>
        /// Update nhóm quảng cáo theo ID
        /// </summary>
        public static void Nhomquangcao_Update(
                string nhomquangcaoid,
                string tennhomqc,
                string vitriqc,
                string thutunhomqc,
                string anhdaidienqc
            )
        {
            OleDbCommand cmd = new OleDbCommand("nhomquangcao_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nhomquangcaoid", nhomquangcaoid);
            cmd.Parameters.AddWithValue("@tennhomqc", tennhomqc);
            cmd.Parameters.AddWithValue("@vitriqc", vitriqc);
            cmd.Parameters.AddWithValue("@thutunhomqc", thutunhomqc);
            cmd.Parameters.AddWithValue("@anhdaidienqc", anhdaidienqc);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Lấy thông tin nhóm quảng cáo
        /// <summary>
        /// Lấy thông tin nhóm quảng cáo
        /// </summary>
        public static DataTable Thongtin_Nhomquangcao()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomquangcao");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin nhóm quảng cáo theo ID
        /// <summary>
        /// Lấy thông tin nhóm quảng cáo theo ID
        /// </summary>
        public static DataTable thongtin_nhomquangcao_by_id(string NhomQuangCaoID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomquangcao_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomQuangCaoID", NhomQuangCaoID);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin nhóm quảng cáo theo vị trí
        /// <summary>
        /// Lấy thông tin nhóm quảng cáo theo vị trí
        /// </summary>
        public static DataTable Thongtin_Nhomquangcao_by_vitriqc(string ViTriQC)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomquangcao_by_vitriqc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ViTriQC", ViTriQC);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}