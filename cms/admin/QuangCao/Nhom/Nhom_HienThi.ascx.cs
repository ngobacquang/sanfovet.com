using System;
using System.Data;

public partial class cms_admin_QuangCao_Nhom_Nhom_HienThi : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayNhom();
        }
    }

    private void LayNhom()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.NhomQuangCao.Thongtin_Nhomquangcao();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrNhom.Text += @"
                <tr id='maDong_" + dt.Rows[i]["NhomQuangCaoID"] + @"'>
                    <td class='cotMa'>" + dt.Rows[i]["NhomQuangCaoID"] + @"</td>
			        <td class='cotTen'>" + dt.Rows[i]["TenNhomQuangCao"] + @"</td>
			        <td class='cotAnh'>
                        <img class='anhDaiDien' src='/pic/QuangCao/" + dt.Rows[i]["AnhDaiDienQC"] + @"'/>
                        <img class='anhDaiDienHover' src='/pic/QuangCao/" + dt.Rows[i]["AnhDaiDienQC"] + @"'/>
                    </td>
			        <td class='cotViTri'>" + dt.Rows[i]["ViTriQC"] + @"</td>
			        <td class='cotThuTu'>" + dt.Rows[i]["ThuTuNhomQC"] + @"</td>
			        <td class='cotCongCu'>
            ";
            ltrNhom.Text += @"
				        <a href='/Admin.aspx?modul=QuangCao&modulphu=Nhom&thaotac=ChinhSua&id=" + dt.Rows[i]["NhomQuangCaoID"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				        <a href='javascript:XoaNhom(" + dt.Rows[i]["NhomQuangCaoID"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
			        </td>
		        </tr>    
            ";
        }
    }

}