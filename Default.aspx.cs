using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string modul = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        #region Nếu là modul tin tức thì hiện danh mục tin, các modul khác thì hiện modul sản phẩm
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"].ToString();
        if (modul == "TinTuc")
        {
            phDanhMucTinTuc.Visible = true;
            phDanhMucSanPham.Visible = false;
        }
        else
        {
            phDanhMucTinTuc.Visible = false;
            phDanhMucSanPham.Visible = true;
        }
        #endregion


        if (!IsPostBack)
        {
            #region Kiểm tra đã đăng nhập hay chưa
            if(Session["KhachHang"] !=null && Session["KhachHang"] == "1")
            {
                phDaDangNhap.Visible = true;
                phChuaDangNhap.Visible = false;

                if (Session["KhachHang"] != null)
                {
                    ltrTenKhachHang.Text = Session["TenKh"].ToString();
                }
            }
            else
            {
                phDaDangNhap.Visible = false;
                phChuaDangNhap.Visible = true;
            }
            #endregion


            ltrLogo.Text = LayLogo();
            ltrBanner.Text = LayBanner();

            ltrmenu.Text = LayMenu();
            ltrDanhMucSanPham.Text = LayDanhMucSanPham();
            ltrDanhMucTinTuc.Text = LayDanhMucTinTuc();
        }
    }

    #region Lấy danh mục sản phẩm
    private string LayDanhMucSanPham()
    {

        string s = "";

        DataTable dt = new DataTable();
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc_by_MaDMCha("0");

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            s += @"
			<li><a href='/Default.aspx?modul=SanPham&modulphu=DanhSachSanPham&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>" + dt.Rows[i]["TenDM"] + @"</a></li>
        ";
        }
        return s;
    }
    #endregion

    #region Lấy danh mục tin tức
    private string LayDanhMucTinTuc()
    {

        string s = "";

        DataTable dt = new DataTable();
        dt = emdepvn.DanhMucTin.thongtin_danhmuctin_by_MaDMCha("0");

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            s += @"
			<li><a href='/Default.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>" + dt.Rows[i]["TenDM"] + @"</a></li>
        ";
        }
        return s;
    }
    #endregion


    #region Lấy menu
    private string LayMenu()
    {
        string s = "";

        DataTable dt = new DataTable();
        dt = emdepvn.Menu.Thongtin_Menu_by_mamenucha("0");

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string lienket = dt.Rows[i]["LienKet"].ToString();
            if(lienket == "")
            {
                lienket = "#";
            }
        s += @"
			<li class='menu1'><a href='" + lienket + @"' title='" + dt.Rows[i]["TenMenu"] + @"'>" + dt.Rows[i]["TenMenu"] + @"</a></li>
        ";
        }
        return s;
    }
    #endregion

    #region Lấy Logo
    private string LayLogo()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.NhomQuangCao.Thongtin_Nhomquangcao_by_vitriqc("logo");

        if (dt.Rows.Count > 0)
        {
            s = LayAnhLogo(dt.Rows[0]["NhomQuangCaoID"].ToString());
        }

        return s;
    }
    private string LayAnhLogo(string nhomQuangCaoID)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.QuangCao.Thongtin_Quangcao_by_nhomquangcaoid(nhomQuangCaoID);

        if (dt.Rows.Count > 0)
        {
            string lienket = dt.Rows[0]["LienKet"].ToString();

            if (lienket == "")
            {
                lienket = "#";
            }
            s += @"
            <a href='" + lienket + @"' title='" + dt.Rows[0]["TenQC"] + @"'>
	            <img src='/pic/QuangCao/" + dt.Rows[0]["AnhQC"] + @"' alt='" + dt.Rows[0]["TenQC"] + @"' />
            </a>
            ";
        }

        return s;
    }
    #endregion

    #region Lấy banner
    private string LayBanner()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.NhomQuangCao.Thongtin_Nhomquangcao_by_vitriqc("banner");

        if (dt.Rows.Count > 0)
        {
            s = LayTTBanner(dt.Rows[0]["NhomQuangCaoID"].ToString());
        }

        return s;
    }
    private string LayTTBanner(string nhomQuangCaoID)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.QuangCao.Thongtin_Quangcao_by_nhomquangcaoid(nhomQuangCaoID);

        if (dt.Rows.Count > 0)
        {
            string lienket = dt.Rows[0]["LienKet"].ToString();

            if (lienket == "")
            {
                lienket = "#";
            }
            s += @"
            <a href='" + lienket + @"' title='" + dt.Rows[0]["TenQC"] + @"'>
	            <img src='/pic/QuangCao/" + dt.Rows[0]["AnhQC"] + @"' alt='" + dt.Rows[0]["TenQC"] + @"' />
            </a>
            ";
        }

        return s;
    }
    #endregion
    
    protected void ltrDangXuat_Click(object sender, EventArgs e)
    {
        //Xóa các session
        Session["KhachHang"] = null;
        Session["MaKH"] = null;
        Session["TenKh"] = null;
        Session["DiaChiKH"] = null;
        Session["sdtKH"] = null;
        Session["EmailKH"] = null;

        // đẩy về trang chủ
        Response.Redirect("/Default.aspx");
    }
}