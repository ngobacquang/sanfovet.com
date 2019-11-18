using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_display_SanPham_ChiTietSanPham : System.Web.UI.UserControl
{
    protected string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"].ToString();
        }
        if (!IsPostBack)
        {
            LayChiTietSanPham(id);
        }
    }

    private void LayChiTietSanPham(string id)
    {
        
        DataTable dt = new DataTable();
        dt = emdepvn.SanPham.Thongtin_Sanpham_by_id(id);

        if(dt.Rows.Count > 0)
        {
            ltrAnhSanPham.Text = "<img src='/pic/SanPham/" + dt.Rows[0]["AnhSP"] + @"' alt='" + dt.Rows[0]["TenSP"] + @"' class='imgsp' src='../pic/anhsp/ao-nu.jpg' />";
            ltrTenSanPham.Text = dt.Rows[0]["TenSP"].ToString();
            ltrGiaSanPham.Text = dt.Rows[0]["GiaSP"].ToString();

            ltrKichThuoc.Text = LayTenKichThuoc(dt.Rows[0]["SizeID"].ToString());
            ltrMau.Text = LayTenMau(dt.Rows[0]["MauID"].ToString());
            ltrChatLieu.Text = LayTenChatLieu(dt.Rows[0]["ChatLieuID"].ToString());

            ltrThongTinChiTiet.Text = dt.Rows[0]["MoTaSP"].ToString();
        }
    }

    private string LayTenKichThuoc(string SizeID)
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Size.Thongtin_Size_by_id(SizeID);

        if (dt.Rows.Count > 0)
            return dt.Rows[0]["TenSize"].ToString();
        else
            return "";
    }
    private string LayTenMau(string MauID)
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Mau.Thongtin_Mau_by_id(MauID);

        if (dt.Rows.Count > 0)
            return dt.Rows[0]["TenMau"].ToString();
        else
            return "";
    }
    private string LayTenChatLieu(string ChatLieuID)
    {
        DataTable dt = new DataTable();
        dt = emdepvn.ChatLieu.Thongtin_Chatlieu_by_id(ChatLieuID);

        if (dt.Rows.Count > 0)
            return dt.Rows[0]["TenChatLieu"].ToString();
        else
            return "";
    }
}