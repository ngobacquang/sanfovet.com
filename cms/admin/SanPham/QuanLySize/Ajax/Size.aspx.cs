using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySize_Ajax_Size : System.Web.UI.Page
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

        if (Request.Params["ThaoTac"] != null)
            thaotac = Request.Params["ThaoTac"];

        switch (thaotac)
        {
            case "XoaSize":
                XoaSize();
                break;
        }
    }

    private void XoaSize()
    {
        string SizeID = "";
        if(Request.Params["SizeID"] !=null)
            SizeID = Request.Params["SizeID"];

        emdepvn.Size.Size_Delete(SizeID);

        Response.Write("1");
    }
}