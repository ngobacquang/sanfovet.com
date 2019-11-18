using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySize_SizeLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        switch (thaotac)
        {
            case "HienThi":
                phSizeLoadControl.Controls.Add(LoadControl("Size_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                phSizeLoadControl.Controls.Add(LoadControl("Size_ThemMoi.ascx"));
                break;
            default :
                phSizeLoadControl.Controls.Add(LoadControl("Size_HienThi.ascx"));
                break;
        }
    }
}