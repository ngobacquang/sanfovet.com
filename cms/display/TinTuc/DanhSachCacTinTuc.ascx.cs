using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_TinTuc_DanhSachCacTinTuc : System.Web.UI.UserControl
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
            ltrNhomTinTuc.Text = LayDanhMucTinTuc();
        }
    }
    #region Lấy nhóm và các tin tuc
    private string LayDanhMucTinTuc()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMucTin.thongtin_danhmuctin_by_id(id);

        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += @"
                <a class='title-line' href='/Default.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>
			        <h3>" + dt.Rows[i]["TenDM"] + @"</h3>
                </a>
                ";
                s += @"<div class='items " + dt.Rows[i]["MaDM"].ToString() + @"'>";
                s += LayTatCaDanhSachTinTucTheoDanhMuc(dt.Rows[i]["MaDM"].ToString());
                s += @"<div style='clear:both'></div>";
                s += @"</div>";
            }
        }
        return s;
    }

    private string LayTatCaDanhSachTinTucTheoDanhMuc(string MaDM)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.TinTuc.Thongtin_Tintuc_by_madm_tatca(MaDM);

        string link = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            link = "Default.aspx?modul=TinTuc&modulphu=ChiTietTinTuc&id=" + dt.Rows[i]["TinTucID"] + @"";

            s += @"
                <div class='itemtintuc'>
                    <div class='khungAnh'>
                        <a class='khungAnhCrop' href='" + link + @"'>
                            <img class='imganh' src='/pic/TinTuc/" + dt.Rows[i]["AnhDaiDien"] + @"' alt='" + dt.Rows[i]["TieuDe"] + @"' />
                        </a>
                    </div>
                    <div class='itemContent'>
                        <a href='" + link + @"' class='title' title='" + dt.Rows[i]["TieuDe"] + @"'>
                            " + dt.Rows[i]["TieuDe"] + @"
                        </a>
                        <span class=''><span class='view'>" + dt.Rows[i]["LuotXem"] + @"</span><span class='date'>" + ((DateTime)dt.Rows[i]["NgayDang"]).ToString("dd/MM/yyyy") + @"</span></span>
                        <div class='desc'>
                            " + dt.Rows[i]["MoTa"] + @"
                        </div>
                        <div class='tar'><a href='" + link + @"' class='detail'>Xem chi tiết</a></div>
                    </div>
                    <div class='cb'><!----></div>
                </div>
            ";
        }

        return s;
    }
    #endregion
}