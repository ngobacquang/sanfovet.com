using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_SanPham_SanPhamLoadControl : System.Web.UI.UserControl
{
    string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];

        switch (modulphu)
        {
            case "DanhSachSanPham":
                phSanPhamLoadControl.Controls.Add(LoadControl("DanhSachCacSanPham.ascx"));
                break;
            case "ChiTietSanPham":
                phSanPhamLoadControl.Controls.Add(LoadControl("ChiTietSanPham.ascx"));
                break;
            case "GioHang":
                phSanPhamLoadControl.Controls.Add(LoadControl("GioHang.ascx"));
                break;
            default:
                phSanPhamLoadControl.Controls.Add(LoadControl("TrangChuModulSanPham.ascx"));
                break;
        }
    }
}