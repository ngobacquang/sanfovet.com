using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyChatLieu_ChatLieu_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
        {
            thaotac = Request.QueryString["thaotac"];
        }
        if(Request.QueryString["id"] != null) {
            id = Request.QueryString["id"];
        }

        if (!IsPostBack)
        {
            LayThongTinChatLieu();
        }

    }

    private void LayThongTinChatLieu()
    {
        if(thaotac == "ThemMoi")
        {
            btThemMoi.Text = "Thêm mới";
            cbThemNhieuChatLieu.Visible = true;
        }
        else if(thaotac == "ChinhSua")
        {
            btThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuChatLieu.Visible = false;

            DataTable dt = new DataTable();
            dt = emdepvn.ChatLieu.Thongtin_Chatlieu_by_id(id);

            hdfChatLieuID.Value = dt.Rows[0]["ChatLieuID"].ToString();
            tbTenChatLieu.Text = dt.Rows[0]["TenChatLieu"].ToString();
                        
        }
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if(thaotac == "ThemMoi")
        {
            emdepvn.ChatLieu.Chatlieu_Inser(tbTenChatLieu.Text, "");
            if (cbThemNhieuChatLieu.Checked)
                resetControl();
            else
                Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=ChatLieu");
        }
        else if(thaotac == "ChinhSua")
        {
            emdepvn.ChatLieu.Chatlieu_Update(hdfChatLieuID.Value, tbTenChatLieu.Text);
            Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=ChatLieu");
        }
    }

    private void resetControl()
    {
        tbTenChatLieu.Text = "";
        hdfChatLieuID.Value = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        resetControl();
    }
}