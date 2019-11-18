using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_TrangChu_TrangChuLoadControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ltrSilde.Text = LaySilde();

            ltrNhomSanPham.Text = LayNhomSanPham();
        }
    }

    #region Lấy nhóm và các sản phẩm
    private string LayNhomSanPham()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.Nhom.Thongtin_Nhomsp();

        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += @"
                <div class='title-line'>
			        <h3>" + dt.Rows[i]["TenNhom"] + @"</h3>
                </div>
                ";
                s += @"<div class='items " + dt.Rows[i]["NhomID"].ToString() + @"'>";
                s += LayDanhSachSanPhamTheoNhom(dt.Rows[i]["NhomID"].ToString(), dt.Rows[i]["SoSPHienThi"].ToString());
                s += @"<div style='clear:both'></div>";
                s += @"</div>";
            }
        }
        return s;
    }

    private string LayDanhSachSanPhamTheoNhom(string NhomID, string SoSPHienThi)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.SanPham.Thongtin_Sanpham_by_nhomid(NhomID, SoSPHienThi);

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

    #region Lấy slide
    private string LaySilde()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.NhomQuangCao.Thongtin_Nhomquangcao_by_vitriqc("slide");

        if (dt.Rows.Count > 0)
        {
            s = LayAnhSlide(dt.Rows[0]["NhomQuangCaoID"].ToString());
        }

        return s;
    }
    private string LayAnhSlide(string nhomQuangCaoID)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.QuangCao.Thongtin_Quangcao_by_nhomquangcaoid(nhomQuangCaoID);

        if (dt.Rows.Count > 0)
        {

            for(int i = 0; i<dt.Rows.Count; i++)
            {
                
                s += @"
                    <div data-p='225.00' style='display: none;'>                      
				        <img data-u='image' src='/pic/QuangCao/" + dt.Rows[i]["AnhQC"] + @"' alt='" + dt.Rows[i]["TenQC"] + @"' />
			        </div>
                ";
            }
            
        }

        return s;
    }
    #endregion
}