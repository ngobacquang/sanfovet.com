using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_TinTuc_TrangChuModulTinTuc : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ltrNhomTinTuc.Text = LayDanhMucTinTuc();
        }
    }
    #region Lấy danh muc tin va cac tin tuc ben trong
    private string LayDanhMucTinTuc()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMucTin.thongtin_danhmuctin_by_MaDMCha("0");

        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                s += @"
                <div class='baonewinde'>
                    <a class='titlehead' href='/Default.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>
                        <span class='ten'>" + dt.Rows[i]["TenDM"] + @"</span>
                    </a>
                    <div class='cb'></div>
                    <div class='list'>

                    "+ LayDanhSachTinTucTheoDanhMuc(dt.Rows[i]["MaDM"].ToString()) +@"
                    </div>
                </div>
                ";
            }
        }
        return s;
    }

    private string LayDanhSachTinTucTheoDanhMuc(string MaDM)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = emdepvn.TinTuc.Thongtin_Tintuc_by_madm(MaDM);

        string link = "";

        if (dt.Rows.Count > 0)
        {
            // Hien ra tin dau tien co anh dai dien
            link = "Default.aspx?modul=TinTuc&modulphu=ChiTietTinTuc&id=" + dt.Rows[0]["TinTucID"] + @"";

            s += @"
    <div class='box1'>
        <div class='khungAnh'>
            <a class='nentren' href='" + link + @"'></a>
            <a class='khungAnhCrop' href='" + link + @"'>
                <img class='imgmuctin' src='/pic/TinTuc/" + dt.Rows[0]["AnhDaiDien"] + @"' alt='" + dt.Rows[0]["TieuDe"] + @"' />
            </a>
        </div>
        <a class='title' href='" + link + @"' title='" + dt.Rows[0]["TieuDe"] + @"'>" + dt.Rows[0]["TieuDe"] + @"</a>
        <span class=''><span class='view'>" + dt.Rows[0]["LuotXem"] + @"</span><span class='date'>" + ((DateTime)dt.Rows[0]["NgayDang"]).ToString("dd/MM/yyyy") + @"</span></span>
        <div class='desc'>" + dt.Rows[0]["MoTa"] + @"</div>
        <a class='detail' href='" + link + @"' title='" + dt.Rows[0]["TieuDe"] + @"'>Xem thêm</a>

        <div class='cb'></div>
    </div>
";
            // hien ra cac tin khac
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                link = "Default.aspx?modul=TinTuc&modulphu=ChiTietTinTuc&id=" + dt.Rows[i]["TinTucID"] + @"";

                s += @"


                <a class='title1' href='" + link + @"' title='" + dt.Rows[i]["TieuDe"] + @"'>
                    " + dt.Rows[i]["TieuDe"] + @"
                    <span>(" + ((DateTime)dt.Rows[i]["NgayDang"]).ToString("dd/MM/yyyy") + @")</span>
                </a>
            ";
            }
        }
        return s;
    }
    #endregion
}