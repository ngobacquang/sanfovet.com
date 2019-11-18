using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TaiKhoan_Ajax_TaiKhoan : System.Web.UI.Page
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
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
            case "XoaTaiKhoan":
                XoaTaiKhoan();
                break;
        }
    }

    private void XoaTaiKhoan()
    {
        string TenDangNhap = "";
        if (Request.Params["TenDangNhap"] != null)
            TenDangNhap = Request.Params["TenDangNhap"];

        if(TenDangNhap.ToLower() != "admin") // không cho xóa tài khoản admin
        {
            emdepvn.DangKy.Dangky_Delete(TenDangNhap);
            Response.Write("1");
        }
        else
        {
            Response.Write("Không được xóa tài khoản Admin");
        }

    }
}