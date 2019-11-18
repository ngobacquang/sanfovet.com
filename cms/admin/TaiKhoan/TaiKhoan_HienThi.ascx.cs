using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_TaiKhoan_TaiKhoan_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayTaiKhoan();
        }
    }

    private void LayTaiKhoan()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DangKy.Thongtin_Dangky();

        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrTaiKhoan.Text += @"
                    <tr id='maDong_" + dt.Rows[i]["TenDangNhap"] + @"'>
	                    <td class='cot cotTenDangNhap'>" + dt.Rows[i]["TenDangNhap"] + @"</td>
	                    <td class='cot cotEmail'>" + dt.Rows[i]["EmailDK"] + @"</td>
	                    <td class='cot cotDiaChi'>" + dt.Rows[i]["DiaChiDK"] + @"</td>
	                    <td class='cot cotHoTen'>" + dt.Rows[i]["TenDayDu"] + @"</td>
	                    <td class='cot cotNgaySinh'>" + dt.Rows[i]["NgaySinh"] + @"</td>
	                    <td class='cot cotGioiTinh'>" + dt.Rows[i]["GioiTinhDK"] + @"</td>
                        <td class='cotCongCu'>
                            <a href='/Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan&thaotac=ChinhSua&id=" + dt.Rows[i]["TenDangNhap"] + @"' class='sua' title='Sửa'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></a>
				            <a href=javascript:XoaTaiKhoan('" + dt.Rows[i]["TenDangNhap"] + @"') class='xoa' title='Xóa'><i class='fa fa-trash - o' aria-hidden='true'></i></a>
                        </td>
                    </tr> 
                ";
            }
        }
    }
}