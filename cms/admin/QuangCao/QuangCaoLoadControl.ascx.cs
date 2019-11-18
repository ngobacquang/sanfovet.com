using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_QuangCao_QuangCaoLoadControl : System.Web.UI.UserControl
{
    string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["modulphu"] != null)
        {
            modulphu = Request.QueryString["modulphu"].ToString();
        }
        switch (modulphu)
        {
            case "DanhSach":
                phQuangCaoLoadControl.Controls.Add(LoadControl("DanhSach/DanhSachLoadControl.ascx"));
                break;
            case "Nhom":
                phQuangCaoLoadControl.Controls.Add(LoadControl("Nhom/NhomLoadControl.ascx"));
                break;
            default:
                phQuangCaoLoadControl.Controls.Add(LoadControl("DanhSach/DanhSachLoadControl.ascx"));
                break;
        }
    }
}