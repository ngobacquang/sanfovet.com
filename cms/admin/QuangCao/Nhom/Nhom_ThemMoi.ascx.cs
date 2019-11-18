using System;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_QuangCao_Nhom_Nhom_ThemMoi : System.Web.UI.UserControl
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


            //LayViTri();

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
            dt = emdepvn.NhomQuangCao.thongtin_nhomquangcao_by_id(id);
            if (dt.Rows.Count > 0)
            {
                tbTenNhom.Text = dt.Rows[0]["TenNhomQuangCao"].ToString();
                tbViTri.Text = dt.Rows[0]["ViTriQC"].ToString();
                tbThuTu.Text = dt.Rows[0]["ThuTuNhomQC"].ToString();

                ltrAnhDaiDien.Text = "<img class='anhDaiDien' src='/pic/QuangCao/" + dt.Rows[0]["AnhDaiDienQC"] + @"'/>";

                hfAnhDaiDienCu.Value = dt.Rows[0]["AnhDaiDienQC"].ToString();
            }
        }
        else
        {
            btThemMoi.Text = "Thêm mới";
            cbThemNhieu.Visible = true;
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/QuangCao/") + flAnhDaiDien.FileName);
                }
            }

            emdepvn.NhomQuangCao.Nhomquangcao_Inser(tbTenNhom.Text, tbViTri.Text, tbThuTu.Text, flAnhDaiDien.FileName, "");
            ltrThongBao.Text = "<div class='thongBaoDaTaoThanhCong'>Đã tạo Nhóm: " + tbTenNhom.Text + "</div>";

            if (cbThemNhieu.Checked)
            {
                // Xóa các textBox 
                ResetControl();
            }
            else
            {
                // day ve 
                Response.Redirect("/Admin.aspx?modul=QuangCao&modulphu=Nhom");
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
                tenAnhDaiDien = hfAnhDaiDienCu.Value;
            }

            emdepvn.NhomQuangCao.Nhomquangcao_Update(id, tbTenNhom.Text, tbViTri.Text, tbThuTu.Text, tenAnhDaiDien);


            // day ve 
            Response.Redirect("/Admin.aspx?modul=QuangCao&modulphu=Nhom");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTenNhom.Text = "";
        tbThuTu.Text = "";
        tbViTri.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}