using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyNhom_NhomLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            case "HienThi":
                phNhomLoadControl.Controls.Add(LoadControl("Nhom_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                phNhomLoadControl.Controls.Add(LoadControl("Nhom_ThemMoi.ascx"));
                break;
            default :
                phNhomLoadControl.Controls.Add(LoadControl("Nhom_HienThi.ascx"));
                break;
        }
    }
}