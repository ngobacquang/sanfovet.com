<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoan_HienThi.ascx.cs" Inherits="cms_admin_TaiKhoan_TaiKhoan_HienThi" %>

<div class="head">
	Các Tài Khoản Hiện Có
	<div class="action fr">
		<a class="btThemMoi" href="/Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan&thaotac=ThemMoi" title="Thêm mới tài khoản"><i class="fa fa-plus-circle" aria-hidden="true"></i></a>
	</div>
	<div class="cb">
	</div>
</div>
<div class="wapp">
	<table class="tb tbTaiKhoan">
		<tr>
			<th class="cot cotTenDangNhap">Tên đăng nhập</th>
			<th class="cot cotEmail">Email</th>
			<th class="cot cotDiaChi">Địa chỉ</th>
			<th class="cot cotHoTen">Họ tên</th>
			<th class="cot cotNgaySinh">Ngày sinh</th>
			<th class="cot cotGioiTinh">Giới tính</th>
			<th class="cot cotCongCu">Công cụ</th>
		</tr>
		<asp:Literal ID="ltrTaiKhoan" runat="server"></asp:Literal>
	</table>
</div>

<script>
	function XoaTaiKhoan(TenDangNhap) {
		if (confirm("Bạn có chắc chắn muốn xóa tài khoản có tên đăng nhập là: " + TenDangNhap + "?")) {
			// viết code xóa tài khoản tại đây
			$.post("cms/admin/TaiKhoan/Ajax/TaiKhoan.aspx",
			{
				"ThaoTac": "XoaTaiKhoan",
				"TenDangNhap": TenDangNhap
			},
			function(data, status){
				if(data == 1){ 
					$("#maDong_" + TenDangNhap).slideUp();
				}
				else {
					alert(data);
				}
			});
		}
	}
</script>