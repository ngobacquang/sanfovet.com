using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyChatLieu_ChatLieu_HienThi : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LayChatLieu();
    }

    private void LayChatLieu()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.ChatLieu.thongtin_chatlieu();

        if(dt.Rows.Count > 0)
        {
            for(int i=0; i<dt.Rows.Count; i++)
            {
                ltrChatLieu.Text += @"
                    <tr id='maDong_" + dt.Rows[i]["ChatLieuID"] + @"'>
                        <td class='cotStt'>" + i +@"</td>
                        <td class='cotMa'>"+ dt.Rows[i]["ChatLieuID"] + @"</td>
                        <td class='cotTen'>" + dt.Rows[i]["TenChatLieu"] + @"</td>
                        <td class='cotCongCu'>
                ";
                ltrChatLieu.Text += @"
                            <a href='/Admin.aspx?modul=SanPham&modulphu=ChatLieu&thaotac=ChinhSua&id=" + dt.Rows[i]["ChatLieuID"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				            <a href='javascript:XoaChatLieu(" + dt.Rows[i]["ChatLieuID"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
                        </td>
                    </tr>
                ";
            }
        }
    }
}