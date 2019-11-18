using System;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_TinTuc_DanhMuc_DanhMuc_ThemMoi : System.Web.UI.UserControl
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
            cbThemNhieuDanhMuc.Visible = false;

            DataTable dt = new DataTable();
            dt = emdepvn.DanhMucTin.thongtin_danhmuctin_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ddlDanhMucCha.SelectedValue = dt.Rows[0]["MaDMCha"].ToString();
                tbTenDanhMuc.Text = dt.Rows[0]["TenDM"].ToString();
                tbThuTu.Text = dt.Rows[0]["ThuTu"].ToString();

                ltrAnhDaiDien.Text = "<img class='anhDaiDien' src='/pic/TinTuc/" + dt.Rows[0]["AnhDaiDien"] + @"'/>";

                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhDaiDien"].ToString();
            }
        }
        else
        {
            btThemMoi.Text = "Thêm mới";
            cbThemNhieuDanhMuc.Visible = true;
        }
    }

    private void LayDanhMucCha()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMucTin.thongtin_danhmuctin_by_MaDMCha("0");

        ddlDanhMucCha.Items.Clear();

        ddlDanhMucCha.Items.Add(new ListItem("Danh mục gốc", "0"));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
            LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), "___");
        }
    }

    private void LayDanhMucCon(string MaDMCha, string khoangCach)
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMucTin.thongtin_danhmuctin_by_MaDMCha(MaDMCha);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(khoangCach + dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
            LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), khoangCach + "___");
        }
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region Code nút thêm mới
            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/TinTuc/") + flAnhDaiDien.FileName);
                }
            }

            emdepvn.DanhMucTin.Danhmuctin_Inser(tbTenDanhMuc.Text, flAnhDaiDien.FileName, tbThuTu.Text, ddlDanhMucCha.SelectedValue, "");
            ltrThongBao.Text = "<div class='thongBaoDaTaoThanhCong'>Đã tạo danh mục: " + tbTenDanhMuc.Text + "</div>";

            if (cbThemNhieuDanhMuc.Checked)
            {
                // Xóa các textBox 
                ResetControl();
            }
            else
            {
                // day ve 
                Response.Redirect("/Admin.aspx?modul=TinTuc&modulphu=DanhMuc");
            }
            #endregion
        }
        else
        {
            #region Code nút chỉnh sửa
            string tenAnhDaiDien = "";
            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/TinTuc/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // cần có thêm đoạn code xóa ảnh cũ
                }
            }
            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            emdepvn.DanhMucTin.Danhmuctin_Update(id, tbTenDanhMuc.Text, tenAnhDaiDien, tbThuTu.Text, ddlDanhMucCha.SelectedValue);


            // day ve 
            Response.Redirect("/Admin.aspx?modul=TinTuc&modulphu=DanhMuc");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTenDanhMuc.Text = "";
        tbThuTu.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}