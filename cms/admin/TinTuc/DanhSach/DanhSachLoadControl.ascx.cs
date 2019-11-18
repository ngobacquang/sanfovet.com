using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TinTuc_DanhSach_DanhSachLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        switch (thaotac)
        {
            case "HienThi":
                phDanhSach.Controls.Add(LoadControl("DanhSach_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                phDanhSach.Controls.Add(LoadControl("DanhSach_ThemMoi.ascx"));
                break;
            default:
                phDanhSach.Controls.Add(LoadControl("DanhSach_HienThi.ascx"));
                break;
        }
    }
}