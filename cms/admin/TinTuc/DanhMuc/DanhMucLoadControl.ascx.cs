using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TinTuc_DanhMuc_DanhMucLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"].ToString();

        switch (thaotac)
        {
            case "HienThi":
                phDanhMuc.Controls.Add(LoadControl("DanhMuc_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                phDanhMuc.Controls.Add(LoadControl("DanhMuc_ThemMoi.ascx"));
                break;
            default:
                phDanhMuc.Controls.Add(LoadControl("DanhMuc_HienThi.ascx"));
                break;
        }
    }
}