using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class cms_admin_QuangCao_DanhSach_DanhSach_ThemMoi : System.Web.UI.UserControl
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

            LayNhomQC();
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
            dt = emdepvn.QuangCao.Thongtin_Quangcao_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ddlNhomQC.SelectedValue = dt.Rows[0]["NhomQuangCaoID"].ToString();
                tbTenQC.Text = dt.Rows[0]["TenQC"].ToString();
                // ảnh
                ltrAnhDaiDien.Text = "<img class='anhDaiDien' src='/pic/QuangCao/" + dt.Rows[0]["AnhQC"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhQC"].ToString();
                tbLienKet.Text = dt.Rows[0]["LienKet"].ToString();
                tbThuTu.Text = dt.Rows[0]["ThuTuQC"].ToString();
            }
        }
        else
        {
            btThemMoi.Text = "Thêm mới";
            cbThemNhieu.Visible = true;
            
        }
    }


    #region Lấy ra LayNhomQC
    private void LayNhomQC()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.NhomQuangCao.Thongtin_Nhomquangcao();

        ddlNhomQC.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlNhomQC.Items.Add(new ListItem(dt.Rows[i]["TenNhomQuangCao"].ToString(), dt.Rows[i]["NhomQuangCaoID"].ToString()));
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/QuangCao/") + flAnhDaiDien.FileName);
                }
            }

            emdepvn.QuangCao.Quangcao_Inser(tbTenQC.Text, "", flAnhDaiDien.FileName, tbLienKet.Text, tbThuTu.Text, ddlNhomQC.SelectedValue, "");


            ltrThongBao.Text = "<div class='thongBaoDaTaoThanhCong'>Đã tạo sản phẩm: " + tbTenQC.Text + "</div>";

            if (cbThemNhieu.Checked)
            {
                // Xóa các textBox 
                ResetControl();
            }
            else
            {
                // day ve 
                Response.Redirect("/Admin.aspx?modul=QuangCao&modulphu=DanhSach");
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/QuangCao/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // cần có thêm đoạn code xóa ảnh cũ
                }
            }
            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            emdepvn.QuangCao.Quangcao_Update(id, tbTenQC.Text, "", tenAnhDaiDien, tbLienKet.Text, tbThuTu.Text, ddlNhomQC.SelectedValue);


            // day ve 
            Response.Redirect("/Admin.aspx?modul=QuangCao&modulphu=DanhSach");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbLienKet.Text = "";
        tbTenQC.Text = "";
        tbThuTu.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}