using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TinTuc_TinTucLoadControl : System.Web.UI.UserControl
{
    string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"].ToString();
        switch (modulphu)
        {
            case "DanhMuc":
                plTinTucControl.Controls.Add(LoadControl("DanhMuc/DanhMucLoadControl.ascx"));
                break;
            case "DanhSach":
                plTinTucControl.Controls.Add(LoadControl("DanhSach/DanhSachLoadControl.ascx"));
                break;
            default:
                plTinTucControl.Controls.Add(LoadControl("DanhSach/DanhSachLoadControl.ascx"));
                break;
        }
    }
}