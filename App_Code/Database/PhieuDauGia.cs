using System;
using System.Data;
using System.Data.OleDb;


namespace emdepvn
{
    /// <summary>
    /// Class thực hiên các tác vụ liên quan đến Phiếu đấu giá
    /// </summary>
    public class PhieuDauGia
    {
        #region Delete một phiếu đấu giá theo Mã
        /// <summary>
        /// Delete một phiếu đấu giá theo Mã
        /// </summary>
        public static void Phiendaugia_Delete(string MaPhienDG)
        {
            OleDbCommand cmd = new OleDbCommand("phiendaugia_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Insert một phiếu đấu giá theo Mã
        /// <summary>
        /// Insert một phiếu đấu giá theo Mã
        /// </summary>
        public static void Phiendaugia_Inser(
                string ThoiGianBatDau,
                string ThoigGianKetThuc,
                string MaSP,
                string GiaDeXuat,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("phiendaugia_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ThoiGianBatDau", ThoiGianBatDau);
            cmd.Parameters.AddWithValue("@ThoigGianKetThuc", ThoigGianKetThuc);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@GiaDeXuat", GiaDeXuat);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region UPdate một phiếu đấu giá theo Mã
        /// <summary>
        /// UPdate một phiếu đấu giá theo Mã
        /// </summary>
        public static void Phiendaugia_Update(
                string MaPhienDG,
                string ThoiGianBatDau,
                string ThoigGianKetThuc,
                string MaSP,
                string GiaDeXuat
            )
        {
            OleDbCommand cmd = new OleDbCommand("phiendaugia_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);
            cmd.Parameters.AddWithValue("@ThoiGianBatDau", ThoiGianBatDau);
            cmd.Parameters.AddWithValue("@ThoigGianKetThuc", ThoigGianKetThuc);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@GiaDeXuat", GiaDeXuat);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Lấy thông tin phiếu đấu giá
        /// <summary>
        /// Lấy thông tin phiếu đấu giá
        /// </summary>
        public static DataTable Thongtin_phiendaugia()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_phiendaugia");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin phiếu đấu giá theo Mã
        /// <summary>
        /// Lấy thông tin phiếu đấu giá theo Mã
        /// </summary>
        public static DataTable Thongtin_Phiendaugia_by_id(string MaPhienDG)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_phiendaugia_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}