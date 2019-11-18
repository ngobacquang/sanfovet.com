using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Kiem tra xem da dang nhap hay chua
        if(Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {
            // da dang nhap
        }
        else
        {
            // neu chua dang nhap thi chuyen den dang nhap
            Response.Redirect("/Login.aspx");
        }

        if (!IsPostBack)
        {
            ltrTenDangNhap.Text = Session["TenDangNhap"].ToString();
        }

    }

    protected void lbtDangXuat_Click(object sender, EventArgs e)
    {
        // Xoa cac Session da luu va day ve trang login
        Session["DangNhap"] = null;
        Session["TenDangNhap"] = null;

        Response.Redirect("/Login.aspx");
    }
}