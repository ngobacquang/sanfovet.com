using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_display_ThanhVien_DangNhap : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtDangNhap_Click(object sender, EventArgs e)
    {
        
        DataTable dt = new DataTable();
        dt = emdepvn.KhachHang.Thongtin_Khachhang_by_emailkh_matkhau(tbEmail.Text, emdepvn.MaHoa.MaHoaMD5(tbMatKhau.Text));

        if(dt.Rows.Count > 0)
        {
            Session["KhachHang"] = "1";
            Session["MaKH"] = dt.Rows[0]["MaKH"];
            Session["TenKh"] = dt.Rows[0]["TenKh"];
            Session["DiaChiKH"] = dt.Rows[0]["DiaChiKH"];
            Session["sdtKH"] = dt.Rows[0]["sdtKH"];
            Session["EmailKH"] = dt.Rows[0]["EmailKH"];

            Response.Redirect("/Default.aspx");
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Tài khoản hoặc mật khẩu không chính xác');", true);
        }
    }
}