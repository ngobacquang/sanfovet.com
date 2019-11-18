using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhSach_Ajax_SanPham : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // Cần viết code kiểm tra đăng nhập
        // Kiem tra xem da dang nhap hay chua
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {
            // da dang nhap
        }
        else
        {
            // neu chua dang nhap thi chuyen den dang nhap
            return;
        }

        if (Request.Params["ThaoTac"] != null)
            thaotac = Request.Params["ThaoTac"];
        switch (thaotac)
        {
            case "XoaSanPham":
                XoaSanPham();
                break;
        }
    }

    private void XoaSanPham()
    {
        string MaSP = "";
        if (Request.Params["MaSP"] != null)
            MaSP = Request.Params["MaSP"];

        //B1: Xóa ảnh đại diện đã lưu trên server

        //B1: Xóa dữ liệu trong server
        emdepvn.SanPham.Sanpham_Delete(MaSP);
        Response.Write("1");
    }
}