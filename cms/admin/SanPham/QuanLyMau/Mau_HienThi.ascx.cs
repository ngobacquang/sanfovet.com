using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyMau_Mau_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayMau();
        }
    }

    private void LayMau()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Mau.Thongtin_Mau();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrMau.Text += @"
            <tr id='maDong_" + dt.Rows[i]["MauID"] + @"'>
                <td class='cotStt'>" + i + @"</td>
                <td class='cotMa'>" + dt.Rows[i]["MauID"] + @"</td>
			    <td class='cotTen'>" + dt.Rows[i]["TenMau"] + @"</td>
                <td class='cotCongCu'>
                    <a href='/Admin.aspx?modul=SanPham&modulphu=Mau&thaotac=ChinhSua&id=" + dt.Rows[i]["MauID"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				    <a href='javascript:XoaMau(" + dt.Rows[i]["MauID"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
                  </td>
		    </tr>    
            ";
        }
    }
}