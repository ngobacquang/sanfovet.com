using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyNhom_Nhom_ThemMoi : System.Web.UI.UserControl
{
    string thaotac = "";
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
        {
            LayThongTinNhom(id);
        }
    }

    private void LayThongTinNhom(string id)
    {
        if(thaotac == "ChinhSua")
        {
            resetControl();
            btThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuNhom.Visible = false;

            DataTable dt = new DataTable();
            dt = emdepvn.Nhom.Thongtin_Nhomsp_by_id(id);

            
            if (dt.Rows.Count > 0)
            {
                ltrAnhDaiDien.Text = "<img class='anhDaiDien' src='/pic/SanPham/" + dt.Rows[0]["AnhDaiDien"] + @"'/>";

                tbTenNhom.Text = dt.Rows[0]["TenNhom"].ToString();
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhDaiDien"].ToString();
                tbThuTu.Text = dt.Rows[0]["ThuTu"].ToString();
                tbSSPHT.Text = dt.Rows[0]["SoSPHienThi"].ToString();
            }

            
        }
        else
        {
            btThemMoi.Text = "Thêm mới";
            cbThemNhieuNhom.Visible = true;
        }
    }

    private void resetControl()
    {
        tbTenNhom.Text = "";
        tbThuTu.Text = "";
        tbSSPHT.Text = "";
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if(thaotac == "ThemMoi")
        {
            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/") + flAnhDaiDien.FileName);
                }
            }
            // code them moi
            emdepvn.Nhom.Nhomsanpham_Inser(tbTenNhom.Text, flAnhDaiDien.FileName, tbThuTu.Text, tbSSPHT.Text, "");
            ltrThongBao.Text = "<div class='thongBaoDaTaoThanhCong'>Đã tạo nhóm: " + tbTenNhom.Text + "</div>";

            if (cbThemNhieuNhom.Checked)
            {
                resetControl();
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=Nhom");
            }
        }
        else
        {
            // code sua
            string tenAnhDaiDien = "";
            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // cần có thêm đoạn code xóa ảnh cũ
                }
            }
            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            emdepvn.Nhom.Nhomsanpham_Update(id, tbTenNhom.Text, tenAnhDaiDien, tbThuTu.Text, tbSSPHT.Text);


            // day ve 
            Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=Nhom");
        }
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        resetControl();
    }
}