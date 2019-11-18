using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_Menu_MenuLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["thaotac"] != null)
        {
            thaotac = Request.QueryString["thaotac"].ToString();
        }

        switch (thaotac)
        {
            case "HienThi":
                phMenuLoadControl.Controls.Add(LoadControl("Menu_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                phMenuLoadControl.Controls.Add(LoadControl("Menu_ThemMoi.ascx"));
                break;
            default:
                phMenuLoadControl.Controls.Add(LoadControl("Menu_HienThi.ascx"));
                break;
        }
    }
}