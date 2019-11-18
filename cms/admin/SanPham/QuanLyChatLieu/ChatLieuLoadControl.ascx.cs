using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyChatLieu_ChatLieuLoadControl : System.Web.UI.UserControl
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        switch (thaotac)
        {
            case "HienThi":
                plChatLieuLoadControl.Controls.Add(LoadControl("ChatLieu_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                plChatLieuLoadControl.Controls.Add(LoadControl("ChatLieu_ThemMoi.ascx"));
                break;
            default :
                plChatLieuLoadControl.Controls.Add(LoadControl("ChatLieu_HienThi.ascx"));
                break;
        }

    }
}