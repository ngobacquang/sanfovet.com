using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class cms_admin_TinTuc_DanhSach_DanhSach_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = ""; // lấy id sản phẩm cần chỉnh sửa
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
            cbThemNhieuTinTuc.Visible = false;

            DataTable dt = new DataTable();
            dt = emdepvn.TinTuc.Thongtin_Tintuc_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ddlDanhMucCha.SelectedValue = dt.Rows[0]["MaDM"].ToString();
                tbTieuDe.Text = dt.Rows[0]["TieuDe"].ToString();
                // ảnh
                ltrAnhDaiDien.Text = "<img class='anhDaiDien' src='/pic/TinTuc/" + dt.Rows[0]["AnhDaiDien"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhDaiDien"].ToString();
                tbNgayDang.Text = dt.Rows[0]["MoTa"].ToString();
                tbMoTa.Text = dt.Rows[0]["MoTa"].ToString();
                tbNgayDang.Text = dt.Rows[0]["NgayDang"].ToString();
                tbLuotXem.Text = dt.Rows[0]["LuotXem"].ToString();
                tbThuTu.Text = dt.Rows[0]["ThuTu"].ToString();
                tbChiTiet.Text = dt.Rows[0]["ChiTiet"].ToString();
            }
        }
        else
        {
            btThemMoi.Text = "Thêm mới";
            cbThemNhieuTinTuc.Visible = true;

            tbNgayDang.Text = DateTime.Now.ToString("MM/dd/yyy hh:mm:ss tt");
        }
    }
    

    #region Lấy ra Danh mục
    private void LayDanhMucCha()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMucTin.thongtin_danhmuctin_by_MaDMCha("0");

        ddlDanhMucCha.Items.Clear();

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
    #endregion

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

            emdepvn.TinTuc.Tintuc_Inser(tbTieuDe.Text, flAnhDaiDien.FileName, tbMoTa.Text, tbNgayDang.Text, tbLuotXem.Text, tbChiTiet.Text, tbThuTu.Text, ddlDanhMucCha.SelectedValue);


            ltrThongBao.Text = "<div class='thongBaoDaTaoThanhCong'>Đã tạo sản phẩm: " + tbTieuDe.Text + "</div>";

            if (cbThemNhieuTinTuc.Checked)
            {
                // Xóa các textBox 
                ResetControl();
            }
            else
            {
                // day ve 
                Response.Redirect("/Admin.aspx?modul=TinTuc&modulphu=DanhSach");
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

            emdepvn.TinTuc.Tintuc_Update(id, tbTieuDe.Text, tenAnhDaiDien, tbMoTa.Text, tbNgayDang.Text, tbLuotXem.Text,tbChiTiet.Text, tbThuTu.Text, ddlDanhMucCha.SelectedValue);


            // day ve 
            Response.Redirect("/Admin.aspx?modul=TinTuc&modulphu=DanhSach");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbChiTiet.Text = "";
        tbLuotXem.Text = "";
        tbThuTu.Text = "";
        tbTieuDe.Text = "";

        tbNgayDang.Text = DateTime.Now.ToString("MM/dd/yyy hh:mm:ss tt");
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}