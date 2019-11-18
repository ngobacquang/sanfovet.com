using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyMau_MauLoadControl : System.Web.UI.UserControl
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        switch (thaotac)
        {
            case "HienThi":
                plMauLoadControl.Controls.Add(LoadControl("Mau_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                plMauLoadControl.Controls.Add(LoadControl("Mau_ThemMoi.ascx"));
                break;
            default :
                plMauLoadControl.Controls.Add(LoadControl("Mau_HienThi.ascx"));
                break;
        }
    }
}