using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtDangNhap_Click(object sender, EventArgs e)
    {
        // Kiem tra xem trong database co tai khoan va mat khau nay khong
        DataTable dt = new DataTable();
        dt = emdepvn.DangKy.Thongtin_Dangky_by_id_matkhau(tbTenDangNhap.Text, emdepvn.MaHoa.MaHoaMD5(tbMatKhau.Text));

        if(dt.Rows.Count > 0)
        {
            // Dang nhap thanh cong || Luu gia tri vao session
            Session["DangNhap"] = "1"; // dang nhap thanh cong

            // Gan them thong tin tai khoan da dang nhap
            Session["TenDangNhap"] = dt.Rows[0]["TenDangNhap"];

            Response.Redirect("/Admin.aspx");
        }
        else
        {
            ltrThongBao.Text = "<div class='thongBao'>Ten dang nhap hoac mat khau khong dung</div>";
        }

    }
}