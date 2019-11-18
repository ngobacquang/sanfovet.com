using System;
using System.Data;

public partial class cms_admin_SanPham_QuanLyDanhSach_DanhSach_HienThi : System.Web.UI.UserControl
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
        dt = emdepvn.SanPham.Thongtin_Sanpham();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            lrtDanhSach.Text += @"
                <tr id='maDong_" + dt.Rows[i]["MaSP"] + @"'>
	                <td class='cotMa'>" + dt.Rows[i]["MaSP"] + @"</td>
	                <td class='cotTen'>" + dt.Rows[i]["TenSP"] + @"</td>
	                <td class='cotAnh'>
                        <img class='anhDaiDien' src='/pic/SanPham/" + dt.Rows[i]["AnhSP"] + @"'/>
                        <img class='anhDaiDienHover' src='/pic/SanPham/" + dt.Rows[i]["AnhSP"] + @"'/>
                    </td>
	                <td class='cotSoLuong'>" + dt.Rows[i]["SoLuongSp"] + @"</td>
	                <td class='cotDonGia'>" + dt.Rows[i]["GiaSP"] + @"</td>
	                <td class='cotNgayTao'>" + dt.Rows[i]["NgayTao"] + @"</td>
	                <td class='cotCongCu'>
                        <a href='/Admin.aspx?modul=SanPham&modulphu=DanhSach&thaotac=ChinhSua&id=" + dt.Rows[i]["MaSP"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
		                <a href='javascript:XoaSanPham(" + dt.Rows[i]["MaSp"] + @")' class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
                    </td>
                </tr>   
            ";
        }
    }
}