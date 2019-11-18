using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_Ajax_DanhMuc : System.Web.UI.Page
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
            case "XoaDanhMuc":
                XoaDanhMuc();
                break;
        }
    }

    private void XoaDanhMuc()
    {
        string MaDM = "";
        if (Request.Params["MaDM"] != null)
            MaDM = Request.Params["MaDM"];

        //B1: Xóa ảnh đại diện đã lưu trên server

        //B1: Xóa dữ liệu trong server
        emdepvn.DanhMuc.Danhmuc_Delete(MaDM);
        Response.Write("1");
    }
}