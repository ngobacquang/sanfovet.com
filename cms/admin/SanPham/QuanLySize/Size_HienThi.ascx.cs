using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLySize_Size_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            LayThongTinSize();
        }
    }

    private void LayThongTinSize()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Size.thongtin_size();

        if(dt.Rows.Count > 0)
        {
            for(int i=0; i<dt.Rows.Count; i++)
            {
                ltrSize.Text += @"
                    <tr id='maDong_" + dt.Rows[i]["SizeID"] + @"'>
                        <td class='cotSTT'>" + i + @"</td>
                        <td class='cotMa'>" + dt.Rows[i]["SizeID"] + @"</td>
                        <td class='cotTen'>" + dt.Rows[i]["TenSize"] + @"</td>
                        <td class='cotCongCu'>
                ";
                ltrSize.Text += @"
                    <a href='/Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ChinhSua&id=" + dt.Rows[i]["SizeID"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				    <a href='javascript:XoaSize(" + dt.Rows[i]["SizeID"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
                ";
            }
        }
    }
}