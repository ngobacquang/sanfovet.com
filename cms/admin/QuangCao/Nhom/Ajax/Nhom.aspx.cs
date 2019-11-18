using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_QuangCao_Nhom_Ajax_Nhom : System.Web.UI.Page
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // Kiểm tra đăng nhập
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {

        }
        else
        {
            return;
        }

        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];
        switch (thaotac)
        {
            case "XoaNhom":
                XoaNhom();
                break;
        }
    }
    private void XoaNhom()
    {
        string NhomQuangCaoID = "";
        if (Request.Params["NhomQuangCaoID"] != null)
            NhomQuangCaoID = Request.Params["NhomQuangCaoID"];

        emdepvn.NhomQuangCao.Nhomquangcao_Delete(NhomQuangCaoID);
        Response.Write("1");
    }
}