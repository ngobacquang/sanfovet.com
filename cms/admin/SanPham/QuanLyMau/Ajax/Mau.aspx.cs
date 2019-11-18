using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyMau_Ajax_Mau : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // cần viết code kiểm tra đăng nhập ở đây
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
            case "XoaMau":
                XoaMau();
                break;
        }
    }

    private void XoaMau()
    {
        string MauID = "";
        if (Request.Params["MauID"] != null)
            MauID = Request.Params["MauID"];

        emdepvn.Mau.Mau_Delete(MauID);
        Response.Write("1");
    }
}