using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class cms_admin_Menu_Menu_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = ""; // lấy id danh mục cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
        {
            thaotac = Request.QueryString["thaotac"];
        }
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"];
        }

        if (!IsPostBack)
        {
            LayDanhMucCha();

            HienThiThongTin(id);
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "ChinhSua")
        {

            btThemMoi.Text = "Chỉnh sửa";
            cbThemNhieu.Visible = false;

            DataTable dt = new DataTable();
            dt = emdepvn.Menu.Thongtin_Menu_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ddlMenuCha.SelectedValue = dt.Rows[0]["MaMenuCha"].ToString();
                tbTenMenu.Text = dt.Rows[0]["TenMenu"].ToString();
                tbLienKet.Text = dt.Rows[0]["LienKet"].ToString();
                tbThuTu.Text = dt.Rows[0]["ThuTuMenu"].ToString();
                
            }
        }
        else
        {
            btThemMoi.Text = "Thêm mới";
            cbThemNhieu.Visible = true;
        }
    }

    private void LayDanhMucCha()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Menu.Thongtin_Menu_by_mamenucha("0");

        ddlMenuCha.Items.Clear();

        ddlMenuCha.Items.Add(new ListItem("Menu gốc", "0"));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlMenuCha.Items.Add(new ListItem(dt.Rows[i]["TenMenu"].ToString(), dt.Rows[i]["MaMenu"].ToString()));
            LayDanhMucCon(dt.Rows[i]["MaMenu"].ToString(), "___");
        }
    }

    private void LayDanhMucCon(string MaMenuCha, string khoangCach)
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Menu.Thongtin_Menu_by_mamenucha(MaMenuCha);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlMenuCha.Items.Add(new ListItem(khoangCach + dt.Rows[i]["TenMenu"].ToString(), dt.Rows[i]["MaMenu"].ToString()));
            LayDanhMucCon(dt.Rows[i]["MaMenu"].ToString(), khoangCach + "___");
        }
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region Code nút thêm mới

            emdepvn.Menu.Menu_Inser(tbTenMenu.Text,tbLienKet.Text, ddlMenuCha.SelectedValue, tbThuTu.Text, "");
            ltrThongBao.Text = "<div class='thongBaoDaTaoThanhCong'>Đã tạo menu: " + tbTenMenu.Text + "</div>";

            if (cbThemNhieu.Checked)
            {
                // Xóa các textBox 
                ResetControl();
            }
            else
            {
                // day ve 
                Response.Redirect("/Admin.aspx?modul=Menu");
            }
            #endregion
        }
        else
        {
            #region Code nút chỉnh sửa

            emdepvn.Menu.Menu_Update(id, tbTenMenu.Text, tbLienKet.Text, ddlMenuCha.SelectedValue, tbThuTu.Text);

            // day ve 
            Response.Redirect("/Admin.aspx?modul=Menu");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbLienKet.Text = "";
        tbThuTu.Text = "";
        tbTenMenu.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}