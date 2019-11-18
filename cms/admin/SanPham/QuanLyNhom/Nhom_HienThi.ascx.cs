using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyNhom_Nhom_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LayNhom();
    }

    private void LayNhom()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Nhom.Thongtin_Nhomsp();

        if(dt.Rows.Count > 0)
        {
            for (int i=0; i<dt.Rows.Count; i++)
            {
                ltrNhom.Text += @"
                    <tr id='maDong_" + dt.Rows[i]["NhomID"] + @"'>
                        <td class='cotMa'>" + dt.Rows[i]["NhomID"] +@"</td>
                        <td class='cotTen'>" + dt.Rows[i]["TenNhom"] + @"</td>
                        <td class='cotAnh'>
                            <img class='anhDaiDien' src='/pic/SanPham/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                            <img class='anhDaiDienHover' src='/pic/SanPham/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                        </td>
			            <td class='cotThuTu'>" + dt.Rows[i]["ThuTu"] + @"</td>
			            <td class='cotSSP'>" + dt.Rows[i]["SoSPHienThi"] + @"</td>
			            <td class='cotCongCu'>
                ";
                ltrNhom.Text += @"
				            <a href='/Admin.aspx?modul=SanPham&modulphu=Nhom&thaotac=ChinhSua&id=" + dt.Rows[i]["NhomID"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				            <a href='javascript:XoaNhom(" + dt.Rows[i]["NhomID"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
			            </td>
		            </tr>    
                ";
            }
        }
    }
}