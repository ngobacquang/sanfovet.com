using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class cms_admin_TaiKhoan_TaiKhoan_ThemMoi : System.Web.UI.UserControl
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


            LayQuyenDangNhap();

            HienThiThongTin(id);
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "ChinhSua")
        {

            btDangKy.Text = "Chỉnh sửa";
            //cbThemNhieuDanhMuc.Visible = false;
            tbTenDangNhap.Enabled = false;

            DataTable dt = new DataTable();
            dt = emdepvn.DangKy.Thongtin_Dangky_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ddlQuyenDangNhap.SelectedValue = dt.Rows[0]["MaQuyen"].ToString();
                tbTenDangNhap.Text = dt.Rows[0]["TenDangNhap"].ToString();
                tbEmail.Text = dt.Rows[0]["EmailDK"].ToString();
                tbDiaChi.Text = dt.Rows[0]["DiaChiDK"].ToString();
                tbTenDayDu.Text = dt.Rows[0]["TenDayDu"].ToString();
                tbNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                ddlGioiTinh.SelectedValue = dt.Rows[0]["GioiTinhDK"].ToString();
                hfMatKhauCu.Value = dt.Rows[0]["MatKhau"].ToString();
            }
        }
        else
        {
            btDangKy.Text = "Đăng ký";
            
        }
    }

    private void LayQuyenDangNhap()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.QuyenDangNhap.Thongtin_Quyendangnhap();

        ddlQuyenDangNhap.Items.Clear();
        
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlQuyenDangNhap.Items.Add(new ListItem(dt.Rows[i]["TenQuyen"].ToString(), dt.Rows[i]["MaQuyen"].ToString()));
        }
    }

    protected void btDangKy_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region Code nút thêm mới
            // Mã hóa mật khẩu trước khi thêm vào Database
            string matkhau = emdepvn.MaHoa.MaHoaMD5(tbMatKhau.Text);

            emdepvn.DangKy.Dangky_Inser(tbTenDangNhap.Text, matkhau, tbEmail.Text, tbDiaChi.Text, tbTenDayDu.Text,"", tbNgaySinh.Text, ddlGioiTinh.SelectedValue, ddlQuyenDangNhap.SelectedValue, "");
            ltrThongBao.Text = "<div class='thongBaoDaTaoThanhCong'>Đã tạo tài khoản: " + tbTenDangNhap.Text + "</div>";
            
            // day ve 
            Response.Redirect("/Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan");
            #endregion
        }
        else
        {
            #region Code nút chỉnh sửa
            // Mã hóa mật khẩu trước khi thêm vào Database
            string matkhau = "";
            if(tbMatKhau.Text != "")
                matkhau = emdepvn.MaHoa.MaHoaMD5(tbMatKhau.Text);
            else
                matkhau = emdepvn.MaHoa.MaHoaMD5(hfMatKhauCu.Value);

            emdepvn.DangKy.Dangky_Update(id,matkhau,tbEmail.Text, tbDiaChi.Text, tbTenDayDu.Text,"", tbNgaySinh.Text, ddlGioiTinh.SelectedValue, ddlQuyenDangNhap.SelectedValue);


            // day ve 
            Response.Redirect("/Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTenDangNhap.Text = "";
        tbEmail.Text = "";
        tbDiaChi.Text = "";
        tbNgaySinh.Text = "";
        tbTenDayDu.Text = "";
        tbMatKhau.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}