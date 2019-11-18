using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySanPham_SanPhamLoadControl : System.Web.UI.UserControl
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            case "HienThi":
                plDanhSachLoadControl.Controls.Add(LoadControl("DanhSach_HienThi.ascx"));
                break;
            case "ThemMoi":
            case "ChinhSua":
                plDanhSachLoadControl.Controls.Add(LoadControl("DanhSach_ThemMoi.ascx"));
                break;
            default :
                plDanhSachLoadControl.Controls.Add(LoadControl("DanhSach_HienThi.ascx"));
                break;
        }

    }
}