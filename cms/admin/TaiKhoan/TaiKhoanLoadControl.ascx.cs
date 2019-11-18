using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TaiKhoan_TaiKhoanLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        switch (thaotac)
        {
            case "HienThi":
                plTaiKhoanLoadControl.Controls.Add(LoadControl("TaiKhoan_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                plTaiKhoanLoadControl.Controls.Add(LoadControl("TaiKhoan_ThemMoi.ascx"));
                break;
            default:
                plTaiKhoanLoadControl.Controls.Add(LoadControl("TaiKhoan_HienThi.ascx"));
                break;
        }
    }
}