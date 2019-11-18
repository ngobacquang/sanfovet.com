using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_QuangCao_DanhSach_DanhSachLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"].ToString();

        switch (thaotac)
        {
            case "HienThi":
                phDanhSachLoadControl.Controls.Add(LoadControl("DanhSach_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                phDanhSachLoadControl.Controls.Add(LoadControl("DanhSach_ThemMoi.ascx"));
                break;
            default:
                phDanhSachLoadControl.Controls.Add(LoadControl("DanhSach_HienThi.ascx"));
                break;
        }
    }
}