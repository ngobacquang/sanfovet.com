using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_TinTuc_TinTucLoadControl : System.Web.UI.UserControl
{
    string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];

        switch (modulphu)
        {
            case "DanhSachTinTuc":
                phTinTucLoadControl.Controls.Add(LoadControl("DanhSachCacTinTuc.ascx"));
                break;
            case "ChiTietTinTuc":
                phTinTucLoadControl.Controls.Add(LoadControl("ChiTietTinTuc.ascx"));
                break;
            default:
                phTinTucLoadControl.Controls.Add(LoadControl("TrangChuModulTinTuc.ascx"));
                break;
        }
    }
}