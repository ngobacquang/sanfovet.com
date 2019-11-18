using System;
using System.Data;

public partial class cms_admin_TinTuc_DanhMuc_DanhMuc_HienThi : System.Web.UI.UserControl
{

    string madmcha = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["madmcha"] != null)
            madmcha = Request.QueryString["madmcha"];

        if (!IsPostBack)
        {
            LayDanhMuc();
        }
    }

    private void LayDanhMuc()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMucTin.thongtin_danhmuctin_by_MaDMCha(madmcha);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrDanhMuc.Text += @"
            <tr id='maDong_" + dt.Rows[i]["MaDM"] + @"'>
                <td class='cotMa'>" + dt.Rows[i]["MaDM"] + @"</td>
			    <td class='cotTen'>" + dt.Rows[i]["TenDM"] + @"</td>
			    <td class='cotAnh'>
                    <img class='anhDaiDien' src='/pic/TinTuc/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                    <img class='anhDaiDienHover' src='/pic/TinTuc/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                </td>
			    <td class='cotThuTu'>" + dt.Rows[i]["ThuTu"] + @"</td>
			    <td class='cotCongCu'>";

            if (coDanhMucCon(dt.Rows[i]["MaDM"].ToString()))
                ltrDanhMuc.Text += @"

                    <a href='/Admin.aspx?modul=TinTuc&modulphu=DanhMuc&madmcha=" + dt.Rows[i]["MaDM"] + @"' class='dmcon' title='Danh mục con'><i class='fa fa-plus-square-o' aria-hidden='true'></i></a>
                ";
            ltrDanhMuc.Text += @"
				    <a href='/Admin.aspx?modul=TinTuc&modulphu=DanhMuc&thaotac=ChinhSua&id=" + dt.Rows[i]["MaDM"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				    <a href='javascript:XoaDanhMuc(" + dt.Rows[i]["MaDM"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
			    </td>
		    </tr>    
            ";
        }
    }

    /// <summary>
    /// Kiểm tra xem danh mục này có danh mục con hay không
    /// </summary>
    /// <param name="MaDM"></param>
    /// <returns></returns>
    bool coDanhMucCon(string MaDM)
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMucTin.thongtin_danhmuctin_by_MaDMCha(MaDM);

        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }
}