using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_SanPham_Ajax_XuLyGioHang : System.Web.UI.Page
{
    string thaotac = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        thaotac = Request.Params["ThaoTac"];

        switch (thaotac)
        {
            case "ThemVaoGioHang":
                ThemVaoGioHang();
                break;
            case "LayThongTinGioHang":
                LayThongTinGioHang();
                break;
            case "LayTongSoSanPhamTrongGioHang":
                LayTongSoSanPhamTrongGioHang();
                break;
            case "LayTongTienTrongGioHang":
                LayTongTienTrongGioHang();
                break;
            case "XoaSPTrongGioHang":
                XoaSPTrongGioHang();
                break;
            case "CapNhatSoLuongVaoGioHang":
                CapNhatSoLuongVaoGioHang();
                break;
            case "GuiDonHang":
                GuiDonHang();
                break;
        }
    }

    #region Gửi đơn hàng
    private void GuiDonHang()
    {
        string ketQua = "";
        // Lấy các thông tin người dùng gửi lên
        string hoTen = Request.Params["hoTen"];
        string diaChi = Request.Params["diaChi"];
        string soDienThoai = Request.Params["soDienThoai"];
        string email = Request.Params["email"];

        // nếu có giỏ hàng thì mới xử lý
        if (Session["GioHang"] != null)
        {
            // Khai báo datatable để chứa giở hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];


            #region Lặp trong giỏ hàng để lấy ra tổng tiền
            double tongTien = 0;
            for (int i =0; i< dtGioHang.Rows.Count; i++)
            {
                tongTien += int.Parse(dtGioHang.Rows[i]["SoLuong"].ToString()) * double.Parse(dtGioHang.Rows[i]["GiaSP"].ToString());
            }
            #endregion

            #region Kiểm tra và thêm thông tin vào bảng khách hàng
            string maKH = XuLyThongTinKhachHang(hoTen,diaChi,soDienThoai,email);
            #endregion

            #region Thêm thông tin vào bảng đơn đặt hàng
            // tao don dat hang
            string ngayTao = DateTime.Now.ToString();
            emdepvn.DonDatHang.Dondathang_Inser(ngayTao, tongTien.ToString(),"", maKH, hoTen, soDienThoai, email,"");

            // Lay ra don  dat hang vua tao
            DataTable dtDonDatHang = emdepvn.DonDatHang.thongtin_dondathang_desc();
            string maDonDatHang = dtDonDatHang.Rows[0]["MaDonDatHang"].ToString();
            #endregion

            #region đọc giỏ hàng và thêm từng sản phẩm vào bảng chi tiết đơn hàng.
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                emdepvn.ChiTietDonDatHang.Chitietdondathang_Inser(dtGioHang.Rows[i]["MaSP"].ToString(), maDonDatHang, dtGioHang.Rows[i]["SoLuong"].ToString(), dtGioHang.Rows[i]["GiaSP"].ToString(),"");
            }
            #endregion

            #region Xoa session gio hang
            Session["GioHang"] = null;
            #endregion
        }
        ketQua = "Giỏ hàng đã hết hạn, vui lòng chọn lại sản phẩm để đặt hàng";
        Response.Write(ketQua);
    }
    private string XuLyThongTinKhachHang(string hoTen, string diaChi, string soDienThoai, string email)
    {
        // Lay danh sach khach hang thep email neu chua co thi them moi
        DataTable dt = new DataTable();
        dt = emdepvn.KhachHang.Thongtin_Khachhang_by_emailkh(email);
        if(dt.Rows.Count == 0)
        {
            string matKhau = emdepvn.MaHoa.MaHoaMD5(email);
            emdepvn.KhachHang.Khachang_Inser(hoTen, diaChi, soDienThoai, email, matKhau, "");

            // Lấy lại thông tin vừa thêm mới và trả lại mã khách hàng
            dt = emdepvn.KhachHang.Thongtin_Khachhang_by_emailkh(email);
            return dt.Rows[0]["MaKH"].ToString();
        }
        else
        {
            return dt.Rows[0]["MaKH"].ToString();
        }
    }
    #endregion

    #region cập nhật số lượng sản phẩm trong giỏ hàng
    private void CapNhatSoLuongVaoGioHang()
    {
        // Lấy id cần xóa khỏi giỏ hàng
        string idSanPham = Request.Params["idSanPham"];
        string soLuongMoi = Request.Params["soLuongMoi"];

        // nếu có giỏ hàng thì mới lấy ra kết quả
        if (Session["GioHang"] != null)
        {
            // Khai báo datatable để chứa giở hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];

            // Chạy vòng lặp danh sách giỏ hàng
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                if (dtGioHang.Rows[i]["MaSP"].ToString() == idSanPham)
                    dtGioHang.Rows[i]["SoLuong"] = soLuongMoi;
            }
            // Gan lai session
            Session["GioHang"] = dtGioHang;
        }
        Response.Write("");
    }
    #endregion

    #region Xóa sản phẩm trong giỏ hàng
    private void XoaSPTrongGioHang()
    {
        // Lấy id cần xóa khỏi giỏ hàng
        string idSanPham = Request.Params["idSanPham"];

        // nếu có giỏ hàng thì mới lấy ra kết quả
        if (Session["GioHang"] != null)
        {
            // Khai báo datatable để chứa giở hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];

            // Chạy vòng lặp danh sách giỏ hàng
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                if (dtGioHang.Rows[i]["MaSP"].ToString() == idSanPham)
                    dtGioHang.Rows[i].Delete();
            }
            // Gan lai session
            Session["GioHang"] = dtGioHang;
        }
        Response.Write("");
    }
    #endregion

    #region Lấy tổng tiền trong giỏ hàng
    private void LayTongTienTrongGioHang()
    {
        double tongTien = 0;

        // nếu có giỏ hàng thì mới lấy ra kết quả
        if (Session["GioHang"] != null)
        {
            // Khai báo datatable để chứa giở hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];

            // Chạy vòng lặp và tính tổng tiền
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                tongTien += int.Parse(dtGioHang.Rows[i]["SoLuong"].ToString()) * double.Parse(dtGioHang.Rows[i]["GiaSP"].ToString());
            }
        }
        Response.Write(tongTien);
    }
    #endregion

    #region Lấy tổng số sản phẩm trong giỏ hàng
    private void LayTongSoSanPhamTrongGioHang()
    {
        int tongSo = 0;

        // nếu có giỏ hàng thì mới lấy ra kết quả
        if (Session["GioHang"] != null)
        {
            // Khai báo datatable để chứa giở hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];

            // Chạy vòng lặp và đếm tổng số sản phẩm
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                tongSo += int.Parse(dtGioHang.Rows[i]["SoLuong"].ToString());
            }
        }
        Response.Write(tongSo);
    }
    #endregion

    #region Lấy thông tin giỏ hàng
    private void LayThongTinGioHang()
    {
        string ketQua = "";

        // nếu có giỏ hàng thì mới lấy ra kết quả
        if (Session["GioHang"] != null)
        {
            // Khai báo datatable để chứa giở hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];
            ketQua += @"
                <table style='width:100%;' id='cart-table'>
                    <tbody>
                        <tr>
                            <th></th>
                            <th>Tên sản phẩm</th>
                            <th>Số lượng</th>
                            <th>Đơn giá</th>
                            <th></th>
                        </tr>
                        <tr class='line-item original'>
                            <td class='item-image'></td>
                            <td class='item-title'>
                                <a></a>
                            </td>
                            <td class='item-quantity'></td>
                            <td class='item-price'></td>
                            <td class='item-delete'></td>
                        </tr>
            ";
            // Chạy vòng lặp vào xuất dữ liệu theo dạng bảng
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                ketQua += @"
                        <tr class='line-item' id='tr_" + dtGioHang.Rows[i]["MaSP"] + @"'>
                            <td class='item-image'>
                                <img class='anhSPGioHang' src='pic/SanPham/" + dtGioHang.Rows[i]["AnhSP"] + @"' />
                            </td>
                            <td class='item-title'>
                                <a href='/Default.aspx?modul=SanPham&modulphu=ChiTietSanPham&id=" + dtGioHang.Rows[i]["MaSP"] + @"'>" + dtGioHang.Rows[i]["TenSP"] + @"</a>
                            </td>
                            <td class='item-quantity'><input onchange='CapNhatSoLuongVaoGioHang(" + dtGioHang.Rows[i]["MaSP"] + @")' id='quantity_" + dtGioHang.Rows[i]["MaSP"] + @"' name='updates[]' min='1' type='number' value='" + dtGioHang.Rows[i]["SoLuong"] + @"' class=''></td>
                            <td class='item-price'>" + dtGioHang.Rows[i]["GiaSP"] + @"</td>
                            <td class='item-delete'><a href='javascript://' onclick='XoaSPTrongGioHang(" + dtGioHang.Rows[i]["MaSP"] + @")'>Xóa</a></td>
                        </tr>

            ";
            }
            ketQua += @"
                    </tbody>
                </table>
            ";
        }
        Response.Write(ketQua);
    }
    #endregion

    #region Thêm vào giở hàng
    private void ThemVaoGioHang()
    {
        string ketQua = "";
        string id = Request.Params["id"];
        string soluong = Request.Params["soluong"];

        // Lấy thông tin sản phẩm
        DataTable dt = new DataTable();
        dt = emdepvn.SanPham.Thongtin_Sanpham_by_id(id);
        if (dt.Rows.Count > 0) // Nếu tồn tại sản phẩm thì thực hiện
        {
            // Nếu chưa có giỏ hàng thì tạo giỏ hàng
            if (Session["GioHang"] == null)
            {
                // Khai báo datatable để lưu thông tin
                DataTable dtGioHang = new DataTable();
                dtGioHang.Columns.Add("MaSp");
                dtGioHang.Columns.Add("TenSP");
                dtGioHang.Columns.Add("AnhSP");
                dtGioHang.Columns.Add("GiaSP");
                dtGioHang.Columns.Add("SoLuong");

                //Lưu các thông tin hiện tại vào datatable 
                dtGioHang.Rows.Add(dt.Rows[0]["MaSP"].ToString(), dt.Rows[0]["TenSP"].ToString(), dt.Rows[0]["AnhSP"].ToString(), dt.Rows[0]["GiaSP"].ToString(), soluong);

                //Gán giá trị bẳng tạm vào giỏ hàng
                Session["GioHang"] = dtGioHang;
            }
            else // Nếu đã có giỏ hàng thì thêm mới hoặc update lại vào giỏ hàng
            {
                // Khai báo datatable để chứa giở hàng
                DataTable dtGioHang = new DataTable();
                dtGioHang = (DataTable)Session["GioHang"];

                // Kiểm tra xem giỏ hàng đã có chưa

                int ViTriSPTrongGioHang = -1;
                for (int i = 0; i < dtGioHang.Rows.Count; i++)
                {
                    if (dtGioHang.Rows[i]["MaSP"].ToString() == id)
                    {
                        ViTriSPTrongGioHang = i;
                        break;
                    }
                }
                if (ViTriSPTrongGioHang != -1)
                {
                    // Lấy ra số lượng hiện tại 
                    int soLuongHienTai = int.Parse(dtGioHang.Rows[ViTriSPTrongGioHang]["SoLuong"].ToString());

                    // Tăng số lượng lên
                    soLuongHienTai += int.Parse(soluong);

                    //  Cập nhật 
                    dtGioHang.Rows[ViTriSPTrongGioHang]["SoLuong"] = soLuongHienTai;

                    //Gán giá trị bẳng tạm vào giỏ hàng
                    Session["GioHang"] = dtGioHang;
                }
                else
                {
                    //Lưu các thông tin hiện tại vào datatable 
                    dtGioHang.Rows.Add(dt.Rows[0]["MaSP"].ToString(), dt.Rows[0]["TenSP"].ToString(), dt.Rows[0]["AnhSP"].ToString(), dt.Rows[0]["GiaSP"].ToString(), soluong);

                    //Gán giá trị bẳng tạm vào giỏ hàng
                    Session["GioHang"] = dtGioHang;
                }
            }
        }
        else
        {
            ketQua = "Không có sản phẩm này";
        }
        Response.Write(ketQua);
    }
    #endregion
}