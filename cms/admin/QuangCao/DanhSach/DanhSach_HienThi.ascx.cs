using System;
using System.Data;

public partial class cms_admin_QuangCao_DanhSach_DanhSach_HienThi : System.Web.UI.UserControl
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
        dt = emdepvn.QuangCao.Thongtin_Quangcao();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrDanhSach.Text += @"
                <tr id='maDong_" + dt.Rows[i]["QuangCaoID"] + @"'>
                    <td class='cotMa'>" + dt.Rows[i]["QuangCaoID"] + @"</td>
			        <td class='cotTen'>" + dt.Rows[i]["TenQC"] + @"</td>
			        <td class='cotAnh'>
                        <img class='anhDaiDien' src='/pic/QuangCao/" + dt.Rows[i]["AnhQC"] + @"'/>
                        <img class='anhDaiDienHover' src='/pic/QuangCao/" + dt.Rows[i]["AnhQC"] + @"'/>
                    </td>
			        <td class='cotThuTu'>" + dt.Rows[i]["ThuTuQC"] + @"</td>
			        <td class='cotCongCu'>
            ";
            ltrDanhSach.Text += @"
				        <a href='/Admin.aspx?modul=QuangCao&modulphu=DanhSach&thaotac=ChinhSua&id=" + dt.Rows[i]["QuangCaoID"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				        <a href='javascript:XoaDanhSach(" + dt.Rows[i]["QuangCaoID"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
			        </td>
		        </tr>    
            ";
        }
    }

}