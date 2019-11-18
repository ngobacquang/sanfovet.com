using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_Menu_Ajax_Menu : System.Web.UI.Page
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // Kiem tra xem da dang nhap hay chua
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {
            // da dang nhap
        }
        else
        {
            // neu chua dang nhap thi chuyen den dang nhap
            return;
        }

        if(Request.Params["ThaoTac"] != null)
        {
            thaotac = Request.Params["ThaoTac"].ToString();
        }
        switch (thaotac)
        {
            case "XoaMenu":
                XoaMenu();
                break;
        }
    }

    private void XoaMenu()
    {
        string MaMenu = "";
        if(Request.Params["MaMenu"] != null)
        {
            MaMenu = Request.Params["MaMenu"].ToString();

            emdepvn.Menu.Menu_Delete(MaMenu);
            Response.Write("1");
        }
    }
}