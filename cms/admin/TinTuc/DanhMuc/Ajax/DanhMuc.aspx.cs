using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TinTuc_DanhMuc_Ajax_DanhMuc : System.Web.UI.Page
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // Kiểm tra đăng nhập
        if(Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {

        }
        else
        {
            return;
        }

        if(Request.Params["thaotac"] !=null)
            thaotac = Request.Params["thaotac"];
        switch (thaotac)
        {
            case "XoaDanhMuc":
                XoaDanhMuc();
                break;
        }
    }

    private void XoaDanhMuc()
    {
        string MaDM = "";
        if (Request.Params["MaDM"] != null)
            MaDM = Request.Params["MaDM"]; 

        emdepvn.DanhMucTin.Danhmuctin_Delete(MaDM);
        Response.Write("1");
    }
}