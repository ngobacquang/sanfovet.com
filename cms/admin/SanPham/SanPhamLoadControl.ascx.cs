using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_SanPhamLoadControl : System.Web.UI.UserControl
{

    private string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];

        switch (modulphu)
        {
            case "DanhMuc":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyDanhMuc/DanhMucLoadControl.ascx"));
                break;
            case "DanhSach":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyDanhSach/DanhSachLoadControl.ascx"));
                break;
            case "Mau":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyMau/MauLoadControl.ascx"));
                break;
            case "ChatLieu":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyChatLieu/ChatLieuLoadControl.ascx"));
                break;
            case "Size":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySize/SizeLoadControl.ascx"));
                break;
            case "Nhom":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyNhom/NhomLoadControl.ascx"));
                break;
            default:
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyDanhSach/DanhSachLoadControl.ascx"));
                break;
        }
        
    }
}