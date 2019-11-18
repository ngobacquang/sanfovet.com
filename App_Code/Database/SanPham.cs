using System;
using System.Data;
using System.Data.OleDb;


namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các truy vấn liên quan đến bản Sản Phẩm
    /// </summary>
    public class SanPham
    {
        #region Phương thức xóa sản phẩm theo mã sản phẩm được truyền vào
        /// <summary>
        /// Phương thức xóa sản phẩm theo mã sản phẩm được truyền vào
        /// </summary>
        /// <param name="masp">Mã sản phẩm cần xóa</param>
        public static void Sanpham_Delete(string masp)
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện thêm mới dữ liệu sản phẩm
        /// <summary>
        /// Thực hiện thêm mới dữ liệu sản phẩm
        /// </summary>
        public static void Sanpham_Inser(
                            string tensp,
                            string mauID,
                            string sizeID,
                            string chatieuID,
                            string anhsanpham,
                            string soluongsp,
                            string giasp,
                            string motasp,
                            string ngaytao,
                            string ngayhuy,
                            string maDM,
                            string nhomID,
                            string ret)
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@mauID", mauID);
            cmd.Parameters.AddWithValue("@sizeID", sizeID);
            cmd.Parameters.AddWithValue("@chatieuID", chatieuID);
            cmd.Parameters.AddWithValue("@anhsanpham", anhsanpham);

            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);

            cmd.Parameters.AddWithValue("@maDM", maDM);
            cmd.Parameters.AddWithValue("@nhomID", nhomID);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }

        public static DataTable Thongtin_Sanpham_by_nhomid(string nhomID)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Thực hiện update thông tin sản phẩm
        /// <summary>
        /// Thực hiện update thông tin sản phẩm
        /// </summary>
        public static void Sanpham_Update(
                                            string masp,
                                            string tensp,
                                            string mauid,
                                            string sizeid,
                                            string chatieuid,
                                            string anhsp,
                                            string soluongsp,
                                            string giasp,
                                            string motasp,
                                            string ngaytao,
                                            string ngayhuy,
                                            string madm,
                                            string nhomid
                                        )
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@mauid", mauid);
            cmd.Parameters.AddWithValue("@sizeid", sizeid);
            cmd.Parameters.AddWithValue("@chatieuid", chatieuid);
            cmd.Parameters.AddWithValue("@anhsp", anhsp);
            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);
            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@nhomid", nhomid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin tất cả sản phẩm
        /// <summary>
        /// Thực hiện lấy thông tin tất cả sản phẩm
        /// </summary>
        public static DataTable Thongtin_Sanpham()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin sản phẩm theo ID
        /// <summary>
        /// Thực hiện lấy thông tin sản phẩm theo ID
        /// </summary>
        public static DataTable Thongtin_Sanpham_by_id(string MaSP)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSP", MaSP);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin sản phẩm theo Mã danh mục
        /// <summary>
        /// Thực hiện lấy thông tin sản phẩm theo Mã danh mục
        /// </summary>
        public static DataTable Thongtin_Sanpham_by_madm(string MaMD)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_madm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMD", MaMD);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin tất cả sản phẩm theo Mã danh mục
        /// <summary>
        /// Thực hiện lấy thông tin tất cả sản phẩm theo Mã danh mục
        /// </summary>
        public static DataTable Thongtin_Sanpham_by_madm_tatca(string MaMD)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_madm_tatca");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMD", MaMD);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin sản phẩm theo nhóm ID
        /// <summary>
        /// Thực hiện lấy thông tin sản phẩm theo nhóm ID
        /// </summary>
        public static DataTable Thongtin_Sanpham_by_nhomid(string NhomID, string SoSPHienThi)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_nhomid");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomID", NhomID);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Thực hiện lấy thông tin sản phẩm theo Từ khóa
        /// <summary>
        /// Thực hiện lấy thông tin sản phẩm theo Từ khóa
        /// </summary>
        public static DataTable Thongtin_Sanpham_by_tukhoa(string TuKhoa)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_tukhoa");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", TuKhoa);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
