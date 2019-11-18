using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLySize_Size_ThemMoi : System.Web.UI.UserControl
{
    string thaotac = "";
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if(!IsPostBack)
        {
            HienThiThongTinSize();
        }
    }

    private void HienThiThongTinSize()
    {
        if(thaotac == "ChinhSua")
        {
            // viet chinh sua o day
            DataTable dt = new DataTable();
            dt = emdepvn.Size.Thongtin_Size_by_id(id);

            if (dt.Rows.Count > 0)
            {
                cbThemNhieuSize.Visible = false;
                tbTenSize.Text = dt.Rows[0]["TenSize"].ToString();
                hfSizeID.Value = dt.Rows[0]["SizeID"].ToString();
            }
        }
        else
        {
            // viet them moi o day
            tbTenSize.Text = "";
            cbThemNhieuSize.Visible = true;
        }
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if(thaotac == "ThemMoi")
        {
            // viet them moi o day
            emdepvn.Size.Size_Inser(tbTenSize.Text, "");

            if (cbThemNhieuSize.Checked)
                resetControl();
            else
                Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=Size");
        }
        else
        {
            // viet chinh sua o day 
            emdepvn.Size.Size_Update(hfSizeID.Value,tbTenSize.Text);
            Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=Size");
        }
    }

    private void resetControl()
    {
        tbTenSize.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        resetControl();
    }
}