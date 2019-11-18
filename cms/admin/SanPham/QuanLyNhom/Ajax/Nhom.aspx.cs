using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyNhom_Ajax_Nhom : System.Web.UI.Page
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

        if (Request.Params["Thaotac"] != null)
            thaotac = Request.Params["Thaotac"];

        switch (thaotac)
        {
            case "XoaNhom":
                XoaNhom();
                break;
        }
    }

    private void XoaNhom()
    {
        string NhomID = "";
        if (Request.Params["NhomID"] != null)
            NhomID = Request.Params["NhomID"];
        emdepvn.Nhom.Nhomsanpham_Delete(NhomID);
        Response.Write("1");
    }
}