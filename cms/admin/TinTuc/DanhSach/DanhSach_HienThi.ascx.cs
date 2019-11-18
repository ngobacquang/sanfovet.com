using System;
using System.Data;

public partial class cms_admin_TinTuc_DanhSach_DanhSach_HienThi : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayDanhSach();
        }
    }

    private void LayDanhSach()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.TinTuc.Thongtin_Tintuc();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrDanhSach.Text += @"
                <tr id='maDong_" + dt.Rows[i]["TinTucID"] + @"'>
                    <td class='cotMa'>" + dt.Rows[i]["TinTucID"] + @"</td>
			        <td class='cotTen'>" + dt.Rows[i]["TieuDe"] + @"</td>
			        <td class='cotAnh'>
                        <img class='anhDaiDien' src='/pic/TinTuc/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                        <img class='anhDaiDienHover' src='/pic/TinTuc/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                    </td>
			        <td class='cotLuotXem'>" + dt.Rows[i]["LuotXem"] + @"</td>
			        <td class='cotNgayDang'>" + dt.Rows[i]["NgayDang"] + @"</td>
			        <td class='cotThuTu'>" + dt.Rows[i]["ThuTu"] + @"</td>
			        <td class='cotCongCu'>
            ";
            ltrDanhSach.Text += @"
				        <a href='/Admin.aspx?modul=TinTuc&modulphu=DanhSach&thaotac=ChinhSua&id=" + dt.Rows[i]["TinTucID"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				        <a href='javascript:XoaDanhSach(" + dt.Rows[i]["TinTucID"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
			        </td>
		        </tr>    
            ";
        }
    }
    
}