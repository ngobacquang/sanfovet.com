using System;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{

    /// <summary>
    /// Class thực hiện các truy vấn liên quan đến chất liệu
    /// </summary>
    public class ChatLieu
    {
        #region Thực hiện xóa sản phẩm theo id truyền vào
        /// <summary>
        /// Thực hiện xóa sản phẩm theo id truyền vào
        /// </summary>
        /// <param name="chatlieuid"></param>
        public static void Chatlieu_Delete(string chatlieuid)
        {
            OleDbCommand cmd = new OleDbCommand("chatlieu_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chatlieuid", chatlieuid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện thêm mới chất liệu sản phẩm
        /// <summary>
        /// Thực hiện thêm mới chất liệu sản phẩm
        /// </summary>
        /// <param name="tenchatlieu"></param>
        /// <param name="ret"></param>
        public static void Chatlieu_Inser(  
                                            string tenchatlieu,
                                            string ret
                                        )
        {
            OleDbCommand cmd = new OleDbCommand("chatlieu_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenchatlieu", tenchatlieu);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện Update thông tin chất liệu sản phẩm
        /// <summary>
        /// Thực hiện Update thông tin chất liệu sản phẩm
        /// </summary>
        /// <param name="chatlieuid"></param>
        /// <param name="tenchatlieu"></param>
        public static void Chatlieu_Update(
                                            string chatlieuid,
                                            string tenchatlieu
                                        )
        {
            OleDbCommand cmd = new OleDbCommand("chatlieu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chatlieuid", chatlieuid);
            cmd.Parameters.AddWithValue("@tenchatlieu", tenchatlieu);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện lấy tất cả thông tin của bản chất liệu sản phẩm
        /// <summary>
        /// Thực hiện lấy tất cả thông tin của bản chất liệu sản phẩm
        /// </summary>
        /// <returns></returns>
        public static DataTable thongtin_chatlieu()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_chatlieu");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin của một chất liệu sản phẩm theo id
        /// <summary>
        /// Thực hiện lấy thông tin của một chất liệu sản phẩm theo id
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Chatlieu_by_id(string ChatLieuID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_chatlieu_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ChatLieuID", ChatLieuID);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}