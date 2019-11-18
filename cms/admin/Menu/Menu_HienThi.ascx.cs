using System;
using System.Data;

public partial class cms_admin_Menu_Menu_HienThi : System.Web.UI.UserControl
{
    string madmcha = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["madmcha"] != null)
            madmcha = Request.QueryString["madmcha"];

        if (!IsPostBack)
        {
            LayDanhSach();
        }
    }

    private void LayDanhSach()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Menu.Thongtin_Menu_by_mamenucha(madmcha);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrMenu.Text += @"
            <tr id='maDong_" + dt.Rows[i]["MaMenu"] + @"'>
                <td class='cotMa'>" + dt.Rows[i]["MaMenu"] + @"</td>
			    <td class='cotTen'>" + dt.Rows[i]["TenMenu"] + @"</td>
			    <td class='cotThuTu'>" + dt.Rows[i]["ThuTuMenu"] + @"</td>
			    <td class='cotCongCu'>";

            if (coDanhMucCon(dt.Rows[i]["MaMenu"].ToString()))
                ltrMenu.Text += @"

                    <a href='/Admin.aspx?modul=Menu&madmcha=" + dt.Rows[i]["MaMenu"] + @"' class='dmcon' title='Danh mục con'><i class='fa fa-plus-square-o' aria-hidden='true'></i></a>
                ";
            ltrMenu.Text += @"
				    <a href='/Admin.aspx?modul=Menu&thaotac=ChinhSua&id=" + dt.Rows[i]["MaMenu"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				    <a href='javascript:XoaMenu(" + dt.Rows[i]["MaMenu"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
			    </td>
		    </tr>    
            ";
        }
    }

    /// <summary>
    /// Kiểm tra xem danh mục này có danh mục con hay không
    /// </summary>
    /// <param name="maDMCha"></param>
    /// <returns></returns>
    bool coDanhMucCon(string maDMCha)
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Menu.Thongtin_Menu_by_mamenucha(maDMCha);

        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }
}