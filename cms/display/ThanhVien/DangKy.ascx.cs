using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_display_ThanhVien_DangKy : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtDangKi_Click(object sender, EventArgs e)
    {
        //Kiểm tra nếu chưa có ai đăng kí email này thi mới cho đăng kí
        if (DaTonTaiEmail(tbEmail.Text))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "","alert('Email này đã được đăng kí, bạn vui lòng chọn email khác');", true);
            tbEmail.Text = "";
        }
        else
        {
            //Thực hiện đăng kí

            string matkhau = emdepvn.MaHoa.MaHoaMD5(tbMatKhau.Text);
            emdepvn.KhachHang.Khachang_Inser(tbHoTen.Text, tbDiaChi.Text, tbSoDienThoai.Text, tbEmail.Text, matkhau, "");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Đã đăng ký tài khoản thành công, bạn có thể đăng nhập với tài khoản hiện tại');location.href='/Default.aspx?modul=ThanhVien&modulphu=DangNhap'", true);
        }
    }

    //kiểm tra xem email có tồn tại hay chưa
    private bool DaTonTaiEmail(string email)
    {
        DataTable dt = new DataTable();
        dt = emdepvn.KhachHang.Thongtin_Khachhang_by_emailkh(email);
        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }
}