using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TinTuc_DanhSach_Ajax_DanhSach : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
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
            case "XoaDanhSach":
                XoaDanhSach();
                break;
        }
    }
    private void XoaDanhSach()
    {
        string TinTucID = "";
        if (Request.Params["TinTucID"] != null)
            TinTucID = Request.Params["TinTucID"];

        //B1: Xóa ảnh đại diện đã lưu trên server

        //B1: Xóa dữ liệu trong server
        emdepvn.TinTuc.Tintuc_Delete(TinTucID);
        Response.Write("1");
    }
}