using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_SanPham_GioHang : System.Web.UI.UserControl
{
    #region Khai bao cac bien thong tin khach hang
    protected string hoTen = "";
    protected string diaChi = "";
    protected string email = "";
    protected string soDienThoai = "";

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LayRaThongTinKhachHangDaDangNhap();
    }

    private void LayRaThongTinKhachHangDaDangNhap()
    {
        // neu khach hang da dang nhap
        if (Session["KhachHang"] != null && Session["KhachHang"] == "1")
        {
            // Lay thong tin session da luu
            hoTen = Session["TenKh"].ToString();
            diaChi = Session["DiaChiKH"].ToString();
            email = Session["sdtKH"].ToString();
            soDienThoai = Session["EmailKH"].ToString();
        }
    }
}