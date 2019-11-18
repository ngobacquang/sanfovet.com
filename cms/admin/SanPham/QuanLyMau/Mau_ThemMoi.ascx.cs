using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyMau_Mau_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
        {
            HienThiThongTin(id);
        }

    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "ChinhSua")
        {
            btThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuMau.Visible = false;

            DataTable dt = new DataTable();
            dt = emdepvn.Mau.Thongtin_Mau_by_id(id);
            if (dt.Rows.Count > 0)
            {
                tbMauID.Text = dt.Rows[0]["MauID"].ToString();
                tbTenMau.Text = dt.Rows[0]["TenMau"].ToString();
                tbMauID.Enabled = false;
            }

        }
        else if (thaotac == "ThemMoi")
        {
            tbMauID.Enabled = false;
            btThemMoi.Text = "Thêm mới";
            cbThemNhieuMau.Visible = true;
        }
    }


    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        //code Thêm mới ở đây
        if(thaotac == "ThemMoi")
        {
            #region code Thêm mới ở đây
            emdepvn.Mau.Mau_Inser(tbTenMau.Text, "");
            if (cbThemNhieuMau.Checked)
                //nếu nút thêm nhiều được check thì reset lại các control
                reSetControl();
            else
                // nếu nút thêm nhiều không được check thì đẩy về trang phụ màu
                Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=Mau");
            #endregion
        }
        //code Chỉnh sửa tại đây
        else if(thaotac == "ChinhSua")
        {
            #region Code Sửa tại đây
            emdepvn.Mau.Mau_Update(tbMauID.Text, tbTenMau.Text);
            Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=Mau");
            #endregion
        }
    }

    private void reSetControl()
    {
        tbTenMau.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        reSetControl();
    }
}