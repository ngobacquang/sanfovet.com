using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_SanPham_DanhSachCacSanPham : System.Web.UI.UserControl
{
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"].ToString();
        }
        if (!IsPostBack)
        {
            ltrNhomSanPham.Text = LayDanhMucSanPham();
        }
    }
    #region Lấy nhóm và các sản phẩm
    private string LayDanhMucSanPham()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc_by_id(id);

        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += @"
                <a class='title-line' href='/Default.aspx?modul=SanPham&modulphu=DanhSachSanPham&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>
			        <h3>" + dt.Rows[i]["TenDM"] + @"</h3>
                </a>
                ";
                s += @"<div class='items " + dt.Rows[i]["MaDM"].ToString() + @"'>";
                s += LayTatCaDanhSachSanPhamTheoDanhMuc(dt.Rows[i]["MaDM"].ToString());
                s += @"<div style='clear:both'></div>";
                s += @"</div>";
            }
        }
        return s;
    }

    private string LayTatCaDanhSachSanPhamTheoDanhMuc(string MaDM)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.SanPham.Thongtin_Sanpham_by_madm_tatca(MaDM);

        string link = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            link = "Default.aspx?modul=SanPham&modulphu=ChiTietSanPham&id=" + dt.Rows[i]["MaSP"] + @"";

            s += @"
                <div class='col-3'>
                    <div class='item'>
				        <a href='" + link + @"' title='" + dt.Rows[i]["TenSP"] + @"'>
					        <img src='/pic/SanPham/" + dt.Rows[i]["AnhSP"] + @"' alt='" + dt.Rows[i]["TenSP"] + @"' />
				        </a>
				        <a class='title-sp' href='" + link + @"' title='" + dt.Rows[i]["TenSP"] + @"'>
					        " + dt.Rows[i]["TenSP"] + @"
				        </a>
				        <div class='desc'>
					        Giá: " + dt.Rows[i]["GiaSP"] + @"
				        </div>
			        </div>
			    </div>
            ";
        }

        return s;
    }
    #endregion
}