using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyChatLieu_Ajax_ChatLieu : System.Web.UI.Page
{
    private string thaotac = "";
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
            case "XoaChatLieu":
                XoaChatLieu();
                break;
        }
    }

    private void XoaChatLieu()
    {
        string ChatLieuID = "";
        if(Request.Params["ChatLieuID"] != null)
            ChatLieuID = Request.Params["ChatLieuID"];

        emdepvn.ChatLieu.Chatlieu_Delete(ChatLieuID);
        Response.Write("1");
    }
}