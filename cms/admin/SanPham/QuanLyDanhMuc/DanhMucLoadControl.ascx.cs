using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_DanhMucLoadControl : System.Web.UI.UserControl
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        switch (thaotac)
        {
            case "HienThi":
                plDanhMucLoadControl.Controls.Add(LoadControl("DanhMuc_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                plDanhMucLoadControl.Controls.Add(LoadControl("DanhMuc_ThemMoi.ascx"));
                break;
            default:
                plDanhMucLoadControl.Controls.Add(LoadControl("DanhMuc_HienThi.ascx"));
                break;
        }
    }
}