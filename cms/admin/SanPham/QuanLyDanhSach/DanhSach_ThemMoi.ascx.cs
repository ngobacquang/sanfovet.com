using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class cms_admin_SanPham_QuanLySanPham_SanPham_ThemMoi : System.Web.UI.UserControl
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
            LayMau();
            LaySize();
            LayChatLieu();
            LayNhom();

            HienThiThongTin(id);
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "ChinhSua")
        {

            btThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuSanPham.Visible = false;

            DataTable dt = new DataTable();
            dt = emdepvn.SanPham.Thongtin_Sanpham_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ddlDanhMucCha.SelectedValue = dt.Rows[0]["MaDM"].ToString();
                tbTenSanPham.Text = dt.Rows[0]["TenSp"].ToString();
                // ảnh
                ltrAnhDaiDien.Text = "<img class='anhDaiDien' src='/pic/SanPham/" + dt.Rows[0]["AnhSP"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhSP"].ToString();
                tbSoLuong.Text = dt.Rows[0]["SoLuongSP"].ToString();
                tbGiaBan.Text = dt.Rows[0]["GiaSP"].ToString();
                tbNgayTao.Text = dt.Rows[0]["NgayTao"].ToString();
                tbNgayHuy.Text = dt.Rows[0]["NgayHuy"].ToString();
                tbMoTa.Text = dt.Rows[0]["MoTaSP"].ToString();

                ddlMau.SelectedValue = dt.Rows[0]["MauID"].ToString();
                ddlSize.SelectedValue = dt.Rows[0]["SizeID"].ToString();
                ddlChatLieu.SelectedValue = dt.Rows[0]["ChatLieuID"].ToString();
                ddlNhom.SelectedValue = dt.Rows[0]["NhomID"].ToString();

            }
        }
        else
        {
            btThemMoi.Text = "Thêm mới";
            cbThemNhieuSanPham.Visible = true;

            tbNgayTao.Text = DateTime.Now.ToString("MM/dd/yyy hh:mm:ss tt");
            tbNgayHuy.Text = DateTime.Now.ToString("MM/dd/yyy hh:mm:ss tt");
        }
    }
    #region Lấy màu, size, nhóm, chất liệu
    // Lấy màu
    private void LayMau()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Mau.Thongtin_Mau();

        ddlMau.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlMau.Items.Add(new ListItem(dt.Rows[i]["TenMau"].ToString(), dt.Rows[i]["MauID"].ToString()));
        }
    }
    // Lấy Size
    private void LaySize()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Size.thongtin_size();

        ddlSize.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlSize.Items.Add(new ListItem(dt.Rows[i]["TenSize"].ToString(), dt.Rows[i]["SizeID"].ToString()));
        }
    }
    // Lấy chất liệu
    private void LayChatLieu()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.ChatLieu.thongtin_chatlieu();

        ddlChatLieu.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlChatLieu.Items.Add(new ListItem(dt.Rows[i]["TenChatLieu"].ToString(), dt.Rows[i]["ChatLieuID"].ToString()));
        }
    }
    // Lấy Nhóm
    private void LayNhom()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Nhom.Thongtin_Nhomsp();

        ddlNhom.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlNhom.Items.Add(new ListItem(dt.Rows[i]["TenNhom"].ToString(), dt.Rows[i]["NhomID"].ToString()));
        }
    }
    #endregion

    #region Lấy ra Danh mục
    private void LayDanhMucCha()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc_by_MaDMCha("0");

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
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc_by_MaDMCha(MaDMCha);
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/") + flAnhDaiDien.FileName);
                }
            }

            emdepvn.SanPham.Sanpham_Inser(tbTenSanPham.Text, ddlMau.SelectedValue, ddlSize.SelectedValue, ddlChatLieu.SelectedValue, flAnhDaiDien.FileName, tbSoLuong.Text, tbGiaBan.Text, tbMoTa.Text, tbNgayTao.Text, tbNgayHuy.Text, ddlDanhMucCha.SelectedValue, ddlNhom.SelectedValue, "");

            
            ltrThongBao.Text = "<div class='thongBaoDaTaoThanhCong'>Đã tạo sản phẩm: " + tbTenSanPham.Text + "</div>";

            if (cbThemNhieuSanPham.Checked)
            {
                // Xóa các textBox 
                ResetControl();
            }
            else
            {
                // day ve 
                Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=DanhSach");
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // cần có thêm đoạn code xóa ảnh cũ
                }
            }
            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            emdepvn.SanPham.Sanpham_Update(id,tbTenSanPham.Text,ddlMau.SelectedValue, ddlSize.SelectedValue, ddlChatLieu.SelectedValue, tenAnhDaiDien, tbSoLuong.Text, tbGiaBan.Text, tbMoTa.Text, tbNgayTao.Text, tbNgayHuy.Text, ddlDanhMucCha.SelectedValue, ddlNhom.SelectedValue);


            // day ve 
            Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=DanhSach");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTenSanPham.Text = "";
        tbSoLuong.Text = "";
        tbGiaBan.Text = "";
        tbMoTa.Text = "";

        tbNgayTao.Text = DateTime.Now.ToString("MM/dd/yyy hh:mm:ss tt");
        tbNgayHuy.Text = DateTime.Now.ToString("MM/dd/yyy hh:mm:ss tt");
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}