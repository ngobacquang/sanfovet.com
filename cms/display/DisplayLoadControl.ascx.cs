using System;

public partial class cms_display_DisplayLoadControl : System.Web.UI.UserControl
{
    private string modul = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"];

        switch (modul)
        {
            case "SanPham":
                phDisplayLoadControl.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                break;
            case "ThanhVien":
                phDisplayLoadControl.Controls.Add(LoadControl("ThanhVien/ThanhVienLoadControl.ascx"));
                break;
            case "TinTuc":
                phDisplayLoadControl.Controls.Add(LoadControl("TinTuc/TinTucLoadControl.ascx"));
                break;
            case "TrangChu":
                phDisplayLoadControl.Controls.Add(LoadControl("TrangChu/TrangChuLoadControl.ascx"));
                break;
            default:
                phDisplayLoadControl.Controls.Add(LoadControl("TrangChu/TrangChuLoadControl.ascx"));
                break;
        }

    }
}