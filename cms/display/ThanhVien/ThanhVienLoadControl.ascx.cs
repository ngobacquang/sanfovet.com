using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_ThanhVien_ThanhVienLoadControl : System.Web.UI.UserControl
{
    string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];

        switch (modulphu)
        {
            case "DangKy":
                phThanhVienLoadControl.Controls.Add(LoadControl("DangKy.ascx"));
                break;
            case "DangNhap":
                phThanhVienLoadControl.Controls.Add(LoadControl("DangNhap.ascx"));
                break;
            default:
                phThanhVienLoadControl.Controls.Add(LoadControl("DangNhap.ascx"));
                break;
        }
    }
}