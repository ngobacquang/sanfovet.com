using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các tác vụ liên quan đến Quảng cáo
    /// </summary>
    public class QuangCao
    {
        #region Dlete quảng cáo theo ID
        /// <summary>
        /// Dlete quảng cáo theo ID
        /// </summary>
        /// <param name="quangcaoid"></param>
        public static void quangcao_delete(string quangcaoid)
        {
            OleDbCommand cmd = new OleDbCommand("quangcao_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@quangcaoid", quangcaoid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Insert quảng cáo
        /// <summary>
        /// Insert quảng cáo
        /// </summary>
        public static void Quangcao_Inser(
                string tenqc,
                string loaiqc,
                string anhqc,
                string lienket,
                string thutuqc,
                string nhomqcID,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("quangcao_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenqc", tenqc);
            cmd.Parameters.AddWithValue("@loaiqc", loaiqc);
            cmd.Parameters.AddWithValue("@anhqc", anhqc);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@thutuqc", thutuqc);
            cmd.Parameters.AddWithValue("@nhomqcID", nhomqcID);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Update quảng cáo theo id
        /// <summary>
        /// Update  quảng cáo theo id
        /// </summary>
        public static void Quangcao_Update(
                string quangcaoid,
                string tenquangcao,
                string loaiqc,
                string anhqc,
                string lienket,
                string thutuqc,
                string nhomquangcaoid
            )
        {
            OleDbCommand cmd = new OleDbCommand("quangcao_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@quangcaoid", quangcaoid);
            cmd.Parameters.AddWithValue("@tenquangcao", tenquangcao);
            cmd.Parameters.AddWithValue("@loaiqc", loaiqc);
            cmd.Parameters.AddWithValue("@anhqc", anhqc);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@thutuqc", thutuqc);
            cmd.Parameters.AddWithValue("@nhomquangcaoid", nhomquangcaoid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Lấy thông tin quảng cáo
        /// <summary>
        /// Lấy thông tin quảng cáo
        /// </summary>
        public static DataTable Thongtin_Quangcao()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quangcao");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin quảng cáo theo ID
        /// <summary>
        /// Lấy thông tin quảng cáo theo ID
        /// </summary>
        public static DataTable Thongtin_Quangcao_by_id(string QuangCaoID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quangcao_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@QuangCaoID", QuangCaoID);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin quảng cáo theo nhóm quảng cáo
        /// <summary>
        /// Lấy thông tin quảng cáo theo theo nhóm quảng cáo
        /// </summary>
        public static DataTable Thongtin_Quangcao_by_nhomquangcaoid(string NhomQuangCaoID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quangcao_by_nhomquangcaoid");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomQuangCaoID", NhomQuangCaoID);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}